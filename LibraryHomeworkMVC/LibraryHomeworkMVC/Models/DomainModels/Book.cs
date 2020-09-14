using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryHomeworkMVC.Models.DomainModels
{
    public class Book
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Autor { get; set; }
        public BookCategory Category { get; set; }
    }
}
