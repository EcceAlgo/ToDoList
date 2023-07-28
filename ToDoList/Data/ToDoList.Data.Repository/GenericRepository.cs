using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data.Context.Contract;
using ToDoList.Data.Repository.Contract;

namespace ToDoList.Data.Repository
{
    public abstract class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {
        /// <summary>
        /// d b context
        /// </summary>
        private readonly IToDoListDbContext _dbContext;

        /// <summary>
        /// La table
        /// </summary>
        protected readonly DbSet<Entity> _table;

        /// <summary>
        /// Initialise une nouvelle instance de GenericRepository
        /// </summary>
        /// <param name="dbContext"></param>
        public GenericRepository(IToDoListDbContext dbContext)
        {
            _dbContext = dbContext;
            _table = dbContext.Set<Entity>();
        }

        /// <summary>
        /// Cette méthode permet de créer un element dans la table Entity
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
        /// Cette méthode permet de supprimer un element dans la table Entity
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
        /// Cette méthode permet de récupérer la liste des elements de Entity
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Entity>> GetAllAsync()
        {
            return await _table.ToListAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// Cette méthode permet de récupérer d'un element Entity par son identifiant
        /// </summary>
        /// <returns></returns>
        public async Task<Entity> GetByKeyAsync(object id)
        {
            return await _table.FindAsync(id).ConfigureAwait(false);
        }

        /// <summary>
        /// Cette méthode permet de modifier un element dans la table Entity
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public async Task<Entity> UpdateElementAsync(Entity element)
        {
            var elementUpdated = _table.Update(element);
            await _dbContext.SaveChangesAsync().ConfigureAwait(false);

            return elementUpdated.Entity;
        }

        Task<IEnumerable<Entity>> IGenericRepository<Entity>.CreateElementAsync(Entity element)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Entity>> IGenericRepository<Entity>.DeleteElementAsync(Entity element)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Entity>> IGenericRepository<Entity>.GetByKeyAsync(object id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Entity>> IGenericRepository<Entity>.UpdateElementAsync(Entity element)
        {
            throw new NotImplementedException();
        }
    }
}
