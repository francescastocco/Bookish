using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookish.DbModels;
using Bookish.Models;
using Microsoft.EntityFrameworkCore;


namespace Bookish.Services
{
    public interface IMemberService
    {
        MemberListViewModel GetAllMembers();
        void AddMember(string newMemberName);
        MemberDbModel GetMember(int id);
    }

    public class MemberService : IMemberService
    {
        private readonly LibraryContext Context;

        public MemberService(LibraryContext context)
        {
            Context = context;
        }

        public MemberListViewModel GetAllMembers()
        {
            var DbMembers = Context.Members.ToList();
            var memberListViewModel = new MemberListViewModel
            {
                Members = new List<MemberViewModel>()
            };

            foreach (var DbMember in DbMembers)
            {
                var viewMember = new MemberViewModel(DbMember.Id, DbMember.Name);
                memberListViewModel.Members.Add(viewMember);
            }

            return memberListViewModel;
        }

        public void AddMember(string newMemberName)
        {
                var newMember = new MemberDbModel()
                {
                    Name = newMemberName,
                };
                Context.Members.Add(newMember);
                Context.SaveChanges();
        }

        public MemberDbModel GetMember(int id)
        {
            var DbMember = Context.Members
                .Include(b => b.LiveBooks)
                .ThenInclude(b => b.BookType)
                .Single(b => b.Id == id);

            return DbMember;
        }
    }
}
