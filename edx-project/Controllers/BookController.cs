using edx_project.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace edx_project.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid == true)
            {
                // business logic ...
            }
            else
            {
                // let user re-input the data
            }

            return new JsonResult(book);
        }

        [HttpPost]
        public IActionResult Update(Book book)
        {
            if (ModelState.IsValid == true)
            {
                // business logic ...
            }
            else
            {
                // let user re-input the data
            }

            return new JsonResult(book);
        }
    }
}