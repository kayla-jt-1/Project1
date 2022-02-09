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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //Create categories for category model
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Home" },
                new Category { CategoryId = 2, CategoryName = "School" },
                new Category { CategoryId = 3, CategoryName = "Work" },
                new Category { CategoryId = 4, CategoryName = "Church" }

            );

            mb.Entity<TaskModel>().HasData(
                new TaskModel
                {
                    TaskId = 1,
                    CategoryId = 2,
                    TaskName = "Finish Mission 6",
                    DueDate = "February 9, 2022",
                    Quadrant = "1",
                    Completed = false,
                },
                new TaskModel
                {
                    TaskId = 2,
                    CategoryId = 4,
                    TaskName = "Finish Book of Mosiah",
                    DueDate = "February 12, 2022",
                    Quadrant = "2",
                    Completed = true,
                }

                );
        }
    }
}


