using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data.Context.Contract;
using ToDoList.Data.Entity;
using Task = ToDoList.Data.Entity.Task;

namespace ToDoList.Data.Repository.Contract
{
    public interface ITaskRepository : IGenericRepository<Task>
    {
    }
}
