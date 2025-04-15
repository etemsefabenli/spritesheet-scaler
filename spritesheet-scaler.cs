#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections.Generic;

public class SpriteSheetToScaledAtlas : MonoBehaviour
{
    [Header("Multiple Mode Sprite Sheet")]
    public Texture2D spriteSheet;

    [Header("Export Ayarları")]
    public int scaleFactor = 2; // 2x: 32 → 64
    public string exportFileName = "FinalScaledSheet";
    public string exportFolder = "Assets/Exported";

    void Start()
    {
        if (spriteSheet == null)
        {
            Debug.LogError("Lütfen sprite sheet atayın.");
            return;
        }

        string path = AssetDatabase.GetAssetPath(spriteSheet);
        Object[] assets = AssetDatabase.LoadAllAssetsAtPath(path);

        List<Sprite> sprites = new List<Sprite>();
        foreach (Object asset in assets)
        {
            if (asset is Sprite sprite)
                sprites.Add(sprite);
        }

        if (sprites.Count == 0)
        {
            Debug.LogError("Sprite sheet içerisinde hiç sprite bulunamadı.");
            return;
        }

        int originalSize = Mathf.RoundToInt(sprites[0].rect.width); 
        int targetSize = originalSize * scaleFactor;                

        int columns = Mathf.CeilToInt(Mathf.Sqrt(sprites.Count));
        int rows = Mathf.CeilToInt((float)sprites.Count / columns);

        Texture2D atlas = new Texture2D(columns * targetSize, rows * targetSize);
        atlas.filterMode = FilterMode.Point;

        for (int i = 0; i < sprites.Count; i++)
        {
            Sprite sprite = sprites[i];
            Texture2D scaled = ExtractAndScaleSprite(sprite, scaleFactor, targetSize, targetSize); 

            int x = (i % columns) * targetSize;
            int y = (rows - 1 - i / columns) * targetSize;

            for (int sx = 0; sx < targetSize; sx++)
            {
                for (int sy = 0; sy < targetSize; sy++)
                {
                    atlas.SetPixel(x + sx, y + sy, scaled.GetPixel(sx, sy));
                }
            }
        }

        atlas.Apply();

        Directory.CreateDirectory(exportFolder);
        string fullPath = Path.Combine(exportFolder, $"{exportFileName}.png");
        File.WriteAllBytes(fullPath, atlas.EncodeToPNG());
        AssetDatabase.Refresh();

        Debug.Log($"✅ Sprite atlas oluşturuldu: {fullPath}");
    }

    Texture2D ExtractAndScaleSprite(Sprite sprite, int scale, int targetW, int targetH)
    {
        Rect rect = sprite.rect;
        Texture2D source = sprite.texture;

        Texture2D cropped = new Texture2D((int)rect.width, (int)rect.height);
        for (int y = 0; y < rect.height; y++)
        {
            for (int x = 0; x < rect.width; x++)
            {
                Color color = source.GetPixel((int)rect.x + x, (int)rect.y + y);
                cropped.SetPixel(x, y, color);
            }
        }
        cropped.Apply();

        int newW = (int)rect.width * scale;
        int newH = (int)rect.height * scale;

        Texture2D scaled = new Texture2D(targetW, targetH);
        scaled.filterMode = FilterMode.Point;

        Color clear = new Color(0, 0, 0, 0);
        for (int x = 0; x < targetW; x++)
        {
            for (int y = 0; y < targetH; y++)
            {
                scaled.SetPixel(x, y, clear); 
            }
        }

        for (int y = 0; y < (int)rect.height; y++)
        {
            for (int x = 0; x < (int)rect.width; x++)
            {
                Color pixel = cropped.GetPixel(x, y);
                for (int dy = 0; dy < scale; dy++)
                {
                    for (int dx = 0; dx < scale; dx++)
                    {
                        int px = x * scale + dx;
                        int py = y * scale + dy;
                        scaled.SetPixel(px, py, pixel);
                    }
                }
            }
        }

        scaled.Apply();
        return scaled;
    }
}
#endif
