using eCom.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCom.DataAccess.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
                
        }
        

        public DbSet<Category> Categories { get; set; }= default!;
       // public DbSet<Product> Products { get; set; } = default!;
    }
}
