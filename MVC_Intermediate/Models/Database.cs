using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Intermediate.Models
{
    public static class Database
    {
        private static List<Product> _list;
        static Database()
        {
            _list = new List<Product>()
            {
                new Product() { ProductID = 1, ProductName = "Samsung S6", Price = 1000, Explanation = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", OnSale = false ,Picture="1.jfif"},
                new Product() { ProductID = 2, ProductName = "Samsung S7", Price = 1100, Explanation = "Enough good", OnSale = false,Picture="2.jfif" },
                new Product() { ProductID = 3, ProductName = "Samsung S8", Price = 1200, Explanation = "Good", OnSale = false ,Picture="3.jfif"},
                new Product() { ProductID = 4, ProductName = "Samsung S9", Price = 1300, Explanation = "Good", OnSale = true ,Picture="4.jfif"},
                new Product() { ProductID = 5, ProductName = "Samsung S10", Price = 1400, Explanation = "Perfect", OnSale = true ,Picture="1.jfif"},
                new Product() { ProductID = 6, ProductName = "IPhone 12", Price = 1400, Explanation = "Perfect", OnSale = true ,Picture="2.jfif"},
                new Product() { ProductID = 7, ProductName = "IPhone 12 Pro Max", Price = 1400, Explanation = "Perfect", OnSale = false ,Picture="3.jfif"},
                new Product() { ProductID = 8, ProductName = "Macbook Pro M1 Max", Price = 1400, Explanation = "Perfect", OnSale = true ,Picture="4.jfif"},
                new Product() { ProductID = 9, ProductName = "Macbook Air M1", Price = 1400, Explanation = "Perfect", OnSale = true ,Picture="1.jfif"}
            };
        }
        public static List<Product> List
        {
            get { return _list; }
        }
        public static void ElementAdd(Product entity)
        {
            _list.Add(entity);
        }
        public static Product ProductDetail(int _ProductID)
        {
            Product entity = null;
            foreach (Product item in _list)
            {
                if (item.ProductID == _ProductID)
                {
                    entity = item;
                }
            }
            return entity;
        }
    }
}
