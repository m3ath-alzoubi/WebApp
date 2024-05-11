using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [DisplayName("Project Name")]
        public string? Name { get; set; }

        [DisplayName("DisplayOrder ")]
        [Range(0, 200)]
        public int DisplayOrder { get; set; }
    }
}
