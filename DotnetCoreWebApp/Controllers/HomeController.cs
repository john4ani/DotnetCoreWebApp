using DotnetCoreWebApp.Models;
using DotnetCoreWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotnetCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        private IPieRepository _pieRepository;

        // GET: /<controller>/
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheWeek = _pieRepository.PiesOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
