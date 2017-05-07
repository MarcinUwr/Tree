using Domain.Models;

namespace Domain.Aggregates
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public FamilyTree FamilyTree { get; set; }
    }
}