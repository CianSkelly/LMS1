using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public class User
    {
            public int user_Id { get; set; }
            public string UserName { get; set; }
            public string email_address { get; set; }
            public string phone_number { get; set; }
            //public DateTime EnrollmentDate { get; set; }

            public virtual ICollection<Book_on_Loan> Books_on_Loan { get; set; }
        }
    }
}