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
    [Route("/[controller]")]
    public class MemberController : Controller
    {
        private readonly IMemberService _service;

        public MemberController(IMemberService service)
        {
            _service = service;
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

        [HttpGet("{id}")]
        public IActionResult Profile(int id)
        {
            return View(_service.GetMember(id));
        }

        [HttpPost]
        public IActionResult Profile(MemberViewModel memberViewModel)
        {
            return RedirectToAction("Profile", new {id = memberViewModel.Id});
        }
    }
}
