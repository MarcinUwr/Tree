using System.Data.Entity;
using Domain.Models.User;
using Domain.Models.User.Repositories;

namespace Infrastructure.Repositories
{
    public class UserRepository : RepositoryBase<TreeUser>, IUserRepository
    {
        public UserRepository(DbContext dataContext) : base(dataContext)
        {
        }
    }
}