using Microsoft.EntityFrameworkCore;

namespace Gojonesy_Blog.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

        public DbSet<Gojonesy_Blog.Models.TodoItem> TodoItem { get; set; }
    }
}