🇬🇧 English Description
This script processes a sprite sheet (with multiple sliced sprites) in Unity:

Reads and crops all individual sprites from the sprite sheet.

Scales each sprite according to the defined scaleFactor.
(Example: scaleFactor = 2 → 32x32 sprite → 64x64 sprite)

Aligns each sprite into a square format (adds padding if necessary).

Arranges all scaled sprites into a single sprite atlas (one image file).

Saves the resulting sprite atlas as a .png into Assets/Exported/.

⚙️ English Usage
Set your sprite sheet’s Sprite Mode to Multiple in Unity.

Use the Sprite Editor to slice the sprites.

Add this script to any GameObject.

Assign the sprite sheet to the spriteSheet field in the Inspector.

Set the desired scaleFactor (e.g. 2 for 2x enlargement).

Run the scene (hit Play).

The resulting sprite atlas will be saved at:
Assets/Exported/FinalScaledSheet.png

🇹🇷 Türkçe Açıklama
Bu script, Unity'deki çoklu sprite içeren bir sprite sheet dosyasını işler:

Sprite sheet içindeki tüm sprite’ları tek tek okur ve crop eder.

Her sprite’ı belirtilen scaleFactor oranında büyütür.
(Örnek: scaleFactor = 2 → 32x32 sprite → 64x64 sprite)

Her sprite'ı kare formatında hizalar (padding uygular).

Tüm sprite’ları tek bir sprite atlasına (tek görsel dosyası) dizer.

Son olarak, bu sprite atlasını Assets/Exported/ klasörüne .png olarak kaydeder.

⚙️ Türkçe Kullanım
Sprite sheet görselini Unity'de Sprite Mode = Multiple olarak ayarla.

Sprite Editor üzerinden tüm sprite’ları slice et.

Bu script'i bir GameObject üzerine ekle.

Inspector'dan spriteSheet alanına görseli sürükle ve bırak.

scaleFactor değerini ayarla (örnek: 2 → 2 kat büyütme).

Play tuşuna basarak çalıştır.

Oluşan sprite atlası bu dizine kaydedilir:
Assets/Exported/FinalScaledSheet.png
