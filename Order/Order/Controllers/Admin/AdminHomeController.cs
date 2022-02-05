using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Order.Models;
namespace Order.Controllers
{
    [Authorize(Roles = "Super_Admin")]
    public class AdminHomeController : Controller
    {
        // GET: AdminHome
        public ActionResult Index()
        {
            try
            {
                using (OrdersEntities db =new OrdersEntities())
                {
                   
                   var restourant = db.Restourants.Select(e => e).ToList();
                    return View(restourant);

                }
            }
            catch
            {

                throw;
            }
        }

        [HttpGet]
        public ActionResult CreateRestorant()
        {
            return View();

        }
        [HttpPost]
        public ActionResult CreateRestorant(Restourant restourant)
        {
            try
            {
                using (OrdersEntities db = new OrdersEntities())
                {
                    db.Restourants.Add(restourant);
                    db.SaveChanges();

                    TempData["success"] = "Yeni Restoran Başarı  ile eklenmiştir";
                    return View();
                }
            }
            catch 
            {
                

                TempData["error"] = "Yeni Restoran eklenirken bir hata oluşmuş";
                return View();

            } 

        }

        // GET: AdminHome/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminHome/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminHome/Create
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

        // GET: AdminHome/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminHome/Edit/5
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

        // GET: AdminHome/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminHome/Delete/5
        [HttpGet]
        public ActionResult DeleteRestoran(int id)
        {
            try
            {
                using (OrdersEntities db = new OrdersEntities())
                {

                    Restourant restourant = db.Restourants.Find(id);
                    db.Restourants.Remove(restourant);
                    db.SaveChanges();
                    TempData["success"] = "Silmek istediğiniz Restoran başarı ile silinmiştir ";
                    return RedirectToAction("index", "AdminHome");
                }
            }
            catch
            {
                TempData["error"] = "Silmek istediğiniz Restoran silme işlemini yaprken hata oluşmuştur ";
                return RedirectToAction("index", "AdminHome");
            }
        }





    }
}
