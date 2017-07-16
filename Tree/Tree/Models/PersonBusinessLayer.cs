using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tree.DataAccessLayer;

namespace Tree.Models
{
    public class PersonBusinessLayer
    {
        public List<Person> GetPersons()
        {
            TreeDataAccessLayer treeDal = new TreeDataAccessLayer();
            return treeDal.Persons.ToList();
        }
    }
}