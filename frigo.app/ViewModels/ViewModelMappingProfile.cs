using AutoMapper;
using frigo.domain;

namespace frigo.app.ViewModels
{
    public class ViewModelMappingProfile : Profile
    {
        public ViewModelMappingProfile()
        {
            CreateMap<Food, FoodViewModel>()
                .ForMember(dst => dst.ExpireIn, opt => opt.MapFrom(src => src.ExpiresAt - DateTimeOffset.Now));
        }
    }
}
