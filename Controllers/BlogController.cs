using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Gojonesy_Blog.Controllers
{
    public class BlogController : Controller
    {
        // Get the blogs!
        public IActionResult Index()
        {
            return View();
        }

        
    }
}