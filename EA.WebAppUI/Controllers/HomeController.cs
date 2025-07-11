using Microsoft.AspNetCore.Mvc;

namespace EA.WebAppUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Index);

        }

        public IActionResult About()
        {
            return View(About);
        }

        public IActionResult Contact()
        {
            return View(Contact);
        }
        public IActionResult BlogPost()
        {
            return View(BlogPost);
        }

    }

    
}
