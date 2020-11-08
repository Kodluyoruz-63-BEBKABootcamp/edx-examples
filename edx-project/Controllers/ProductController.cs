using System.Collections.Generic;
using edx_project.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace edx_project.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowAll()
        {
            ViewData["Heading"] = "All Products"; //ViewBag, ViewData, TempData
            var products = new List<Product>();

            Product pro1 = new Product();
            pro1.ID = 102;
            pro1.Name = "Computer";
            pro1.Price = 5;

            products.Add(new Product { ID = 101, Name = "Apple", Price = 1.1 }); //object initializer
            products.Add(new Product { ID = 202, Name = "Bike", Price = 2.2 });
            products.Add(new Product { ID = 303, Name = "Calculator", Price = 3.3 });
            products.Add(pro1);

            return View(products);
        }
    }
}