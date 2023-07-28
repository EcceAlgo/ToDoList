using Microsoft.EntityFrameworkCore;
using ToDoList.Data.Context.Contract;

namespace ToDoList.Data.Repository
{
    public abstract class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {
        /// <summary>
        /// The DB context
        /// </summary>
        private readonly IToDoListDbContext _dbContext;

        /// <summary>
        /// The table
        /// </summary>
        protected readonly DbSet<Entity> _table;

        public GenericRepository(IToDoListDbContext dbContext)
        {
            _dbContext = dbContext;
            _table = _dbContext.Set<Entity>();
        }

        /// <summary>
        /// Creates a new element in the Entity table
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public async Task<Entity> CreateElementAsync(Entity element)
        {
            var elementAdded = await _table.AddAsync(element).ConfigureAwait(false);
            await _dbContext.SaveChangesAsync().ConfigureAwait(false);

            return elementAdded.Entity;
        }

        /// <summary>
        /// Deletes an element in the Entity table
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public async Task<Entity> DeleteElementAsync(Entity element)
        {
            var elementDeleted = _table.Remove(element);
            await _dbContext.SaveChangesAsync().ConfigureAwait(false);
            return elementDeleted.Entity;
        }

        /// <summary>
        /// Gets all elements of Entity as a list
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Entity>> GetAllAsync()
        {
            return await _table.ToListAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// Gets one element of Entity by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Entity> GetByKeyAsync(object id)
        {
            return await _table.FindAsync(id).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates an element in the Entity table
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public async Task<Entity> UpdateElementAsync(Entity element)
        {
            var elementUpdate = _table.Update(element);
            await _dbContext.SaveChangesAsync().ConfigureAwait(false);
            return elementUpdate.Entity;
        }
    }
}
