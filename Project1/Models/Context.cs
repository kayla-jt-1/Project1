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
        public DbSet<Task> Responses { get; set; }
        public DbSet<TaskCategory> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //Create categories for category model
            mb.Entity<TaskCategory>().HasData(
            new TaskCategory { CategoryId = 1, CategoryName = "Comedy" },
            new TaskCategory { CategoryId = 2, CategoryName = "Romantic Comedy" },
            new TaskCategory { CategoryId = 3, CategoryName = "Drama" },
            new TaskCategory { CategoryId = 4, CategoryName = "Family" },
            new TaskCategory { CategoryId = 5, CategoryName = "Action/Adventure" },
            new TaskCategory { CategoryId = 6, CategoryName = "Horror/Suspense" },
            new TaskCategory { CategoryId = 7, CategoryName = "Television" }
                );
        }



    }
}
