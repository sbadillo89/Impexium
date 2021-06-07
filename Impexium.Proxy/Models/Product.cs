using System;
using System.ComponentModel.DataAnnotations;

namespace Impexium.Proxy.Models
{
    public class Product
    {
        public Guid Id { get; set; }  

        [Required(ErrorMessage = " * Required")]
        [MaxLength(100, ErrorMessage = "The max lenght to the name are 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = " * Required")]
        [MaxLength(500, ErrorMessage = "The max lenght to the descripcion are 500 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "* Required")]
        [Range(1, 10000, ErrorMessage = "Quantity must be greater than 0")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "* Required")]
        [Range(1, 1000000, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
