using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_EF.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Name", TypeName = "NCARCHAR")]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        [Column("Email", TypeName = "VARCHAR")]
        public string Email { get; set; }

        [Required]
        [MaxLength(255)]
        [Column("PassWordHash", TypeName = "VARCHAR")]
        public string PassWordHash { get; set; }

        [Required]
        [Column("Bio", TypeName = "TEXT")]
        public string Bio { get; set; }

        [Required]
        [MaxLength(2000)]
        [Column("Image", TypeName = "VARCHAR")]
        public string Image { get; set; }

        [Required]
        [MaxLength(80)]
        [Column("Slug", TypeName = "VARCHAR")]
        public string Slug { get; set; }
    }
}