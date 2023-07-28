using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data.Context.Contract;

namespace ToDoLit.Data.Repository
{
    public class UserRepository
    {
        private readonly IToDoListDbContext _DbContext;
        public UserRepository(IToDoListDbContext dbContext)
        {
            _DbContext = dbContext;
        }
    }
}
