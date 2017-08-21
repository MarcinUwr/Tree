using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tree.ViewModels;

namespace Tree.Builders
{
    public class ViewModelBuilder
    {
        public AddMemberViewModel BuildAddMemberViewModel(Domain.Models.FamilyTree.FamilyTree tree)
        {
            return new AddMemberViewModel {Tree = tree};
        }
    }
}