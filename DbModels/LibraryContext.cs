using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bookish.DbModels
{
    public class LibraryContext: DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {

        }
        public DbSet<MemberDbModel> Members { get; set; }
        public DbSet<BookTypeDbModel> BookTypes { get; set; }
        public DbSet<LiveBookDbModel> LiveBooks { get; set; }
    }
}
