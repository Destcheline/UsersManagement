using AutoMapper;
using System;
using UsersManagement.Application.Models;
using UsersManagement.Domain.Models;

namespace UsersManagement.Application
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserDto>()
                .ForMember(d => d.NameSurname, opt =>
                {
                    opt.MapFrom(src => $"{src.FirstName} {src.LastName}");
                });
            CreateMap<CreateUserInput, User>()
                .ForMember(d => d.Id, opt =>
                {
                    opt.MapFrom(src => Guid.NewGuid());
                });
            CreateMap<UpdateUserInput, User>();
        }
    }
}
