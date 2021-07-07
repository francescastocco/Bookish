using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.DbModels
{
    public class MemberDbModel
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public List<LiveBookDbModel> LiveBooks { get; set; }
    }
}
