using AutoMapper;
using WebApp_W1.DTOs;
using WebApp_W1.Models;

namespace WebApp_W1.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile() 
        { 
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
