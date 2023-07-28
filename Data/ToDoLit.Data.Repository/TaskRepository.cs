using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data.Context.Contract;

namespace ToDoLit.Data.Repository
{
    internal class TaskRepository
    {
        private readonly IToDoListDbContext _DbContext;
        public TaskRepository(IToDoListDbContext dbContext)
        {
            _DbContext = dbContext;
        }
    }
}
