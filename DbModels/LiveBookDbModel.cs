using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.DbModels
{
    public class LiveBookDbModel
    {
        public int Id { get; set; }
        [Required]
        public BookTypeDbModel BookType { get; set; }
        public MemberDbModel Member { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public DateTime? DueDate { get; set; }

    }
}