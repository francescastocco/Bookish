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
            var membersList = new MembersListViewModel();
            //membersList.Name = "Ken";
            return View(membersList);
        }
    }
}
