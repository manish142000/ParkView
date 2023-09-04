using Microsoft.AspNetCore.Mvc;
using ParkView.Models;
using System.Diagnostics;

namespace ParkView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IRoom _room;

        private readonly IRoomCategory _roomCategory;

        private readonly IHotel _hotel;

        public HomeController(ILogger<HomeController> logger, 
            IRoom room, IRoomCategory roomCategory, IHotel hotel)
        {
            _logger = logger;
            _room = room;
            _roomCategory = roomCategory;
            _hotel = hotel;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(SearchForm form)
        {
            if (ModelState.IsValid)
            {
                
                Console.WriteLine("its coming");
                return RedirectToAction("Index");
            }

            return View();
        }

        //[HttpPost]
        //public RedirectToActionResult SearchForms([FromBody] SearchForm form)
        //{
        //    Console.WriteLine(form.check_in);
        //    Console.WriteLine(form.check_out);
        //    Console.WriteLine(form.adultCount);
        //    Console.WriteLine(form.childrenCount);

        //    return RedirectToAction("Index");
        //}


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