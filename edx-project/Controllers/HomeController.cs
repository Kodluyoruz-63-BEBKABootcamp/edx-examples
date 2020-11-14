using System;
using System.Diagnostics;
using edx_project.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace edx_project.Controllers
{
    //[Route("main")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[Route("index")]
        public IActionResult Index(int id, string name, int age)
        {
            ViewBag.age = age;
            ViewBag.ID = id;
            ViewBag.name = name;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ViewWithoutModel()
        {
            ViewBag.MyProperty = "My Property";
            int number = (new Random()).Next();
            return View(5); //View(number);
        }

        public IActionResult Age()
        {
            AgeViewModel model = new AgeViewModel();
            return View(model);
        }

        public IActionResult AgeRestriction(int age)
        {
            if (age >= 18)
            {
                return RedirectToAction("above18");
            }
            else
            {
                return RedirectToAction("under18");
            }
        }

        public IActionResult JsonExample(double r, double h)
        {
            double v = Math.PI * Math.Pow(r, 2) * h;
            return new JsonResult(v);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
