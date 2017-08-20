using MySQL_identity_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MySQL_identity_demo.Controllers
{
    [Authorize]
    public class zgradaController : Controller
    {
        //Connection on db
        private sveDbContext db = new sveDbContext();
        
        // GET: zgrada
        public ActionResult Index()
        {
            return View();
        }

        // GET: zgrada/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        // GET: zgrada/Create
        public ActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        // POST: zgrada/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
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
        [Authorize(Roles = "Admin")]
        // GET: zgrada/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        // POST: zgrada/Edit/5
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
        [Authorize(Roles = "Admin")]
        // GET: zgrada/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        // POST: zgrada/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
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
