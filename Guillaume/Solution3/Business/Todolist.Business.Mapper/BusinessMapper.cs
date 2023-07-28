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
            CreateMap<User, ReadUserDto>()
        }
    }
}
