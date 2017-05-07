using Domain.Models;

namespace Application.Interfaces
{
    public interface IAddMembers
    {
        void AddChild(int userId, Person person, int? fatherId, int? motherId);
        void AddParent(int userId, Person person, int childId);
    }
}