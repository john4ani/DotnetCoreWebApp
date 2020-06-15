using Microsoft.AspNetCore.Mvc;


namespace DotnetCoreWebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
