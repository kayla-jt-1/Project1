﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Project1.Models
{
    public class Task
    {
        
        [Key]
        [Required]
        public int TaskId { get; set; }
        [Required]
        public string TaskName { get; set; }
        public string DueDate { get; set; }
        [Required]
        public string Quadrant { get; set; }
        public int CategoryID { get; set; } //Home, School, Work, Church)
        public TaskCategory TaskCategory { get; set; }
        public bool Completed { get; set; }
    }
}
