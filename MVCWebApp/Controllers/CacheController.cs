using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApp.Controllers
{
    public class CacheController : Controller
    {
        // GET: Cache
        [OutputCache(Duration = 60)]
        public ActionResult Index()
        {
            var now = DateTime.Now.ToString();
            ViewBag.Now = now;
            return View();
        }
    }
}