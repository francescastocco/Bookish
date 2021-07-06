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
            var ids = new List<int> { 1,2,3,4};
            var names = new List<string> { "ken", "francesca", "oskar", "luke" };
            var members = new List<MemberViewModel>();
            for(var i=0; i<names.Count; i++)
            {
                members.Add(new MemberViewModel(ids[i], names[i]));
            }
            return View(members);
        }
    }
}
