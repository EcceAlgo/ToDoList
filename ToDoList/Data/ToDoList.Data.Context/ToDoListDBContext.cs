using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data.Context.Contract;
using ToDoList.Data.Entity;

namespace ToDoList.Data.Context
{
    public class ToDoListDbContext : DbContext, IToDoListDbContext
    {
        public ToDoListDbContext()
        {
        }
        public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Entity.Task> Tasks { get; set; }
    }
}
