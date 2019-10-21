using Microsoft.EntityFrameworkCore;
using WebAPIStarterData.Models;

namespace WebAPIStarterData
{
    public class WebAPIStarterContext : DbContext
    {
        public WebAPIStarterContext(DbContextOptions<WebAPIStarterContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CustomerAddress>()
                .HasKey(ca => new { ca.CustomerId, ca.AddressId });

            builder.Entity<CustomerAddress>()
                .HasOne(ca => ca.Customer)
                .WithMany(ca => ca.CustomerAddresses)
                .HasForeignKey(ca => ca.CustomerId);

            builder.Entity<CustomerAddress>()
                .HasOne(ca => ca.Address)
                .WithMany(ca => ca.CustomerAddresses)
                .HasForeignKey(ca => ca.AddressId);
        }
    }
}