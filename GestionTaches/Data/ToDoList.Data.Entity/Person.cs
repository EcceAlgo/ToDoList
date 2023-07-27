using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Data.Entity
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public virtual ICollection<Task> Taskes { get; set; }
    }
}