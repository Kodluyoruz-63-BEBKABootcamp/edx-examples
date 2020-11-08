using System;
using System.Collections.Generic;
using edx_project.Models.DomainModels;
using edx_project.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace edx_project.Controllers
{
    public class IMDBController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ActorList()
        {
            var actorList = new List<Actor>();
            actorList.Add(new Actor { Actor_ID = 1, First_Name = "Parker", Last_Name = "Posey", Last_Update = DateTime.Now });
            actorList.Add(new Actor { Actor_ID = 2, First_Name = "Tara", Last_Name = "Reid", Last_Update = DateTime.Now });
            actorList.Add(new Actor { Actor_ID = 3, First_Name = "Matthew", Last_Name = "Rhys", Last_Update = DateTime.Now });

            return View(actorList);
        }

        public IActionResult DirectorFilms()
        {
            DirectorFilmsViewModel viewModel = new DirectorFilmsViewModel();
            viewModel.Director = new Director() { Name = "Tarantino" };
            viewModel.Films = new List<Film>();

            viewModel.Films.Add(new Film() { Name = "Pulp Fiction" });
            viewModel.Films.Add(new Film() { Name = "Kill Bill" });

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult CreateActor(string full_name)
        {
            Create(full_name);
            return View();
        }

        [HttpPost]
        public IActionResult CreateActor(string first_name, string last_name)
        {
            Create(first_name,last_name);

            return View();
        }

        [HttpPost]
        public IActionResult CreateActor(Actor actor)
        {
            return View();
        }

        #region internal methods
        
        private void Create(string full)
        {
            string[] seperated = full.Split(" ");
            Create(seperated[0], seperated[1]);
        }

        private void Create(string first,string last)
        {
            Actor actor = new Actor();
            actor.First_Name = first;
            actor.Last_Name = last;
            actor.Last_Update = DateTime.Now;
            int id = 4; //created by entity framework core.
            actor.Actor_ID = 4;

            if (id > 0)
            {
                ViewBag.success = "Actor created";
            }
            else
            {
                ViewBag.success = "Actor could not be created.";
            }
        }
        #endregion
    }
}