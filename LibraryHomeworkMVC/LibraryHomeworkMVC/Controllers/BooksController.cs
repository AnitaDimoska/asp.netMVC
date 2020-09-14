using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryHomeworkMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LibraryHomeworkMVC.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            var dbBooks = StaticDb.Books;
            var books = new List<BooksViewModel>();

            foreach (var item in dbBooks)
            {
                books.Add(new BooksViewModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Autor = item.Autor,
                    Category = item.Category
                });
            }
            var viewModel = new BooksViewModel()
            {
                Books = books
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var dbBook = StaticDb.Books.FirstOrDefault(x => x.Id == id);
            var bookViewModel = new BooksViewModel()
            {
                Id = dbBook.Id,
                Autor = dbBook.Autor,
                Category = dbBook.Category,
                Name = dbBook.Name,
            };    

            return View(bookViewModel);
        }

        public IActionResult Borrow(int id)
        {
            var dbBook = StaticDb.Books.FirstOrDefault(x => x.Id == id);
            var bookViewModel = new BooksViewModel()
            {
                Id = dbBook.Id,
                Autor = dbBook.Autor,
                Category = dbBook.Category,
                Name = dbBook.Name,
            };

            return View(bookViewModel);
        }
    }
}
