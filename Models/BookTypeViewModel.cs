using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.Models
{
    public class BookTypeViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }

        public BookTypeViewModel(int id, string title, string author, string isbn)
        {
            Id = id;
            Title = title;
            Author = author;
            Isbn = isbn;
        }
    }
}