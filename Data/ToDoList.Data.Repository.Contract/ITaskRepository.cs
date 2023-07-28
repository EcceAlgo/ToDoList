using ToDoList.Data.Entity;

namespace ToDoList.Data.Repository
{
    public interface ITaskRepository : IGenericRepository<Entity.Task>
    {
       
    }
}
