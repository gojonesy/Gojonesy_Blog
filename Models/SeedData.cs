using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Gojonesy_Blog.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BlogContext(serviceProvider.GetRequiredService<DbContextOptions<BlogContext>>()))
                {
                    if (context.Blog.Any())
                    {
                        return; // DB is already seeded.
                    }

                    context.Blog.AddRange(
                        new Blog
                        {
                            Title = "Welcome to my blog",
                            PostDate = DateTime.Parse("2018-03-29"),
                            PostBody = "Welcome to my new blog. Here is some Bacon ipsum.\n Bacon ipsum dolor amet landjaeger strip steak jerky chicken brisket, \ntri - tip porchetta.Ham capicola ribeye boudin tail pork.Shank tenderloin pastrami kielbasa, \nswine drumstick sirloin alcatra hamburger prosciutto.Buffalo alcatra jowl, \nground round porchetta ball tip t - bone short ribs.Beef burgdoggen shoulder kevin alcatra pork loin tenderloin.Short loin pork chop flank, \ndoner swine shoulder tenderloin venison sirloin fatback salami porchetta short ribs."
                        }, 
                        new Blog
                        {
                            Title = "My second post.",
                            PostDate = DateTime.Parse("2018-04-02"),
                            PostBody = "Welcome to my second post.. Here is some Bacon ipsum.\n Bacon ipsum dolor amet landjaeger strip steak jerky chicken brisket, \ntri - tip porchetta.Ham capicola ribeye boudin tail pork.Shank tenderloin pastrami kielbasa, \nswine drumstick sirloin alcatra hamburger prosciutto.Buffalo alcatra jowl, \nground round porchetta ball tip t - bone short ribs.Beef burgdoggen shoulder kevin alcatra pork loin tenderloin.Short loin pork chop flank, \ndoner swine shoulder tenderloin venison sirloin fatback salami porchetta short ribs."
                        }
                    );

                    context.SaveChanges();
                }
        }
    }
}