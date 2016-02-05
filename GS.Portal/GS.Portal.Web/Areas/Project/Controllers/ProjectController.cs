using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GS.Portal.Web.Areas.Project.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project/Project
        public ActionResult Index()
        {
            return View();
        }

        // GET: Project/Project/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Project/Project/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Project/Project/Create
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

        // GET: Project/Project/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Project/Project/Edit/5
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

        // GET: Project/Project/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Project/Project/Delete/5
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
