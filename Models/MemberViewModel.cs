using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookish.DbModels;

namespace Bookish.Models
{
    public class MemberViewModel
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public List<LiveBookViewModel> LiveBooks { get; set; }
        public MemberViewModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public MemberViewModel(MemberDbModel memberDbModel)
        {
            Id = memberDbModel.Id;
            Name = memberDbModel.Name;
            LiveBooks = new List<LiveBookViewModel>();
            foreach (var liveBook in memberDbModel.LiveBooks)
            {
                LiveBooks.Add(new LiveBookViewModel(liveBook));
            }
        }
    }
}
