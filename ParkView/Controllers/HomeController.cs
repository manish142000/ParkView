using Microsoft.AspNetCore.Mvc;
using ParkView.Models;
using System.Diagnostics;

namespace ParkView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(SearchForm form)
        {
            if( ModelState.IsValid)
            {
                Console.WriteLine(form.destination);
                Console.WriteLine(form.childrenCount);
                Console.WriteLine(form.check_in);
            }

            return View();
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