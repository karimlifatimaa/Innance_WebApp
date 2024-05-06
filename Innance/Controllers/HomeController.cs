using Innance.DAl;
using Innance.Models;
using Innance.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Innance.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _dbContext;
        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            //Client client = new Client()
            //{

            //    Fullname="Nicat Mecidov",
            //    Description= "chunks as necessary, making this the first true generator on the Internet.",
            //    PhotoUrl= "images/client-1.jpg"

            //};
            //Client client1 = new Client()
            //{
            //    Fullname = "Ramiz Mecidov",
            //    Description = "chunks as necessary, making this the first true generator on the Internet.",
            //    PhotoUrl = "images/client-2.jpg"

            //};
            //List<Client> clients = new List<Client>();
            //clients.Add(client1);
            //clients.Add(client);

            //Service service = new Service()
            //{
            //    Name = "Maintenance",
            //    Description = "bhgyhgyhghyg",
            //    PhotoUrl = "images/s1.png",

            //};
            //Service service1 = new Service()
            //{
            //    Name = "Maintenance",
            //    Description = "bhgyhgyhghyg",
            //    PhotoUrl = "images/s1.png",

            //};
            //Service service2 = new Service()
            //{
            //    Name = "Maintenance",
            //    Description = "bhgyhgyhghyg",
            //    PhotoUrl = "images/s1.png",

            //};
            //List<Service> services = new List<Service>();   
            //services.Add(service);
            //services.Add(service2);
            //services.Add(service1);

            HomeVM homeVM = new HomeVM()
            {
                Clients = _dbContext.Clients.ToList(),
                Services = _dbContext.Services.ToList()
             };
            //_dbContext.Clients.Add(client);
            //_dbContext.Clients.Add(client1);
            //_dbContext.SaveChanges();
            //_dbContext.Services.Add(service1);
            //_dbContext.Services.Add(service2);
            //_dbContext.Services.Add(service);
            //_dbContext.SaveChanges();

            return View(homeVM);
        }
    }
}
