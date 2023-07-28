using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data.Context.Contract;
using ToDoList.Data.Entity;

namespace ToDoList.Data.Repository.Contract
{
    public interface IUserRepository : IGenericRepository<User>
    {

        /// <summary>
        /// Cette méthode permet de recupérer la list des users par firstName
        /// </summary>
        /// <param name="fistName"></param>
        /// <returns></returns>
        public Task<List<User>> GetUserByNameAsync(string fistName);
    }
}
