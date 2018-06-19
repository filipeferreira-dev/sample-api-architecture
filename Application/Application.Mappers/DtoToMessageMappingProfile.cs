using Application.Messages;
using AutoMapper;
using Domain.Models.Dtos;

namespace Application.Mappers
{
    public class DtoToMessageMappingProfile : Profile
    {
        public DtoToMessageMappingProfile()
        {
            CreateMap<ProductDto, ProductMessage>();
        }
    }
}
