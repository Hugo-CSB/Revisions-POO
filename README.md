# 🎯 Projet C# – Formes Géométriques

## 📌 Description
Application console en **C# (.NET Framework)** permettant de manipuler des formes géométriques simples :  
⚪ Cercle  
⬛ Rectangle  

Chaque forme hérite de la classe abstraite `Forme` et implémente ses propres méthodes :  
- `Aire()`  
- `Perimetre()`

---

## 🏗️ Structure du projet
Geometriques/
│── src/              
│   ├── Program.cs
│   ├── Forme.cs
│   ├── Cercle.cs
│   └── Rectangle.cs
│
├── Tests/            
│   ├── CercleTest.cs
│   ├── RectangleTest.cs
│   ├── PointTest.cs
│
├── docs/             
│   ├── diagramme_formes.png
│
└── README.md


---


---

## 📊 Diagramme UML
👉 diagramme_formes.png 

---

## 🚀 Exemple d’utilisation
Dans `Program.cs` :
```csharp
Cercle c = new Cercle(5);
Console.WriteLine(c);

Rectangle r = new Rectangle(4, 6);
Console.WriteLine(r);

Résultat attendu en console :

Cercle (rayon=5) → Aire=78,54, Périmètre=31,42
Rectangle (L=4, l=6) → Aire=24, Périmètre=20

✨ Auteur

Projet réalisé dans le cadre du cours C# (2025).
👨‍💻 Auteur : Azeflow
