using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todolist.Business.Model.Users
{
    public class ReadUserDto
    {

        public int Id { get; set; }
        public string Prénom { get; set; }
        public string Nom { get; set; }
        public string Courriel { get; set; }
        public string Mdp { get; set; }
    }
}
