using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreLibraryHomework.Models
{
    public class BookAuthor
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int AuthorId { get; set; }
    }
}
