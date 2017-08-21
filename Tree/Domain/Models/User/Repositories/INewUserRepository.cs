using System.Threading.Tasks;
using Common;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace Domain.Models.User.Repositories
{

    public interface INewUserRepository : IRepository<TreeUser>
    {
        Task<IdentityResult> Register(UserManager<TreeUser, int> userManager, TreeUser user, string password);
        
        Task<SignInStatus> Login(SignInManager<TreeUser, int> signinManager, string email, string password,
            bool rememberMe);
        
        void Logoff(IAuthenticationManager authenticationManager);
        
        TreeUser GetUserById(int id);
    }
}