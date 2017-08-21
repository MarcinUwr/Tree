using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Domain.Models.User;
using Domain.Models.User.Repositories;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace Infrastructure.Repositories
{
    public class NewUserRepository : RepositoryBase<TreeUser>, INewUserRepository
    {
        public TreeUser GetUserById(int id) => DbSet.Find(id);
        
        public async Task<SignInStatus> Login(SignInManager<TreeUser, int> signinManager, string email, string password, bool rememberMe) =>
            await signinManager.PasswordSignInAsync(email, password, rememberMe, shouldLockout: false);
        
        public void Logoff(IAuthenticationManager authenticationManager)
        {
            authenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }
        
        public async Task<IdentityResult> Register(UserManager<TreeUser, int> userManager, TreeUser user, string password) =>
            await userManager.CreateAsync(user, password);
        
        public NewUserRepository(DbContext dataContext) : base(dataContext)
        {
        }
    }
}