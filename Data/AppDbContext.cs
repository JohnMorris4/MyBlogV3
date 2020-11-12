using Microsoft.EntityFrameworkCore;
using MyBlogV3.Models;

namespace MyBlogV3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
            
        }
        public DbSet<Post> Posts { get; set; }
    }
}