using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Intermediate.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Explanation { get; set; }
        public double Price { get; set; }
        public bool OnSale { get; set; }
        public string Picture { get; set; }
    }
}