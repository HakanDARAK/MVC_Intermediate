using MVC_Intermediate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC_Intermediate.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ProductCategoryModel model = new ProductCategoryModel();
            model.Products = Database.List.Where(i=>i.OnSale==true).ToList();
            model.NumberOfProduct = model.Products.Count();

            return View(model);
        }
        public ActionResult Details(int id)
        {
            var product = Database.List.Where(i => i.ProductID == id).FirstOrDefault();
            //FirstOrDefault returns first value if it doesn't find then null returned.
            return View(product);
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product entity)
        {
            Database.ElementAdd(entity);
            return View("ProductList",Database.List);
        }
        public ActionResult ContactReturn()
        {
            return View();
        }
    }
}