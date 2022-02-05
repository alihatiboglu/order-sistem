using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Order.Models;

namespace Order.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult login()
        {
            return View();
        }
        public ActionResult Logout()
        {

                FormsAuthentication.SignOut();
                return Redirect(Url.Action("Index","Home"));

        }
        [HttpPost]
        public ActionResult Login(UserModal user, string ReturnUrl)
        {
            if (isvalid(user))
            {
               
                FormsAuthentication.SetAuthCookie(user.UserName, true);

                return RedirectToAction("LoginTest", "Login");


            }
            else
            {

                ModelState.AddModelError("Login Error","Kullanıcı adı vaya şifre yankış");
                return View();
            }
        }
        private bool isvalid(UserModal user)
        {
            using (OrdersEntities DB = new OrdersEntities())
            {
                var myuser = DB.Users.Where(e => e.UserName == user.UserName && e.Password == user.Password).FirstOrDefault();
                if (myuser==null)
                {
                    return false;
                }
                else
                {
                    Session["userID"] = myuser.ID.ToString();
                    return (user.UserName == myuser.UserName && user.Password == myuser.Password);


                }
            }

        }
        public ActionResult Header()
        {
            OrdersEntities db = new OrdersEntities();
            List<User> user = new List<User>();
            int id = int.Parse(Session["userID"].ToString());
            user = db.Users.Where(e => e.ID == id ).Select(e => e).ToList();
            return PartialView("Header",user);
        }
        public ActionResult LoginTest()
        {


            if (User.IsInRole("Yonetici"))
            {
                return RedirectToAction("index", "YoneticiHome");
            }
            else if (User.IsInRole("Super_Admin"))
            {

                return RedirectToAction("index", "AdminHome");
            }
            else if (User.IsInRole("Garson"))
            {

                return RedirectToAction("index", "GarsonHome");
            }
            else {
                return RedirectToAction("login", "login");


            }


        }







    }
}