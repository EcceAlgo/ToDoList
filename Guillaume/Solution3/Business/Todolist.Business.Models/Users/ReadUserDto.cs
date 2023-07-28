using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todolist.Business.Model.Users
{
    public class ReadUserDto : CreateUserDto
    {

        public int Id { get; set; }
    }
}
