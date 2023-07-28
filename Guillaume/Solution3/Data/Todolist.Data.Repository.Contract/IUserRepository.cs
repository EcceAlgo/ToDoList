using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todolist.Data.Context.Contract;
using Todolist.Data.Entity;

namespace Todolist.Data.Repository.Contract
{
    public interface IUserRepository : IGenericRepository<User>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        Task<List<User>> GetUserByName(string firstName);
    }
}
