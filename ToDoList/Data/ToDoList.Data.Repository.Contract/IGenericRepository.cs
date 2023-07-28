
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Data.Repository.Contract
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        /// <summary>
        /// Cette méthode permet de récupérer la liste des elements de Entity
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Entity>> GetAllAsync();

        /// <summary>
        /// Cette méthode permet de récupérer d'un element Entity par son identifiant
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Entity>> GetByKeyAsync(object id);

        /// <summary>
        /// Cette méthode permet de créer un element dans la table Entity
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        Task<IEnumerable<Entity>> CreateElementAsync(Entity element);

        /// <summary>
        /// Cette méthode permet de modifier un element dans la table Entity
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        Task<IEnumerable<Entity>> UpdateElementAsync(Entity element);

        /// <summary>
        /// Cette méthode permet de supprimer un element dans la table Entity
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        Task<IEnumerable<Entity>> DeleteElementAsync(Entity element);
    }
}
