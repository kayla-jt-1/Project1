using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
//using System.Threading.Tasks;

//#1: Models / Database / Setup: This individual will build the models and set up the database.
//They will populate the database with any needed info. They will also configure all the needed
//settings/services/endpoints in the Startup.cs file

//Build an app that allow the users to enter tasks with the following information:
//• Task(Required)
//• Due Date
//• Quadrant (Required)
//• Category(Dropdown containing options: Home, School, Work, Church)
//• Completed(True / False)
//Build a View that lists out all the tasks, laid out on the screen in Quadrants. Allow the user to
//Update and Delete the tasks and also to mark as Completed. Only display tasks that have not
//been completed. Create a navigation menu to navigate between each view.

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Context Context { get; set; }

        public HomeController(Context blah)
        {
            Context = blah;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TaskInput()
        {
            ViewBag.Categories = Context.Categories.ToList();
            return View(); 
        }

        // ADD inputs to database
        [HttpPost]
        public IActionResult TaskInput(Task tm)
        {
            if (ModelState.IsValid)
            {
                Context.Add(tm);
                Context.SaveChanges();

                return View(); 
                //return View("Confirmation", tm); 
            }
            else
            {
                ViewBag.Categories = Context.Categories.ToList();
                return View(); 
            }
        }

        // VIEW
        [HttpGet]
        public IActionResult viewTasks()
        {
            var applications = Context.Responses
                .Include(x => x.TaskCategory) // TaskCategory is the model
                .ToList();
            return View(applications);
        }


        // UPDATE
        [HttpGet]
        public IActionResult Edit(int taskid) 
        {
            ViewBag.Categories = Context.Categories.ToList(); 

            var task = Context.Responses.Single(x => x.TaskId == taskid);  

            return View("TaskInput", task); 
        }

        [HttpPost]
        public IActionResult Edit(Task blah)
        {
            Context.Update(blah);
            Context.SaveChanges();

            return RedirectToAction("viewTasks");
        }


        // DELETE
        [HttpGet]
        public IActionResult Delete(int taskid)
        {
            var task = Context.Responses.Single(x => x.TaskId == taskid);

            return View(task);
        }

        [HttpPost]
        public IActionResult Delete(Task blah)
        {
            Context.Responses.Remove(blah);
            Context.SaveChanges();

            return RedirectToAction("viewTasks"); // redirect user back to view task page

        }




    }
}
