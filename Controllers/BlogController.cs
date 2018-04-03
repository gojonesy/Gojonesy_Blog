using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using Gojonesy_Blog.Models;
using System.Linq;

namespace Gojonesy_Blog.Controllers
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {

        private readonly BlogContext db = new BlogContext();

        // Get the blogs!
        [HttpGet("[action]")]

        public IQueryable<Blog> GetBlogs()
        {
            return db.Blog;
        }

        
    }
}