using System.Data.Entity;
using Domain.Models.Person;
using Domain.Models.Person.Repositories;

namespace Infrastructure.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(DbContext dataContext) : base(dataContext)
        {
        }
    }
}