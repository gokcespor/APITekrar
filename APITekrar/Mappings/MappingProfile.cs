using APITekrar.DTOs;
using APITekrar.Entities;
using AutoMapper;

namespace APITekrar.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Chef, ChefDTO>().ReverseMap();
            CreateMap<Chef, ChefListDTO>().ReverseMap();
            CreateMap<Food, FoodDTO>().ReverseMap();
            CreateMap<Food, FoodListDTO>().ReverseMap();
        }
    }
}
