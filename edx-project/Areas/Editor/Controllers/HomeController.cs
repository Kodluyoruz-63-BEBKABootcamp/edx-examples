using Microsoft.AspNetCore.Mvc;

namespace edx_project.Areas.Editor.Controllers
{
    [Area("Editor")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
