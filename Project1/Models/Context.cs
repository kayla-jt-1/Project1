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


        // In case we need to seed the database 

        //protected override void OnModelCreating(ModelBuilder mb)
        //{
        //    mb.Entity<Task>().HasData(
        //        new Task
        //        {
        //            TaskId = 1,
        //            TaskName = 
        //        }
        //    );
        //}
    }
}
