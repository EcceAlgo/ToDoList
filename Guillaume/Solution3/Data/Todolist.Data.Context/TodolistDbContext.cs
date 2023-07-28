using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Todolist.Data.Context.Contract;
using Todolist.Data.Entity;

namespace Todolist.Data.Context
{
    public class TodolistDbContext : DbContext, ITodolistDbContext
    {
        public TodolistDbContext()
        {
        }

        public TodolistDbContext(DbContextOptions<TodolistDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Entity.Task> Tasks { get; set; }

        public virtual DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var User = new User()
            {
                UserId = 1,
                FirstName = "salut",
                LastName = "aurevoir",
                Email = "salut@coucou.fr",
                Password = "1234",
            };
            modelBuilder.Entity<User>().HasData(User);
        }
    }
}
