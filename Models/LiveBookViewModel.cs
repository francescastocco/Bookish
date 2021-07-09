using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookish.DbModels;

namespace Bookish.Models
{
    public class LiveBookViewModel
    {
        public int Id { get; set; }
        public string BookTypeTitle { get; set; }
        public string BookTypeIsbn { get; set; }
        public string BookTypeAuthor { get; set; }
        public string MemberName { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public DateTime? DueDate { get; set; }

        public LiveBookViewModel(LiveBookDbModel liveBookDbModel)
        {
            Id = liveBookDbModel.Id;
            BookTypeTitle = liveBookDbModel.BookType.Title;
            BookTypeIsbn = liveBookDbModel.BookType.Isbn;
            BookTypeAuthor = liveBookDbModel.BookType.Author;
            MemberName = liveBookDbModel.Member.Name;
            CheckOutDate = liveBookDbModel.CheckOutDate;
            DueDate = liveBookDbModel.DueDate;
        }
    }
}