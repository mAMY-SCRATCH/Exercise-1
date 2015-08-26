using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MagasinVideo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Laissez nous un commentaire";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.Message = message;

            return View();
        }

        public ActionResult Foo()
        {
            return View();

        }
        public ActionResult Serie(string param)
        {
            var serie = "MVC & shit";

            if (param == "min")
            {
                return Content(serie.ToLower());
            }
            if (param == "json")
            {
                return Json(new { name = "serie", value = serie }, JsonRequestBehavior.AllowGet);
            }

            return RedirectToAction("Index");
            return Content(serie);
        }
    }
}
