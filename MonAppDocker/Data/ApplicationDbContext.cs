using Microsoft.EntityFrameworkCore;
using MonAppDocker.Models;
using MONAPPDOCKER.Models;

namespace MonAppDocker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product>Products { get; set; }

    }
}
