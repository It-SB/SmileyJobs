using Microsoft.AspNetCore.Mvc;

namespace SmileyJobs.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
