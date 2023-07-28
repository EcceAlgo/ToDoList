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
    public class TaskRepository : GenericRepository<Entity.Task>,ITaskRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskRepository"/>class.
        /// </summary>
        /// <param name="dbContext"></param>
        public TaskRepository(ITodolistDbContext dbContext) : base(dbContext)
        {
        }
    }
}
