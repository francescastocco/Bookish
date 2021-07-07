using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.Models
{
    public class LiveBookViewModel
    {
        public int Id { get; set; }
        public int BookTypeId { get; set; }
        public int MemberId { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime DueDate { get; set; }

        public LiveBookViewModel(int id, int bookTypeId, int memberId, DateTime checkOutDate, DateTime dueDate)
        {
            Id = id;
            BookTypeId = bookTypeId;
            MemberId = memberId;
            CheckOutDate = checkOutDate;
            DueDate = dueDate;
        }
    }
}