using Innance.Models;
using Microsoft.EntityFrameworkCore;

namespace Innance.DAl
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Service> Services { get; set; }

    }
}
