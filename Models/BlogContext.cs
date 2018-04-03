using Microsoft.EntityFrameworkCore;

namespace Gojonesy_Blog.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext (DbContextOptions<BlogContext> options) : base(options)
        {

        }

    public DbSet<Gojonesy_Blog.Models.Blog> Blog {get; set;}
    }
}