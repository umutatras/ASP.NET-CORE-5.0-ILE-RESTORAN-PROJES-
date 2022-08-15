using System.ComponentModel.DataAnnotations;

namespace RestaturanProje.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
