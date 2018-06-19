using AutoMapper;
using Domain.Models.Dtos;
using Domain.Models.Entities;

namespace Application.Mappers
{
    public class EntityToDtoMappingProfile : Profile
    {
        public EntityToDtoMappingProfile()
        {
            CreateMap<ProductDto, Product>();
        }
    }
}
