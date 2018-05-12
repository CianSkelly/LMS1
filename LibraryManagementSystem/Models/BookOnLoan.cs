using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public class BookOnLoan
    {
        public int BookOnLoan_Id { get; set; }
        public int user_Id { get; set; }
        public string ISBN { get; set; } 

        public virtual User User { get; set; }
        public virtual Book Book { get; set; }
    }
}