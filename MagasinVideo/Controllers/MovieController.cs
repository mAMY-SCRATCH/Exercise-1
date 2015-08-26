using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MagasinVideo.Models;

namespace MagasinVideo.Controllers
{
    public class MovieController : Controller
    {
        private Repository _repository = new Repository();
       
        //
        // GET: /Movie/

        public ActionResult Index()
        {
            
            //return View(new List<Movie>());
            return View("Index", _repository.GetAllMovies());
        }

        //
        // GET: /Movie/Details/5

        public ActionResult Details(int id)
        {
            
            return Content(_repository.GetMovie(id));
        }

        //
        // GET: /Movie/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Movie/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            

            _repository.AddMovie(collection.GetValue("Title").ToString(),collection.GetValue("Genre").ToString());
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Movie/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Movie/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Movie/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Movie/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
           
            _repository.DeleteMovie(id);
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
