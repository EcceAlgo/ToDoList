using Microsoft.EntityFrameworkCore;
using ToDoList.Data.Context.Contract;
using ToDoList.Data.Entity;
using ToDoList.Data.Repository.Contract;

namespace ToDoList.Data.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(IToDoListDbContext dbContext) : base(dbContext)
        {
        }

        /// <summary>
        /// Gets a User by First Name
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public async Task<List<User>> GetUserByName(string firstName)
        {
            return await _table.Where(x => x.FirstName == firstName).ToListAsync().ConfigureAwait(false);
        }

    }
}