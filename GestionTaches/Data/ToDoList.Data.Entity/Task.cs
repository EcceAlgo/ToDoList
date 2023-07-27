using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Data.Entity
{
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskId { get; set; }
        public int TaskName { get; set; }
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? DueDate { get; set; }

        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    } 
}
