using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Models
{
    public class Person
    {
        public int Id { get; set; }
        public Sex Sex { get; set; }
        public int? FatherId { get; set; }
        public int? MotherId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MaidenName { get; set; }
        public Address Address { get; set; }
    }
}
