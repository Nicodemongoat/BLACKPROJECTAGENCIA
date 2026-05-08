using System.Diagnostics;
using blackproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace blackproject.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly ILogger<FuncionarioController> _logger;

        public FuncionarioController(ILogger<FuncionarioController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Funcionario()
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