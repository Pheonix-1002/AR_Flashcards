# 📱 AR Flashcards with Vuforia + Unity

An Augmented Reality (AR) flashcard application built in **Unity** using **Vuforia Engine**.  
This project recognizes image-based flashcards (like fruits, vehicles, Earth, etc.) and displays corresponding **3D models** on top of them in real-time.

---

## 🚀 Features
- 🔍 **Image Target Recognition** – Uses Vuforia’s database to detect printed flashcards.  
- 🏗 **Prefab Spawning** – Instantiates 3D prefabs (fruits, cars, Earth, etc.) when a card is detected.  
- 🔄 **Auto Hide** – Object disappears automatically when the flashcard is removed from view.  
- 🎨 **Textured Models** – Models include applied textures (Earth globe, fruits, etc.).  
- 📸 **AR Camera Integration** – Uses Vuforia AR Camera instead of Unity’s default camera.  

---

## 📂 Project Structure
Assets/
│── Editor/
│── Migration/
│ └── Vuforia/
│ ├── FlashcardsDB/ # Image Target database
│ ├── CarPrefabs/ # Prefabs for car objects
│ └── FruitPrefabs/ # Prefabs for fruits (apple, dragonfruit, etc.)
│── EarthRendering Free/ # Earth model + textures
│── NekoLegends/ # Example 3D assets


---
---

## 🛠️ Tech Stack
- **Unity** 2021.3.x (LTS recommended)  
- **Vuforia Engine** (Image Target tracking)  
- **C#** (for scripting and event handling)  

---

## ⚙️ Setup & Installation
1. Clone this repository:  
   ```bash
   git clone https://github.com/Pheonix-1002/AR_Flashcards.git


   📸 How It Works

Image Target is recognized from the Vuforia Database.

Default Observer Event Handler triggers prefab spawn on detection.

When the target is lost, the prefab is hidden automatically.

🧩 To-Do / Improvements

✅ Add more categories (Animals, Shapes, etc.)

🎵 Add sound effects (e.g., “Apple” pronunciation when apple appears).

✨ Add UI overlay for card details.

📱 Export to Android APK / iOS build.
