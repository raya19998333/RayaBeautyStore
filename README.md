<div align=center >
  
![Raya Beauty Logo](https://i.postimg.cc/jn2HHGN4/IMG-8077-removebg-preview.png)

# 🌿 Raya Beauty Store
</div>
**Raya Beauty Store** is a **C# Console Application** designed to manage and display products for the plant-based cosmetics brand **RAYA Beauty**.  
Built with **Entity Framework Core** and **SQL Server**, the app allows adding, searching, and categorizing products in a clean and professional interface.

---

## 📦 Features

- 🧴 Add and manage products with details like name, category, price, and availability  
- 🔍 Search products by name or category  
- 📂 Categorize products for better organization  
- 🗃️ Store data securely using EF Core and SQL Server  
- 🖥️ Console-based user interface with clear prompts and feedback  

---

## 🧠 Technologies Used

| Technology | Purpose |
|-------------|----------|
| **C# (.NET)** | Core programming language |
| **Entity Framework Core** | ORM for database operations |
| **SQL Server** | Relational database |
| **LINQ** | Querying and manipulating data |

---

## 🧪 Sample Product Class

```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public string Description { get; set; }
}
````

---

## 🗂️ Class Diagram

![Class Diagram](https://i.postimg.cc/VsKmCZPn/Screenshot-2025-11-10-135323.png)

---

## 🚀 Getting Started

1. **Clone the repository**

   ```bash
   git clone https://github.com/raya19998333/RayaBeautyStore.git
   ```
2. **Open the solution** in Visual Studio
3. **Configure your SQL Server connection string** in `appsettings.json`
4. **Run migrations**

   ```bash
   dotnet ef migrations add InitialCreate  
   dotnet ef database update
   ```
5. **Start the application** and follow the console prompts

---

## 💡 Future Enhancements

* 🔐 Add user authentication
* 📦 Implement order tracking and invoices
* 🪄 Build a GUI version using WPF or Blazor
* 📊 Export product reports to PDF or Excel

---

## 🎨 Brand Identity – RAYA Beauty

**RAYA Beauty** is a plant-based cosmetics brand that blends **nature, elegance, and sustainability**.
Our products are crafted for those who value **clean beauty**, **natural ingredients**, and **modern simplicity**.

| Element              | Description                                    |
| -------------------- | ---------------------------------------------- |
| 🌿 **Brand Essence** | Natural – Ethical – Empowering                 |
| 🎨 **Main Colors**   | Soft Lavender `#CFA3FF` & Pure White `#FFFFFF` |
| ✨ **Tone of Voice**  | Elegant, calm, and confident                   |
| 💋 **Tagline**       | *"Pure by Nature, Beautiful by Choice."*       |

---

## 🧾 Sample Products

| ID | Product Name      | Category    | Price | Availability   | Description                                                |
| -- | ----------------- | ----------- | ----- | -------------- | ---------------------------------------------------------- |
| 1  | Herbal Glow Serum | Skincare    | 24.99 | ✅ In Stock     | Lightweight serum with botanical extracts for radiant skin |
| 2  | Rose Mist Toner   | Skincare    | 18.50 | ✅ In Stock     | Refreshing toner with rose water and aloe vera             |
| 3  | Coconut Lip Balm  | Accessories | 9.99  | ❌ Out of Stock | Natural lip balm enriched with coconut oil                 |
| 4  | Matcha Face Mask  | Skincare    | 21.99 | ✅ In Stock     | Detoxifying mask for glowing and healthy skin              |

---

## 📬 Contact

For questions, feedback, or collaboration opportunities:
📧 **[raya.info@gmail.com](mailto:raya.info@gmail.com)**
🌐 [GitHub Profile](https://github.com/raya19998333)
📸 [Instagram: @RayaBeauty](https://www.instagram.com/RayaBeauty)

---

© 2025 **RAYA Beauty** | All Rights Reserved | MIT License

```

---

✅ **Highlights of this version:**
- Professional formatting and clear hierarchy  
- Consistent emoji-based visual sections  
- Tables for technologies, brand identity, and sample products  
- Optimized for GitHub rendering and readability  

Would you like me to make a **shorter “lite version”** (for portfolio use, around half the length)?
```
