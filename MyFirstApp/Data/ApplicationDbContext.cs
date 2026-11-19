using Microsoft.EntityFrameworkCore;
using MyFirstApp.Models;

namespace MyFirstApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Student> Students { get; set; } 
    }
}