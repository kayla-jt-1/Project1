using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Project1.Models
{
    public class TaskModel
    {
        
        [Key]
        [Required]
        public int TaskId { get; set; }
        [Required]
        public string TaskName { get; set; }
        public string DueDate { get; set; }
        [Required]
        public string Quadrant { get; set; }

        public int CategoryId { get; set; } 
        public bool Completed { get; set; }

        public TaskCategory TaskCategory { get; set; }

    }
}
