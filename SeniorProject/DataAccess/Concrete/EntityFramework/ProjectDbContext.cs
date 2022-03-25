using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class ProjectDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database= Test; Trusted_Connection=true");
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Parent> Parents { get; set; }

        public DbSet<Expert> Experts { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Child> Childs { get; set; }

    }
}
