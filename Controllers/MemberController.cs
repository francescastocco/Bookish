using Bookish.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookish.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            var context = new LibraryContext();
            var DbMembers = context.Members
                                              .Where(s => s.Name == "Hagrid")
                                              .Include(s => s.LiveBooks)
                                              .ToList();
            
            //var memberLiveBooks = DbMembers[0].LiveBooks;
            //foreach (var book in memberLiveBooks)
            //{
            //    Console.WriteLine(book.Id);
            //}

            var viewMembers = new List<MemberViewModel>();
            foreach (var DbMember in DbMembers)
            {
                var viewMember = new MemberViewModel(DbMember.Id, DbMember.Name);
                viewMembers.Add(viewMember);
            }
            
            return View(viewMembers);
        }
    }
}
