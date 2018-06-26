using AutoMapper;
using Domain.Models.Dtos;
using Domain.Services.Implementation.EntityServices;
using Domain.Services.Interfaces.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services.Interfaces.EntityServices
{
    public class ProductEntityService : IProductEntityService
    {
        private readonly IMapper mapper;
        private readonly IProductRepository productRepository;

        public ProductEntityService(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public IList<ProductDto> GetAllProducts()
        {
            var products = productRepository.Get();
            return mapper.Map<IList<ProductDto>>(products);
        }

        public async Task<ProductDto> GetByIdAsync(long id)
        {
            var product = await productRepository.GetByIdAsync(id);
            return mapper.Map<ProductDto>(product);
        }
    }
}
