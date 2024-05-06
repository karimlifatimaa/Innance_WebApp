using Microsoft.AspNetCore.Mvc;

namespace Innance.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
