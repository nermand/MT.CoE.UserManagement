using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MT.CoE.UserManagement.Models;
using MvcGit.Models;

namespace MT.CoE.UserManagement.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            ViewBag.Welcome = "Welcome to User List";
            return View();
        }

        public JsonResult GetAllUsers()
        {
            var userList = new List<User_old>
                {
                    new User_old() {Name = "Nerman"}, 
                    new User_old() {Name = "Josip"}, 
                    new User_old() {Name = "Broz"}
                };

            return Json(userList, JsonRequestBehavior.AllowGet);
        }

        public void Test()
        {
            var rep = new Repositories.UserRepository();
            rep.TestMongoProvider();
        }

    }
}
