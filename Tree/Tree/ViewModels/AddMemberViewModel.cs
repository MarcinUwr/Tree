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
        public Sex Sex { get; set; }
        public int? ParentId { get; set; }
    }
}