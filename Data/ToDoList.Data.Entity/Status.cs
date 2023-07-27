using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Data.Entity
{
    public class Status
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int StatusId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Task>? Tasks { get;}

    }
}
