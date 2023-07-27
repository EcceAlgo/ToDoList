using Microsoft.EntityFrameworkCore;
using ToDoList.Data.Entity;

namespace ToDoList.Data.Context
{
    public class ToDoListDBContext : DbContext
    {
        public ToDoListDBContext() 
        { 
        }

        public ToDoListDBContext(DbContextOptions<ToDoListDBContext> options) 
            : base(options) 
        {
        }

        public virtual DbSet<Entity.Task> Tasks { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }

    }
}
