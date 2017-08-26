using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.Models.Person;
using Tree.ViewModels;

namespace Tree.Builders
{
    public class PersonBuilder
    {
        public Person Build(AddMemberViewModel model)
        {//todo: merge mother and father ids into one (parentId)
            if (model == null) return null;
            return new Person
            {
                Name = model.Name,
                Surname = model.Surname,
                FatherId = model.ParentId,
                Sex = model.Sex,
                BirthDate = model.BirthDate,
                DeathDate = model.DeathDate
            };
        }
    }
}