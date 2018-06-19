using Application.Messages.Responses;

namespace Application.Services.Interfaces
{
    public interface IProductApplicationService
    {
        ProductsResponseMessage Get();
    }
}
