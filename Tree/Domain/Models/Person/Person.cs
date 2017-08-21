using Common;
using Domain.Enums;

namespace Domain.Models.Person
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        public Person Partner { get; set; }
        public Sex Sex { get; set; }
        public int? FatherId { get; set; }
        public int? MotherId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MaidenName { get; set; }

        public virtual Address Address { get; set; }
        public virtual FamilyTree.FamilyTree FamilyTree { get; set; }
    }
}
