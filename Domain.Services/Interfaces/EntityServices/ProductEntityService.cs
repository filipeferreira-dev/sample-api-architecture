using AutoMapper;
using Domain.Models.Dtos;
using Domain.Services.Implementation.EntityServices;
using Domain.Services.Interfaces.Repository;
using System.Collections.Generic;

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
    }
}
