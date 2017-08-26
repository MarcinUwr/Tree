using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Common;
using Domain.Models.FamilyTree;
using Domain.Models.Person;
using Domain.Models.User;
using Infrastructure;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Tree.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : TreeUser
    {
        public string TestProp { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser, int> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
    public class TreeDbContext : DbContext
    {
        public DbSet<ApplicationUser> TreeUsers { get; set; }
        public DbSet<FamilyTree> FamilyTrees { get; set; }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FamilyTree>().HasMany(t => t.Members)
                .WithRequired(m => m.FamilyTree);
            modelBuilder.Entity<Person>().Property(p=>p.BirthDate).HasColumnType("datetime2");
            modelBuilder.Entity<Person>().Property(p=>p.DeathDate).HasColumnType("datetime2");
            modelBuilder.Entity<Person>().Ignore(p=>p.FullName);

            modelBuilder.Entity<ApplicationUser>().ToTable("TreeUsers").HasKey<int>(u => u.Id);
            modelBuilder.Entity<CustomUserRole>().ToTable("UserRoles").HasKey(ur => new { ur.RoleId, ur.UserId });
            modelBuilder.Entity<CustomUserLogin>().ToTable("UserLogins").HasKey<int>(ul => ul.UserId);
            modelBuilder.Entity<CustomUserClaim>().ToTable("UserClaims").HasKey<int>(uc => uc.Id);
            modelBuilder.Entity<CustomRole>().ToTable("Roles").HasKey<int>(r => r.Id);
        }

        public static TreeDbContext Create()
        {
            return new TreeDbContext();
        }
    }

    public class CustomUserStore : UserStore<TreeUser, CustomRole, int,
        CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        public CustomUserStore(TreeDbContext context)
            : base(context)
        {
        }
    }

    public class CustomRoleStore : RoleStore<CustomRole, int, CustomUserRole>
    {
        public CustomRoleStore(TreeDbContext context)
            : base(context)
        {
        }
    }
}