using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todolist.Data.Context.Contract;

namespace Todolist.Data.Repository
{
    public class TaskRepository : GenericRepository<Task>
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ITodolistDbContext _dBContext;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        public TaskRepository(ITodolistDbContext dbContext)
        {
            _dBContext = dbContext;

        }


        //public async Task<Task> CreateTaskAsync(Task taskToAdd)
        //{
        //    var elementAdded = await _dBContext.Tasks.AddAsync(taskToAdd).ConfigureAwait(false);
        //    await _dBContext.SaveChangesAsync().ConfigureAwait(false);
        //    return elementAdded.Entity;
        //}
    }
}
