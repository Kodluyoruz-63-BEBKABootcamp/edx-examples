using edx_project.Models.DomainModels;
using edx_project.Models.ModelBinding;
using Microsoft.AspNetCore.Mvc;

namespace edx_project.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create([ModelBinder(BinderType = typeof(GameModelBinder))] Game game)
        {
            return new JsonResult(game);
        }
    }
}