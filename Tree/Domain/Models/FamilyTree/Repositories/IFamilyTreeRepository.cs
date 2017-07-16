using Common;

namespace Domain.Models.FamilyTree.Repositories
{
    public interface IFamilyTreeRepository : IRepository<NewFamilyTree>
    {
        /*void AddChild(int userId, Person person, int? motherId, int? fatherId);
        void AddParent(int userId, Person person, int childId);
        List<Person> GetChildren(int userId, int personId);*/
        NewFamilyTree GetById(int userId);
    }
}