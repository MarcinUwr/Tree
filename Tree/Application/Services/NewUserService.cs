using System;
using System.Threading.Tasks;
using Domain.Models.User;
using Domain.Models.User.Repositories;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace Application.Services
{
    public class NewUserService : INewUserService
    {
        private INewUserRepository _userRepository;
        
        public NewUserService(INewUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public TreeUser GetUserById(string ID)
        {
            throw new NotImplementedException();
        }

        public Task<SignInStatus> Login(SignInManager<TreeUser, int> signinManager, string email, string password, bool rememberMe) =>
            _userRepository.Login(signinManager, email, password, rememberMe);
        
        public void Logoff(IAuthenticationManager authenticationManager)
        {
            _userRepository.Logoff(authenticationManager);
        }

        public Task<IdentityResult> Register(UserManager<TreeUser, int> userManager, TreeUser user, string password) =>
            _userRepository.Register(userManager, user, password);
    }
}