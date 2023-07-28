using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data.Context.Contract;

namespace ToDoList.Data.Repository
{
    public class UserRepository
    {
        /// <summary>
        /// d b context
        /// </summary>
        private readonly IToDoListDbContext _dbContext;

        /// <summary>
        /// Initialise une nouvelle instance de UserRepository
        /// </summary>
        /// <param name="dbContext"></param>
        public UserRepository(IToDoListDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
