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
        public ToDoListDBContext(DbContextOptions<ToDoListDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Entity.Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var user = new User()
            {   
                UserId = 1,
                FirstName = "Marie",
                LastName = "Dupont",
                Email = "maried@test.com",
                Password = "123456",
            };

            modelBuilder.Entity<User>().HasData(user);
        }
    }
}
