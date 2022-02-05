using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Order.Controllers
{
    [Authorize(Roles = "Garson")]
    public class GarsonHomeController : Controller
    {
        // GET: GarsonHome
        public ActionResult Index()
        {
            return View();
        }

        // GET: GarsonHome/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GarsonHome/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GarsonHome/Create
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

        // GET: GarsonHome/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GarsonHome/Edit/5
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

        // GET: GarsonHome/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GarsonHome/Delete/5
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
