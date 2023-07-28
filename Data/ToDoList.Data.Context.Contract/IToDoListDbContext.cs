using Microsoft.EntityFrameworkCore;
using ToDoList.Data.Entity;

namespace ToDoList.Data.Context.Contract
{
    public interface IToDoListDbContext: IDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Entity.Task> Tasks { get; set; }
        DbSet<Status> Statuses { get; set; }

    }
}
