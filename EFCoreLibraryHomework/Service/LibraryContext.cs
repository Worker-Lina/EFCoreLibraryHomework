using EFCoreLibraryHomework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreLibraryHomework.Service
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; } 

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Ticket> Ticket { get; set; }

        public DbSet<BookAuthor> BookAuthor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-6543DI3; Database=Library; Trusted_Connection=True;");
        }
    }
}
