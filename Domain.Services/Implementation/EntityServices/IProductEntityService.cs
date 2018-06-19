using Domain.Models.Dtos;
using System.Collections.Generic;

namespace Domain.Services.Implementation.EntityServices
{
    public interface IProductEntityService
    {
        IList<ProductDto> GetAllProducts();
    }
}
