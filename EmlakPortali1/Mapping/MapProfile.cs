using AutoMapper;
using EmlakPortali1.Models;
using EmlakPortali1.ViewModels;

namespace EmlakPortali1.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Ilan, Ilan>().ReverseMap();
            CreateMap<AppUser, UserModel>().ReverseMap();
            CreateMap<AppUser, RegisterModel>().ReverseMap();
            CreateMap<Todo, TodoModel>().ReverseMap();
        }
    }
}
