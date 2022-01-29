using MVC_Intermediate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Intermediate.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly] 
        public PartialViewResult CategoryMenu()
        {
            List<Category> categories = new List<Category>()
            {
                new Category(){CategoryID=1,CategoryName="Phone"},
                new Category(){CategoryID=2,CategoryName="Tablet"},
                new Category(){CategoryID=2,CategoryName="Laptop"}
            };
            return PartialView("CategoryMenu",categories);
        }
    }
}