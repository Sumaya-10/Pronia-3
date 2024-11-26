using Microsoft.AspNetCore.Mvc;

namespace Pronia.MVC.Area.Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
