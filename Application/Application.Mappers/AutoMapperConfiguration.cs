using AutoMapper;

namespace Application.Mappers
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DtoToMessageMappingProfile>();
                cfg.AddProfile<EntityToDtoMappingProfile>();
            });
        }
    }
}
