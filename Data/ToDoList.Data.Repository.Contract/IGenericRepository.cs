using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Data.Repository
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        /// <summary>
        /// Gets all elements of Entity as a list
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Entity>> GetAllAsync();

        /// <summary>
        /// Gets one element of Entity by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Entity> GetByKeyAsync(object id);

        /// <summary>
        /// Creates a new element in the Entity table
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        Task<Entity> CreateElementAsync(Entity element);

        /// <summary>
        /// Updates an element in the Entity table
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        Task<Entity> UpdateElementAsync(Entity element);

        /// <summary>
        /// Deletes an element in the Entity table
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        Task<Entity> DeleteElementAsync(Entity element);
    }
}
