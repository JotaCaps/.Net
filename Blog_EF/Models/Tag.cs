using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_EF.Models
{
    [Table("Tag")]
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Tag", TypeName ="NVARCHAR")]
        public string Name { get; set; }
        
        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Slug", TypeName ="VARCHAR")]
        public string Slug { get; set; }
    }
}