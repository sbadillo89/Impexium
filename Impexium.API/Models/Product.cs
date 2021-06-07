using System;
using System.Collections.Generic;

#nullable disable

namespace Impexium.API.Models
{
    public partial class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public DateTime? CreatedDate { get; set; }
        public decimal? Price { get; set; }
    }
}
