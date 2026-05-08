using System.Diagnostics;
using blackproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace blackproject.Controllers
{
    public class AgenciaController : Controller
    {
        private readonly ILogger<AgenciaController> _logger;

        public AgenciaController(ILogger<AgenciaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Agencia()
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