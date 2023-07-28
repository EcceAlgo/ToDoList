using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data.Entity;

namespace ToDoList.Data.Context.Contract
{
    public interface IToDoListDbContext : IDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Entity.Task> Tasks { get; set; }
        public DbSet<Status> Statuses { get; set; }

    }
}
