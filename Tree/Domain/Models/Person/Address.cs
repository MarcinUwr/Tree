using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.Person
{
    public class Address
    {
        [Key, ForeignKey("Person")]
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HomeNumber { get; set; }
        public string ApartamentNumber { get; set; }

        public virtual Person Person { get; set; }
    }
}