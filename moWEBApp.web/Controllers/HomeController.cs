using Microsoft.AspNetCore.Mvc;
using moWEBApp.web.Entity;
using moWEBApp.web.Models;
using System.Diagnostics;

namespace moWEBApp.web.Controllers
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
            string filmBasligi = "Film Baþlýðý";
            string filmAciklama = "Filmin Açýklamasý";
            string filmYonetmen = "Film Yönetmeni";
            DateTime baslangicTarihi = DateTime.Now;
            DateTime bitisTarihi = DateTime.Now;
            string[] oyuncular = { "oyuncu 1", "oyuncu 2", "oyuncu 3", "oyuncu 4" };

            var m = new Movie();

            m.Title = filmBasligi;
            m.Description = filmAciklama;
            m.Director = filmYonetmen;
            m.StartDate = baslangicTarihi;
            m.EndDate = bitisTarihi;

            return View(m);
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
