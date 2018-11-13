using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Model
{
    public class Todo
    {

        public int Id { get; set; }
        public string Description { get; set; }

        public DateTime? Limit { get; set; }
        
        [Required]
        public Priority Priority { get; set; }
        public DateTime InsertDate { get; set; }

        [Required]
        public TodoType TodoType { get; set; }
        public bool Done { get; set; }
        public DateTime? DoneDate { get; set; }
        public bool Deleted { get; set; }

        public bool IsComplete()
        {
            if (string.IsNullOrWhiteSpace(Description)) return false;
            if (Priority == null) return false;
            if (TodoType == null) return false;
            return true;
        }
    }
}
