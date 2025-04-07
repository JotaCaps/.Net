namespace BookManagement.API.Entities
{
    public class User
    {
        public User(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            Lendings = [];
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }

        public List<Loan> Lendings { get; private set; }
    }
}
