using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
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

        //public JsonResult GetAllUsers()
        //{
        //    var userList = new List<User_old>
        //        {
        //            new User_old() {Name = "Nerman"}, 
        //            new User_old() {Name = "Josip"}, 
        //            new User_old() {Name = "Broz"}
        //        };

        //    return Json(userList, JsonRequestBehavior.AllowGet);
        //}

        //[HttpGet]
        //public JsonResult Test() {
        //    var rep = new Repositories.UserRepository();
        //    rep.TestMongoProvider();

        //    var user = new List<User>();
        //    user.Add(new User() {  Address = "New Haven", Id = Guid.NewGuid().ToString(), FirstName = "Jonathan" });
        //    user.Add(new User() {   Address = "Sarajevo", Id = Guid.NewGuid().ToString(), FirstName = "Bones" });

        //    return Json(user, JsonRequestBehavior.AllowGet);
        //}

        [HttpPost]
        public void Test(List<User> userList)
        {
        }

    }
}
