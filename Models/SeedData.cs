using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5Database.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookDBContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookDBContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            //Add the following books to the database
            if(!context.Projects.Any())
            {
                context.Projects.AddRange(

                    //Prof Hilton's books
                    new Project
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorMiddle = "",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        NumPages = 1488,
                        Price = 9.95
                    },

                    new Project
                    {
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris",
                        AuthorMiddle = "Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        NumPages = 944,
                        Price = 14.58
                    },

                    new Project
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorMiddle = "",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        NumPages = 832,
                        Price = 21.54
                    },

                    new Project
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald",
                        AuthorMiddle = "C.",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        NumPages = 864,
                        Price = 11.61
                    },

                    new Project
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Linda",
                        AuthorMiddle = "",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        NumPages = 528,
                        Price = 13.33
                    },

                    new Project
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorMiddle = "",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        NumPages = 288,
                        Price = 15.95
                    },

                    new Project
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorMiddle = "",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        NumPages = 304,
                        Price = 14.99
                    },

                    new Project
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorMiddle = "",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        NumPages = 240,
                        Price = 21.66
                    },

                    new Project
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorMiddle = "",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fictions",
                        Category = "Business",
                        NumPages = 400,
                        Price = 29.16
                    },

                    new Project
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorMiddle = "",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        NumPages = 642,
                        Price = 15.03
                    },

                    //My added books
                    new Project
                    {
                        Title = "The Way of Kings",
                        AuthorFirst = "Brandon",
                        AuthorMiddle = "",
                        AuthorLast = "Sanderson",
                        Publisher = "Tor Books",
                        ISBN = "978-0765326355",
                        Classification = "Fiction",
                        Category = "Epic Fantasy",
                        NumPages = 1007,
                        Price = 9.59
                    },

                    new Project
                    {
                        Title = "The Alloy of Law",
                        AuthorFirst = "Brandon",
                        AuthorMiddle = "",
                        AuthorLast = "Sanderson",
                        Publisher = "Tor Books",
                        ISBN = "978-0765330420",
                        Classification = "Fiction",
                        Category = "Fantasy",
                        NumPages = 336,
                        Price = 16.11
                    },

                    new Project
                    {
                        Title = "Words of Radiance",
                        AuthorFirst = "Brandon",
                        AuthorMiddle = "",
                        AuthorLast = "Sanderson",
                        Publisher = "Tor Books",
                        ISBN = "978-0765326362",
                        Classification = "Fiction",
                        Category = "Epic Fantasy",
                        NumPages = 1087,
                        Price = 15.99
                    }


                );

                context.SaveChanges();
            }
        }
    }
}
