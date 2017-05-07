using System.Collections.Generic;
using Domain.Aggregates;
using Domain.Models;

namespace Application.Interfaces
{
    public interface IRetrieveMembers
    {
        FamilyTree GetFamilyTree(int userId);
        List<Person> GetChildren(int userId, int personId);
    }
}