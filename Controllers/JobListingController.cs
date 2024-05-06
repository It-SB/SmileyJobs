using Microsoft.AspNetCore.Mvc;

namespace SmileyJobs.Controllers
{
    public class JobListingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult More()
        {
            return View();
        }
    }
}
