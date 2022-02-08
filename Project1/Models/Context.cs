using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Context : DbContext 
    {
      //Constructor 
      public Context(DbContextOptions<Context> options) : base(options)
        {
            //leave blank for now 
        }
        public DbSet<TaskModel> Responses { get; set; }
        public DbSet<TaskCategory> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //Create categories for category model
            mb.Entity<TaskCategory>().HasData(
                new TaskCategory { CategoryId = 1, CategoryName = "Home" },
                new TaskCategory { CategoryId = 2, CategoryName = "School" },
                new TaskCategory { CategoryId = 3, CategoryName = "Work" },
                new TaskCategory { CategoryId = 4, CategoryName = "Church" }

            );
        }
    }
}
