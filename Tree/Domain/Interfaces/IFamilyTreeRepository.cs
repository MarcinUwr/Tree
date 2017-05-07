using System.Collections.Generic;
using Common;
using Domain.Aggregates;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IFamilyTreeRepository : IRepository<FamilyTree>
    {
        void AddChild(int userId, Person person, int? motherId, int? fatherId);
        void AddParent(int userId, Person person, int childId);
        List<Person> GetChildren(int userId, int personId);
        FamilyTree GetById(int userId);
    }
}