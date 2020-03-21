using MVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApp.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        // Post request for /Person/Index
        [HttpPost]
        public ActionResult Index(int age)
        {
            if (age < 20)
                ViewBag.Result = "Young";
            else
                if (age < 50)
                ViewBag.Result = "Middle-aged";
            else
                ViewBag.Result = "Old";

            return View();
        }

        // GET: Person/BMI
        public ActionResult BMI()
        {
            var model = new PersonDetails();
            return View(model);
        }

        [HttpPost]  // POST : Person/BMI
        public ActionResult BMI(PersonDetails model)
        {
            if (ModelState.IsValid)  // is data valid??
            {
                var meters = model.Height / 100; // Convert CM to Meters 
                model.BMI = model.Weight / (meters * meters);
            }
            return View(model);
        }
    }
}