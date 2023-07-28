using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data.Context.Contract;
using ToDoList.Data.Entity;
using ToDoList.Data.Repository.Contract;
using Task = ToDoList.Data.Entity.Task;

namespace ToDoList.Data.Repository
{
    public class TaskRepository : GenericRepository<Task>, ITaskRepository
    {
        /// <summary>
        /// Initilise une nouvelle instance de TaskRepository
        /// </summary>
        /// <param name="dbContext"></param>
        public TaskRepository(IToDoListDbContext dbContext) : base(dbContext)
        {
        }
    }
}
