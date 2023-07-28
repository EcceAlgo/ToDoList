using ToDoList.Data.Context.Contract;
using ToDoList.Data.Entity;

namespace ToDoList.Data.Repository
{
    public class TaskRepository : GenericRepository<Entity.Task>
    {
        public TaskRepository(IToDoListDbContext dbContext) : base(dbContext)
        {
        }

    }
}
