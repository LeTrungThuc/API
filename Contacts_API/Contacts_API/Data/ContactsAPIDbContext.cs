using Contacts_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Contacts_API.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductStatus> ProductStatuses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transport> Transports { get; set; }
    }
}
