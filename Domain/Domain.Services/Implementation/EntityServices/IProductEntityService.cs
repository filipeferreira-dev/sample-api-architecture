using Domain.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services.Implementation.EntityServices
{
    public interface IProductEntityService
    {
        IList<ProductDto> GetAllProducts();

        Task<ProductDto> GetByIdAsync(long id);
    }
}
