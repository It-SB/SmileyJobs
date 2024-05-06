using Microsoft.AspNetCore.Mvc;

namespace SmileyJobs.Controllers
{
    public class JobDetails : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
