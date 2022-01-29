using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Intermediate.Models
{
    public class ProductCategoryModel
    {
        public int NumberOfProduct { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}