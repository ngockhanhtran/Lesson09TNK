using Microsoft.AspNetCore.Mvc;

namespace TnkLesson09.Areas.Admin.Controllers
{
    [Area("Admin")] 
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}