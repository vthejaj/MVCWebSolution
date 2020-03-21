using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebApp.Models;

namespace MVCWebApp.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index(string name)
        {
            ViewBag.Message = $"Hello {name}!";
            return View();
        }

        public ActionResult Greet(string name)
        {
            var model = new Greetings();
            model.Message = "Hello";

            if (name == null)
                name = "Guest";

            model.User = name;

            return View(model);
        }
        public ActionResult Demo()
        {
            return View();
        }

    }
}