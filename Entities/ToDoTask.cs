using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListWindowsFormApp.Entities
{
    public class ToDoTask
    {
        [Key]
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskDueDate { get; set; }
        public string TaskStatus { get; set; }
    }
}
