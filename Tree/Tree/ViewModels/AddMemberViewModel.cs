using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.Enums;
using Domain.Models.FamilyTree;

namespace Tree.ViewModels
{
    public class AddMemberViewModel
    {
        public FamilyTree Tree { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName => Name + " " + Surname;
        public Sex Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DeathDate { get; set; }
        public int? ParentId { get; set; }
    }
}