using Application.Messages;
using Application.Messages.Responses;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Services.Implementation.EntityServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.Implementations
{
    public class ProductApplicationService : IProductApplicationService
    {
        private readonly IMapper mapper;
        private readonly IProductEntityService productEntityService;

        public ProductApplicationService(IProductEntityService productEntityService, IMapper mapper)
        {
            this.productEntityService = productEntityService;
            this.mapper = mapper;
        }

        public ProductListResponseMessage Get()
        {
            var productsDto = productEntityService.GetAllProducts();
            var productsMessage = mapper.Map<IEnumerable<ProductMessage>>(productsDto);

            return new ProductListResponseMessage { Products = productsMessage };
        }

        public async Task<ProductResponseMessage> GetByIdAsync(long id)
        {
            var productDto = await productEntityService.GetByIdAsync(id);
            var productMessage = mapper.Map<ProductMessage>(productDto);

            return new ProductResponseMessage { Product = productMessage };
        }
    }
}
