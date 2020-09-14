using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryHomeworkMVC.Models.DomainModels;
using LibraryHomeworkMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LibraryHomeworkMVC.Controllers
{
    public class BorrowController : Controller
    {
        [HttpGet]
        public IActionResult Book()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Book(BorrowViewModel borrowViewModel, int id)
        {
            var bookForBorrow = StaticDb.Books.FirstOrDefault(x => x.Id == id);
            var lastUserId = StaticDb.Users.Last().Id;

            var user = new User()
            {
                Id = lastUserId++,
                FirstName = borrowViewModel.FirstName,
                LastName = borrowViewModel.LastName,
                BooksBorrowed = new List<Book>() { bookForBorrow }
            };

            StaticDb.Users.Add(user);

            return View("_ThankYou");
        }
      
    }
}
