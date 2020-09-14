using LibraryHomeworkMVC.Controllers;
using LibraryHomeworkMVC.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryHomeworkMVC
{
    public class StaticDb
    {
        public static List<User> Users { get; set; }
        public static List<Book> Books { get; set; }

        static StaticDb()
        {
            Users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Ana",
                    LastName = "Stojanoska",
                    BooksBorrowed = new List<Book>{
                        new Book()
                        {
                            Id = 1,
                            Name = "Kodot na Da Vinci",
                            Autor = "Den Braun",
                            Category = BookCategory.Mystery
                        }
                    }
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Mia",
                    LastName = "Stojanova",
                    BooksBorrowed = new List<Book>{
                         new Book()
                         {
                            Id = 3,
                            Name = "Bez zboguvanje",
                            Autor = "Linvud Barkli",
                            Category = BookCategory.Mystery
                         },
                         new Book()
                         {
                            Id = 1,
                            Name = "Kodot na Da Vinci",
                            Autor = "Den Braun",
                            Category = BookCategory.Mystery
                         }
                    }
                },
                new User()
                {
                    Id = 3,
                    FirstName = "Bob",
                    LastName = "Bobsky",
                    BooksBorrowed = new List<Book>{
                        new Book()
                        {
                           Id = 2,
                           Name = "Zoki Poki",
                           Autor = "Olivera Nikolovska",
                           Category = BookCategory.Kids
                        },
                        new Book()
                        {
                            Id = 1,
                            Name = "Kodot na Da Vinci",
                            Autor = "Den Braun",
                            Category = BookCategory.Mystery
                        }
                    }
                }
            };

            Books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Name = "Kodot na Da Vinci",
                    Autor = "Den Braun",
                    Category = BookCategory.Mystery
                },
                new Book()
                {
                    Id = 2,
                    Name = "Zoki Poki",
                    Autor = "Olivera Nikolovska",
                    Category = BookCategory.Kids
                },
                new Book()
                {
                    Id = 3,
                    Name = "Bez zboguvanje",
                    Autor = "Linvud Barkli",
                    Category = BookCategory.Mystery
                }
            };
        }
    }
}
