using BookManagement.API.Entities;

namespace BookManagement.API.Models
{
    public class RegisterBookInputModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int PublicationYear { get; set; }

        public Book ToEntity()
            => new(Id, Title, Author, ISBN, PublicationYear);
    }
}
