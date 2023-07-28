using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todolist.Business.Model.Users;

namespace Todolist.Business.Service.Contract
{
    public interface IUserService
    {
        Task<List<ReadUserDto>> GetUsers()
    }
}
