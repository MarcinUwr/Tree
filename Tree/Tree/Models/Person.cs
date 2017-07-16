using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tree.Models
{
    public class Person
    {
        [Key]
        public string PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthDay { get; set; }
        public int BirthMonth { get; set; }
        public int BirthYear { get; set; }
    }
}