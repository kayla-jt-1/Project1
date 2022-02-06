using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
