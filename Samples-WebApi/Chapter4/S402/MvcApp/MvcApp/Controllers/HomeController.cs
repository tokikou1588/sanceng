using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DemoModel model = new DemoModel { Foo = "Foo", Bar = "Bar", Baz = "Baz" };
            return View(model);
        }
    }
}
