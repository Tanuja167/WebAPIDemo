using Microsoft.EntityFrameworkCore;
using WebAPIDemo.Model;

namespace WebAPIDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Employee> emp { get; set; }
    }
    
}
