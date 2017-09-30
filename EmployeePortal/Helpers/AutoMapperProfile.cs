using AutoMapper;
using EmployeePortal.Dtos;
using EmployeePortal.Models;

namespace EmployeePortal.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
