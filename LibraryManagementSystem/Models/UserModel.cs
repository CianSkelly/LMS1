using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public class UserModel
    {
            public int user_Id { get; set; }
            public string UserName { get; set; }
            public string email_address { get; set; }
            public string phone_number { get; set; }
            //public DateTime EnrollmentDate { get; set; }

            //public virtual ICollection<Book_out_on_loan> Books_out_on_loan { get; set; }
            //public virtual ICollection<Categories> Category { get; set; }
    }
}
