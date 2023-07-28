using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todolist.Data.Entity;
using Task = Todolist.Data.Entity.Task;

namespace Todolist.Data.Repository.Contract
{
    public interface ITaskRepository : IGenericRepository<Task>
    {

    }
}
