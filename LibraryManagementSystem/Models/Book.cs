using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
           [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Book_Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}