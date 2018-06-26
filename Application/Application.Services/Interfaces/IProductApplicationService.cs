using Application.Messages.Responses;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IProductApplicationService
    {
        ProductListResponseMessage Get();

        Task<ProductResponseMessage> GetByIdAsync(long id);
    }
}
