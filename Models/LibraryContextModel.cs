using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Models
{
    public class LibraryContextModel: DbContext
    {
        public DbSet<MemberViewModel> Members { get; set; }
        public DbSet<BookTypeViewModel> BookTypes { get; set; }
        public DbSet<LiveBookViewModel> LiveBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=BookishDB;User Id=sa;Password=Password123;");
        }
    }
}
