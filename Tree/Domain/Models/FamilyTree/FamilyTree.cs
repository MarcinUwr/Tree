using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Common;

namespace Domain.Models.FamilyTree
{
    public class FamilyTree : IEntity
    {
        public FamilyTree()
        {
            Members = new List<Person.Person>();
        }

        [ForeignKey("TreeUser")]
        public int Id { get; set; }
        public Person.Person Root { get; set; }

        public virtual List<Person.Person> Members { get; set; }
        public virtual User.TreeUser TreeUser { get; set; }
        
        public List<Person.Person> GetChildren(Person.Person person)
        {
            return Members.Where(m => m.FatherId == person.Id || m.MotherId == person.Id).ToList();
        }

        //public void AddMember(Person.Person person)
        //{
        //    Members.Add(person);
        //}

        //public void RemoveMember(int personId)
        //{
        //    Members.RemoveAll(p => p.Id == personId);
        //}
    }
}