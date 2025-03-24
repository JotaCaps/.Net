using BookManagement.API.Entities;

namespace BookManagement.API.Models
{
    public class RegisterUserInputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public User ToEntity()
            => new(Id, Name, Email);
    }
}
