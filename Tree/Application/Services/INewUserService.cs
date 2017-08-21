using System.Threading.Tasks;
using Domain.Models.User;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace Application.Services
{
    public interface INewUserService
    {
        Task<IdentityResult> Register(UserManager<TreeUser, int> userManager, TreeUser user, string password);
        
        Task<SignInStatus> Login(SignInManager<TreeUser, int> signinManager, string email, string password, bool rememberMe);
        
        void Logoff(IAuthenticationManager AuthenticationManager);
        
        TreeUser GetUserById(string ID);
    }
}