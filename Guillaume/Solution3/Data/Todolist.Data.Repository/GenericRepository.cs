using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todolist.Data.Context.Contract;
using Todolist.Data.Repository.Contract;

namespace Todolist.Data.Repository
{
    public abstract class GenericRepository<Entity> :IGenericRepository<Entity>  where Entity : class
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ITodolistDbContext _dBContext;

        /// <summary>
        /// 
        /// </summary>
        private readonly DbSet<Entity> _table;

            /// <summary>
            /// Initialize new instance of the <see cref="GenericRepository"/> class
            /// </summary>
            /// <param name="dbContext"></param>
        public GenericRepository(ITodolistDbContext dbContext)
        {
            _dBContext = dbContext;
            _table = _dBContext.Set<Entity>();
        }

        public async Task<Entity> CreateElementAsync(Entity element)
        {
            var elementAdded =  await _table.AddAsync(element).ConfigureAwait(false);
            await _dBContext.SaveChangesAsync().ConfigureAwait(false);

            return elementAdded.Entity;
        }

        public async Task<Entity> DeleteElementAsync(Entity element)
        {
            var elementDeleted = _table.Remove(element);
            await _dBContext.SaveChangesAsync().ConfigureAwait (false);
            return elementDeleted.Entity;
        }

        public async Task<IEnumerable<Entity>> GetAllAsync()
        {
            return await _table.ToListAsync().ConfigureAwait(false);
        }

        public async Task<Entity> GetByKeyAsync(object id)
        {
            return await _table.FindAsync(id).ConfigureAwait(false);
        }

        public async Task<Entity> UpdateElementAsync(Entity element)
        {
            var elementUpdate = _table.Update(element);
            await _dBContext.SaveChangesAsync().ConfigureAwait (false);
            return elementUpdate.Entity;
        }
    }
}
