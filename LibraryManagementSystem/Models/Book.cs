using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }

        public virtual ICollection<BookOnLoan> BooksOnLoan { get; set; }
    }
}