using System;
using edx_project.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace edx_project.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var book = new Book();
            book.ISBN = 155;
            book.Title = "My Book";
            book.PublishDate = DateTime.Now.AddDays(20);
            book.Description = "Book's description";
            book.Price = 55.7M;
            book.SamplePage = "http://www.google.com.tr";
            book.AuthorEmail = "hakkisagdic@gmail.com";
            book.AuthorPhone = "+905547895645";

            return View(book);
        }

        public IActionResult Create()
        {
            return View(null);
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