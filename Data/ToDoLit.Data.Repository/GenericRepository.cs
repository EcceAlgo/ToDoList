using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data.Context.Contract;
using ToDoList.Data.Repository.Contract;

namespace ToDoLit.Data.Repository
{
    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {
        private readonly IToDoListDbContext _dbContext;
        private readonly DbSet<Entity> _table;
        /// <summary>
        /// Constructeur, initialise une new instance de GenericRepository
        /// </summary>
        /// <param name="dbContext"></param>
        public GenericRepository(IToDoListDbContext dbContext)
        {
            _dbContext = dbContext;
            _table = _dbContext.Set<Entity>();
        }
    }
}
