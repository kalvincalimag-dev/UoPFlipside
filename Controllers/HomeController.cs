using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UPangFlipside.Models;


namespace UPangFlipside.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Cite()
        {
            return View();
        }
        public IActionResult Cahs()
        {
            return View();
        }
        public IActionResult Cma()
        {
            return View();
        }
        public IActionResult Cea()
        {
            return View();
        }
        public IActionResult Cas()
        {
            return View();
        }
        public IActionResult Ccje()
        {
            return View();
        }
        public IActionResult Shs()
        {
            return View();
        }
        public IActionResult Cela()
        {
            return View();
        }

        public IActionResult DeptCondensed()
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

