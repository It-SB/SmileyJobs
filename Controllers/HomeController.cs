using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Smile.Models;
using Smile.Models.Jobs;
using System.Diagnostics;

namespace Smile.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly JobsContext _context;

        public HomeController(JobsContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public static class StringHelper
        {
            public static string Truncate(string input, int wordLimit)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    return string.Empty;
                }

                string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (words.Length <= wordLimit)
                {
                    return input;
                }

                return string.Join(" ", words.Take(wordLimit)) + "...";
            }
        }

        // GET: Jobs
        public async Task<IActionResult> Index()
        {
            try
            {
                var results = await _context.Jobs.ToListAsync();

                var resultsFiltered = results.Where(x => x.isFeatured == true ).OrderBy(x => x.PostedDate).ToList();

                return View(resultsFiltered);
            }
            catch (Exception)
            {
                return View(new List<Job>());
            }
        }

        // GET: Jobs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await _context.Jobs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
