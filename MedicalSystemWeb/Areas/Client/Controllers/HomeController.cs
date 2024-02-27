using MedicalSystem.ApplicationCore.Services;
using MedicalSystem.ApplicationCore.Services.Interfaces;
using MedicalSystem.ApplicationCore.Services.Services;
using MedicalSystem.Infrastructure.Repository.Interfaces;
using MedicalSystem.Models.Models;
using MedicalSystemWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MedicalSystemWeb.Areas.Client.Controllers
{
    [Area("Client")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfService _unitOfService;

        public HomeController(ILogger<HomeController> logger, IUnitOfService unitOfService)
        {
            _logger = logger;
            _unitOfService = unitOfService;
        }

        public IActionResult Index()
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
