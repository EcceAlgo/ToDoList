using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data.Context.Contract;
using ToDoList.Data.Entity;
using ToDoList.Data.Repository.Contract;

namespace ToDoList.Data.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        /// <summary>
        /// Initilise une nouvelle instance de UserRepository
        /// </summary>
        /// <param name="dbContext"></param>
        public UserRepository(IToDoListDbContext dbContext) : base(dbContext)
        {
        }

        /// <summary>
        /// Cette méthode permet de recupérer la list des users par firstName
        /// </summary>
        /// <param name="fistName"></param>
        /// <returns></returns>
        public async Task<List<User>> GetUserByNameAsync(string fistName)
        {
            return await _table.Where(x => x.FirstName == fistName).ToListAsync().ConfigureAwait(false);
        }
    }
}
