using System.ComponentModel.DataAnnotations;

namespace RestaturanProje.Models
{
    public class Gallery
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
    }
}
