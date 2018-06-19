using System;

namespace Domain.Models.Dtos
{
    public class ProductDto
    {
        public DateTime ExpirationDate { get; set; }

        public string Name { get; set; }

        public long ProductId { get; set; }

        public Guid ProductUuid { get; set; }
    }
}
