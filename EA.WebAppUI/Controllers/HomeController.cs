using Microsoft.AspNetCore.Mvc;

namespace EA.WebAppUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
