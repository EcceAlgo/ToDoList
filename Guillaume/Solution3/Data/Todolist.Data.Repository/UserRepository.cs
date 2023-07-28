using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todolist.Data.Context.Contract;
using Todolist.Data.Entity;
using Todolist.Data.Repository.Contract;

namespace Todolist.Data.Repository
{

    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/>class.
        /// </summary>
        /// <param name="dbContext"></param>
        public UserRepository(ITodolistDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<List<User>> GetUserByName(string firstName)
        {
            return await _table.Where(x => x.FirstName == firstName).ToListAsync().ConfigureAwait(false);
        }

    }
}
