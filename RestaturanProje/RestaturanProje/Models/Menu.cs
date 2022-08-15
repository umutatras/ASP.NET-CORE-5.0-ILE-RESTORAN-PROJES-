using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaturanProje.Models
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
        public double Price { get; set; }
        public int CategorId { get; set; }
        [ForeignKey("CategorId")]
        public Category Category { get; set; }
    }
}
