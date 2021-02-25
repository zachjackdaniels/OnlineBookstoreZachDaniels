using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstoreZachDaniels.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookstoreDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookstoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        ClassificationCategory = "Fiction, Classic",
                        Price = 9.95f,
                        Pages = 1488
                    },
                    new Book
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        ClassificationCategory = "Non-Fiction, Biography",
                        Price = 14.58f,
                        Pages = 944
                    },
                    new Book
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        ClassificationCategory = "Non-Fiction, Biography",
                        Price = 21.54f,
                        Pages = 832
                    },
                    new Book
                    {
                        Title = "American Ulysses",
                        Author = "Ronald C. White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        ClassificationCategory = "Non-Fiction, Biography",
                        Price = 11.61f,
                        Pages = 864
                    },
                    new Book
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        ClassificationCategory = "Non-Fiction, Historical",
                        Price = 13.33f,
                        Pages = 528
                    },
                    new Book
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        ClassificationCategory = "Fiction, Historical Fiction",
                        Price = 15.95f,
                        Pages = 288
                    },
                    new Book
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        ClassificationCategory = "Non-Fiction, Self-Help",
                        Price = 14.99f,
                        Pages = 304
                    },
                    new Book
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        ClassificationCategory = "Non-Fiction, Self-Help",
                        Price = 21.66f,
                        Pages = 240
                    },
                    new Book
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        ClassificationCategory = "Non-Fiction, Business",
                        Price = 29.16f,
                        Pages = 400
                    },
                    new Book
                    {
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        ClassificationCategory = "Fiction, Thrillers",
                        Price = 15.03f,
                        Pages = 642
                    },
                    new Book
                    {
                        Title = "As a Man Thinketh",
                        Author = "James Allen",
                        Publisher = "CreateSpace Independent Publishing Platform",
                        ISBN = "978-1503055360",
                        ClassificationCategory = "Motivational, Self Help",
                        Price = 5.99f,
                        Pages = 38
                    },
                    new Book
                    {
                        Title = "Mistborn: The Final Empire",
                        Author = "Brandon Sanderson",
                        Publisher = "Tor Teen",
                        ISBN = "978-0765377135",
                        ClassificationCategory = "Fantasy, Young-Adult",
                        Price = 12.56f,
                        Pages = 672
                    },
                    new Book
                    {
                        Title = "Don Quixote",
                        Author = "Miguel De Cervantes",
                        Publisher = "Ecco",
                        ISBN = "978-0060934347",
                        ClassificationCategory = "Classic, Fiction",
                        Price = 12.56f,
                        Pages = 992
                    }

                    );
                context.SaveChanges();
            };
        }
    }
}
