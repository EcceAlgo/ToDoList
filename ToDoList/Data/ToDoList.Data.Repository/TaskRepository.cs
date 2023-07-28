using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data.Context.Contract;

namespace ToDoList.Data.Repository
{
    public class TaskRepository
    {
        /// <summary>
        /// d b context
        /// </summary>
        private readonly IToDoListDbContext _dbContext;

        /// <summary>
        /// Initialise une nouvelle instance de TaskRepository
        /// </summary>
        /// <param name="dbContext"></param>
        public TaskRepository(IToDoListDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
