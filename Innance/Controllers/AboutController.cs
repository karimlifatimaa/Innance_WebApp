using Microsoft.AspNetCore.Mvc;

namespace Innance.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
