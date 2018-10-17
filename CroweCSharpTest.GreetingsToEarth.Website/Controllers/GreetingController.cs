using CroweCSharpTest.GreetingsToEarthWebsite.Models;
using CroweCSharpTest.GreetingsToEarthWebsite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CroweCSharpTest.GreetingsToEarthWebsite.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index()
        {
            var repo = new GreetingRepo();

            Greeting model = repo.GetGreeting();

            return View(model);
        }
    }
}