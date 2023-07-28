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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<ReadUserDto>> GetUsersAsync();
    }
}
