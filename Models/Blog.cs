using System;

namespace Gojonesy_Blog.Models
{
    public class Blog
    {
        public int ID {get; set;}
        public string Title {get; set;}
        public DateTime PostDate {get; set;}
        public string PostBody {get; set;}
    }
}