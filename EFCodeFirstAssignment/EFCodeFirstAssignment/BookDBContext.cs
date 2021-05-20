using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstAssignment
{
    class BookDBContext : DbContext
    {
        public DbSet<Book> Books { set; get; }
        public DbSet<Member> Members { set; get; }
        public DbSet<Review> Reviews { set; get; }
        public DbSet<Publisher> Publishers { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database = BookDB;Integrated Security=True;");
        }
    }
}
