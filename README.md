# 🧩 Unity Sprite Sheet Processor & Atlas Generator

🇬🇧 **English Description**  
This Unity script processes a sliced sprite sheet and outputs a neatly scaled sprite atlas:

✅ Reads and crops all individual sprites.  
📏 Scales each sprite by a defined `scaleFactor`. (e.g. 2× → 32×32 → 64×64)  
📐 Aligns each sprite into a perfect square (adds padding if needed).  
🧱 Combines all scaled sprites into a single sprite atlas (one image).  
💾 Saves the final atlas as a `.png` at: `Assets/Exported/FinalScaledSheet.png`

### ⚙️ How to Use
1. Set your sprite sheet’s **Sprite Mode** to `Multiple`.
2. Open the **Sprite Editor** and slice the sprites.
3. Add this script to any GameObject.
4. In the Inspector, assign your sprite sheet to the `spriteSheet` field.
5. Set your desired `scaleFactor` (e.g. `2` for 2× enlargement).
6. Run the scene (press **Play**).
7. Check your exported atlas at: `Assets/Exported/FinalScaledSheet.png`

---

🇹🇷 **Türkçe Açıklama**  
Bu Unity script’i, dilimlenmiş bir sprite sheet dosyasını işleyerek ölçeklenmiş ve düzenli bir sprite atlası oluşturur:

✅ Sprite’ları tek tek okur ve crop eder.  
📏 Her bir sprite’ı belirtilen `scaleFactor` kadar büyütür. (örnek: 2× → 32×32 → 64×64)  
📐 Kare forma hizalar (gerekirse padding ekler).  
🧱 Bütün sprite’ları tek bir sprite atlasında birleştirir.  
💾 Sonuç dosyasını `.png` olarak şuraya kaydeder: `Assets/Exported/FinalScaledSheet.png`

### ⚙️ Kullanım
1. Sprite sheet görselinin **Sprite Mode** ayarını `Multiple` olarak değiştirin.  
2. **Sprite Editor** ile sprite’ları slice edin.  
3. Script’i herhangi bir GameObject’e ekleyin.  
4. Inspector’da `spriteSheet` alanına görselinizi atayın.  
5. `scaleFactor` değerini girin (örnek: `2` → 2 kat büyütme).  
6. Play tuşuna basarak çalıştırın.  
7. Atlas çıktısı: `Assets/Exported/FinalScaledSheet.png`

---

📁 **Output Preview:**  
_Coming Soon! (Add your image here if you'd like)_

🛠️ Unity Version: **2021+ recommended**  
📜 Script Type: `MonoBehaviour`, editor runtime

---

