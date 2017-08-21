using System.Data.Entity;
using Common;
using Domain.Models.FamilyTree;
using Domain.Models.Person;
using Domain.Models.User;

namespace Infrastructure
{
    //public partial class TreeDbContext : DbContext
    //{
    //    public DbSet<User> Users { get; set; }
    //    public DbSet<FamilyTree> FamilyTrees { get; set; }
    //    public DbSet<Person> Persons { get; set; }

    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        base.OnModelCreating(modelBuilder);

    //        modelBuilder.Entity<ApplicationUser>().ToTable("Users").HasKey<int>(u => u.Id);
    //        modelBuilder.Entity<CustomUserRole>().ToTable("UserRoles").HasKey(ur => new { ur.RoleId, ur.UserId });
    //        modelBuilder.Entity<CustomUserLogin>().ToTable("UserLogins").HasKey<int>(ul => ul.UserId);
    //        modelBuilder.Entity<CustomUserClaim>().ToTable("UserClaims").HasKey<int>(uc => uc.Id);
    //        modelBuilder.Entity<CustomRole>().ToTable("Roles").HasKey<int>(r => r.Id);
    //    }

    //    public static TreeDbContext Create()
    //    {
    //        return new TreeDbContext();
    //    }
    //}
}