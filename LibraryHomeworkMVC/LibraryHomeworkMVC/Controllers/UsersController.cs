using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryHomeworkMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LibraryHomeworkMVC.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            var dbUsers = StaticDb.Users;
            var users = new List<UsersViewModel>();

            foreach (var item in dbUsers)
            {
                users.Add(new UsersViewModel()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    BooksBorrowed = item.BooksBorrowed
                });
            }

            var viewModel = new UsersViewModel()
            {
                Users = users
            };

            return View(viewModel);
        }
    }
}
