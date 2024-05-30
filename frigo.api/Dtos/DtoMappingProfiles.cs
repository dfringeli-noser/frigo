using AutoMapper;
using frigo.domain;

namespace frigo.api.Dtos
{
    public class DtoMappingProfiles : Profile
    {
        public DtoMappingProfiles()
        {
            CreateMap<FoodCreateDto, Food>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));
        }
    }
}
