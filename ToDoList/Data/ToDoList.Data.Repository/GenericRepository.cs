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
    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {
        /// <summary>
        /// d b context
        /// </summary>
        private readonly IToDoListDbContext _dbContext;

        /// <summary>
        /// La table
        /// </summary>
        private readonly DbSet<Entity> _Entity;

        /// <summary>
        /// Initialise une nouvelle instance de GenericRepository
        /// </summary>
        /// <param name="dbContext"></param>
        public GenericRepository(IToDoListDbContext dbContext)
        {
            _dbContext = dbContext;
            _Entity = dbContext.Set<Entity>();
        }

        /// <summary>
        /// Cette méthode permet de créer un element dans la table Entity
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public Task<IEnumerable<Entity>> CreateElementAsync(Entity element)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cette méthode permet de supprimer un element dans la table Entity
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public Task<IEnumerable<Entity>> DeleteElementAsync(Entity element)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cette méthode permet de récupérer la liste des elements de Entity
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Entity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cette méthode permet de récupérer d'un element Entity par son identifiant
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Entity>> GetByKeyAsync(object id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cette méthode permet de modifier un element dans la table Entity
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public Task<IEnumerable<Entity>> UpdateElementAsync(Entity element)
        {
            throw new NotImplementedException();
        }
    }
}
