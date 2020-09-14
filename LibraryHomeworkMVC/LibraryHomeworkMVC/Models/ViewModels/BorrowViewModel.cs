using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryHomeworkMVC.Models.ViewModels
{
    public class BorrowViewModel
    {
        public int BookId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
