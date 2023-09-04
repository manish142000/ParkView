using Microsoft.AspNetCore.Mvc;
using ParkView.Models;
using System.Diagnostics;
using MvcContrib.Filters;


namespace ParkView.Controllers
{
    [PassParametersDuringRedirect]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly HotelDbContext _context;

        public HomeController(ILogger<HomeController> logger , HotelDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]

        //public RedirectToActionResult Index(SearchForm form)
        //{
        //    if( form == null)
        //    {
        //        return RedirectToAction("Index");
        //    }

        //}

        public IActionResult Rooms()
        {
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