using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public class User
    {
            public int User_Id { get; set; }
            public string UserName { get; set; }
            public string email_address { get; set; }
            public string phone_number { get; set; }
            

            public virtual ICollection<BookOnLoan> BooksOnLoan { get; set; }
            //public virtual ICollection<Categories> Category { get; set; }
    }
}
