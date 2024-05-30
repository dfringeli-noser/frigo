using AutoMapper;
using frigo.domain;
using frigo.dtos;

namespace frigo.app.ViewModels
{
    public class ViewModelMappingProfile : Profile
    {
        public ViewModelMappingProfile()
        {
            CreateMap<Food, FoodViewModel>()
                .ForMember(dst => dst.ExpireIn, opt => opt.MapFrom(src => src.ExpiresAt - DateTimeOffset.Now));
            CreateMap<FoodCreateViewModel, FoodCreateDto>();
        }
    }
}
