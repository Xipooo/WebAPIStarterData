using Microsoft.EntityFrameworkCore;
using WebAPIStarterData.Models;

namespace WebAPIStarterData
{
    public class WebAPIStarterContext : DbContext
    {
        public WebAPIStarterContext(DbContextOptions<WebAPIStarterContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}