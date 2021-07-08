using Bookish.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookish.DbModels;
using Microsoft.EntityFrameworkCore;
using Bookish.Services;

namespace Bookish.Controllers
{
    public class MemberController : Controller
    {
        private readonly IMemberService _service;

        public MemberController(LibraryContext context)
        {
            _service = new MemberService(context);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_service.GetAllMembers());
        }

        [HttpPost]
        public IActionResult Index(MemberListViewModel memberListViewModel)
        {
            _service.AddMember(memberListViewModel.NewMemberName);
            return RedirectToAction("Index");
        }
    }
}
