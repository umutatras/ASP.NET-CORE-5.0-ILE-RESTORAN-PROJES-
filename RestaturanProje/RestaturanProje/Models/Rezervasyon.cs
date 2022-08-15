using System;
using System.ComponentModel.DataAnnotations;

namespace RestaturanProje.Models
{
    public class Rezervasyon
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string EMail { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public int Sayi { get; set; }
        public string Saat { get; set; }
        public DateTime Tarih { get; set; }
    }
}
