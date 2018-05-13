using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public class OnLoan
    {
        public int OnLoanId { get; set; }
        public String ISBN { get; set; }
        public DateTime date_issued { get; set; }
        public DateTime date_due_for_return { get; set; }
        public DateTime date_returned { get; set; }

        public virtual UserModel User_Id{ get; set; }
        public virtual Book Books_Id { get; set; }
    }
}