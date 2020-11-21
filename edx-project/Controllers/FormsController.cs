using System;
using System.Net.Http;
using edx_project.Models.DomainModels;
using edx_project.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace edx_project.Controllers
{
    public class FormsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Blog()
        {
            var model = new BlogViewModel();

            model.Featured = new Blog() { Title = "Title of a longer featured blog post", Description = "Multiple lines of text that form the lede, informing new readers quickly and efficiently about what’s most interesting in this post’s contents." };

            model.SubFeatured = new Blog[2];
            var sub1 = new Blog() { Category = "World", Title = "Featured Post", PublishDate = DateTime.Now, Description = "This is a wider card with supporting text below as a natural lead-in to additional content.", ThumbnailUrl = "https://via.placeholder.com/200x150.png" };
            var sub2 = new Blog() { Category = "Design", Title = "Post Title", PublishDate = DateTime.Now.AddDays(-2), Description = "This is a wider card with supporting text below as a natural lead-in to additional content.", ThumbnailUrl = "https://via.placeholder.com/150.png" };
            model.SubFeatured[0] = sub1;
            model.SubFeatured[1] = sub2;

            model.About = "Etiam porta sem malesuada magna mollis euismod. Cras mattis consectetur purus sit amet fermentum. Aenean lacinia bibendum nulla sed consectetur.";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://loripsum.net/api/10/short/headers");
            var response = client.GetStringAsync(client.BaseAddress).Result;

            model.Blogs.Add(new Blog()
            {
                Author = "Mark",
                Description = "This blog post shows a few different types of content that’s supported and styled with Bootstrap. Basic typography, images, and code are all supported.",
                PublishDate = DateTime.Now.AddDays(-30),
                Title = "Sample blog post",
                Body = response //https://loripsum.net/api/10/short/headers
            });

            return View(model);
        }
    }
}