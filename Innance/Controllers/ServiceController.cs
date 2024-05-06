using Innance.DAl;
using Microsoft.AspNetCore.Mvc;

namespace Innance.Controllers
{
    public class ServiceController : Controller
    {
        AppDbContext _dbContext;
        public ServiceController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var services = _dbContext.Services.ToList();
            return View(services);
        }
    }
}
