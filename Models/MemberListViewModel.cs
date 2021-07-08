using System.Collections.Generic;

namespace Bookish.Models
{
    public class MemberListViewModel
    {
        public List<MemberViewModel> Members { get; set; }

        public string NewMemberName { get; set; }
    }
}