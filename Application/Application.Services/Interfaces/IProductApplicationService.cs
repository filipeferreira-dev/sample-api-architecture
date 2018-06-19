using Application.Messages.Responses;

namespace Application.Services.Interfaces
{
    public interface IProductApplicationService
    {
        ProductListResponseMessage Get();

        ProductResponseMessage GetById(long id);
    }
}
