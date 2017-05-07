using System.Collections.Generic;
using Domain.Models;

namespace Domain.Aggregates
{
    public class FamilyTree
    {
        public int UserId { get; set; }
        public List<Person> FamilyMembers { get; set; }
        
        public void AddChild(Person person, int? fatherId, int? motherId)
        {
            //FamilyMembers.Add(person.Sex.);
        }

        public void AddParent(Person person, int childId)
        {
            
        }
    }
}