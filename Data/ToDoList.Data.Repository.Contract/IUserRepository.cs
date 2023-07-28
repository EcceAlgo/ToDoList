using Microsoft.EntityFrameworkCore;
using ToDoList.Data.Context.Contract;
using ToDoList.Data.Entity;

namespace ToDoList.Data.Repository.Contract
{
    public interface IUserRepository : IGenericRepository<User>
    {
        
    }
}
