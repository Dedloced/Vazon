using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vazon.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }

        [Required]
        [StringLength(30)]
        public string? Category { get; set; }

        [Range(1, 1000000)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(2000)]
        public string? Description {  get; set; }
    }
}