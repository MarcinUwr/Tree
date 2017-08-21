using Common;

namespace Domain.Models.FamilyTree.Repositories
{
    public interface IFamilyTreeRepository : IRepository<FamilyTree>
    {
       void Add(int id, Person.Person person);
    }
}