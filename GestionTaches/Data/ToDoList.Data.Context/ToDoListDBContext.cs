using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data.Entity;

namespace ToDoList.Data.Context
{
    public class ToDoListDBContext : DbContext
    {
        public ToDoListDBContext() 
        {
        }
        public ToDoListDBContext(DbContextOptions<ToDoListDBContext> options) : base(options)
        {
        }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Entity.Task> Taskes { get; set; }
        public virtual DbSet<Status> Statues { get; set; }


    }
}
