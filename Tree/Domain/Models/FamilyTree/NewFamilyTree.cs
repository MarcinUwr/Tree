using System.Collections.Generic;
using System.Linq;

namespace Domain.Models.FamilyTree
{
    public class NewFamilyTree
    {
        public int UserId { get; set; }
        public Person Root { get; set; }
        public virtual List<Person> Members { get; set; }
        
        public List<Person> GetChildren(Person person)
        {
            return Members.Where(m => m.FatherId == person.Id || m.MotherId == person.Id).ToList();
        }

        public void AddMember(Person person)
        {
            Members.Add(person);
        }

        public void RemoveMember(int personId)
        {
            Members.RemoveAll(p => p.Id == personId);
        }
    }
}