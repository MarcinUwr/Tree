using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Tree.Models;

namespace Tree.DataAccessLayer
{
    public class TreeDataAccessLayer : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("TablePerson");
            base.OnModelCreating(modelBuilder);
        }
    }
}