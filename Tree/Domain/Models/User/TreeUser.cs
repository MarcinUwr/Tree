using Common;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Domain.Models.User
{
    public class TreeUser : IdentityUser<int, CustomUserLogin, CustomUserRole, CustomUserClaim>, IEntity
    {
        public TreeUser()
        {
            FamilyTree = new FamilyTree.FamilyTree();
        }

        //public int Id { get; set; }
        //public string UserName { get; set; }

        public virtual FamilyTree.FamilyTree FamilyTree { get; set; }
    }
}