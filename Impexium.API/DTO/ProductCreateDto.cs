using System.ComponentModel.DataAnnotations;

namespace Impexium.API.DTO
{
    public class ProductCreateDto
    {
        [Required]
        [MaxLength(100, ErrorMessage = "The max lenght to the name are 100 characters")]
        public string Name { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "The max lenght to the name are 500 characters")]
        public string Description { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }


    }
}
