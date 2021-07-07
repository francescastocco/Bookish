using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bookish.DbModels
{
    public class LibraryContext: DbContext
    {
        public DbSet<MemberDbModel> Members { get; set; }
        public DbSet<BookTypeDbModel> BookTypes { get; set; }
        public DbSet<LiveBookDbModel> LiveBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=BookishDB;User Id=sa;Password=Password123;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<SomeObject>().Property(m => m.somefield).IsOptional();
            //base.OnModelCreating(modelBuilder);
        }
    }
}
