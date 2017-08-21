using Domain.Models.FamilyTree;
using Domain.Models.User;

namespace Application.Services
{
    public interface IUserService
    {
        TreeUser CreateUser(string name);
        void DeleteUser(TreeUser user);
        FamilyTree CreateTree(TreeUser user);
        void DeleteTree(FamilyTree tree);
    }
}