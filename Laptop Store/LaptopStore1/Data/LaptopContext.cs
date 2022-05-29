using LaptopStore1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LaptopStore1.Data
{
    public class LaptopContext :IdentityDbContext<AppUser>

    {
        public LaptopContext(DbContextOptions<LaptopContext> options) : base(options)
        {

        }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
