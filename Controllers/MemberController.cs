using Bookish.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            var ids = new List<int>{1,2,3,4};
            var names = new List<string>{ "ken", "francesca", "oskar", "luke" };
            var membersList = new MembersListViewModel();
            membersList.Name = names;
            membersList.Id = ids;
            return View(membersList);
        }
    }
}
