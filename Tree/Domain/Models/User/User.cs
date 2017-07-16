namespace Domain.Models.User
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public FamilyTree.NewFamilyTree FamilyTree { get; set; }
    }
}