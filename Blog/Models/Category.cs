using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{       
    [Table("[Category]")]
    public class Category
    {
        public Category()
            => new List<Post>();
        
         public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public List<Post> Posts { get; set; }
    }
}