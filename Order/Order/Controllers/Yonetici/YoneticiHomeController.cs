using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Order.Controllers
{
    [Authorize(Roles = "Yonetici")]
    public class YoneticiHomeController : Controller
    {
        // GET: YoneticiHome
        public ActionResult Index()
        {
            return View();
        }

        // GET: YoneticiHome/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: YoneticiHome/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: YoneticiHome/Create
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

        // GET: YoneticiHome/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: YoneticiHome/Edit/5
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

        // GET: YoneticiHome/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: YoneticiHome/Delete/5
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
