using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryHomeworkMVC.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace LibraryHomeworkMVC.Models.ViewModels
{
    public class UsersViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Book> BooksBorrowed { get; set; }
        public List<UsersViewModel> Users { get; set; }
    }
}
