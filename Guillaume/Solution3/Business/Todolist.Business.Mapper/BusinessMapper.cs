using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todolist.Business.Model.Users;
using Todolist.Data.Entity;

namespace Todolist.Business.Mapper
{
    public class BusinessMapper : Profile
    {
        public BusinessMapper() 
        {
            CreateMap<User, CreateUserDto>()
                .ForMember(dest => dest.Prénom, src => src.MapFrom(x => x.FirstName))
                .ForMember(dest => dest.Nom, src => src.MapFrom(x => x.LastName))
                .ForMember(dest => dest.Courriel, src => src.MapFrom(x => x.Email))
                .ForMember(dest => dest.Mdp, src => src.MapFrom(x => x.Password))
                .ReverseMap();

            CreateMap<User, ReadUserDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(x => x.UserId))
                .ForMember(dest => dest.Tache, src => src.MapFrom(x => x.Tasks))
                .IncludeBase<User, CreateUserDto>()
                .ReverseMap();
        }
    }
}
