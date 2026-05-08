using System.Diagnostics;
using blackproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace blackproject.Controllers
{
    public class CarteiraController : Controller
    {
        private readonly ILogger<CarteiraController> _logger;

        public CarteiraController(ILogger<CarteiraController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Carteira()
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
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ??
                            HttpContext.TraceIdentifier
            });
        }
    }
}