using Domain.Models.FamilyTree;
using Domain.Models.FamilyTree.Repositories;
using Domain.Models.User;
using Domain.Models.User.Repositories;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IFamilyTreeRepository _treeRepository;
        public UserService(IUserRepository userRepo, IFamilyTreeRepository treeRepo)
        {
            _userRepository = userRepo;
            _treeRepository = treeRepo;
        }
        public TreeUser CreateUser(string name)
        {
            var user = new TreeUser() {UserName = name};
            _userRepository.Insert(user);
            return user;
        }

        public void DeleteUser(TreeUser user)
        {
            _userRepository.Delete(user);
        }

        public FamilyTree CreateTree(TreeUser user)
        {
            FamilyTree tree = new FamilyTree();
            user.FamilyTree = tree;
            _treeRepository.Insert(tree);
            return tree;
        }

        public void DeleteTree(FamilyTree tree)
        {
            _treeRepository.Delete(tree);
        }
    }
}