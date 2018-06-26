using Domain.Models.Entities;
using System.Threading.Tasks;

namespace Domain.Services.Interfaces.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetByIdAsync(long id);
    }
}
