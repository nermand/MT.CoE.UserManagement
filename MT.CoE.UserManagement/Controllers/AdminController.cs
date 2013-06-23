using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetOpenAuth.OpenId.Extensions.AttributeExchange;
using MT.CoE.UserManagement.Models;

namespace MT.CoE.UserManagement.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            ViewBag.Welcome = "Admin part - add/edit users";
            return View();
        }

        [HttpGet]
        public JsonResult UserList() {
            var rep = new Repositories.UserRepository();
            rep.TestMongoProvider();

            var user = new List<User>();
            user.Add(new User()
                         {
                             Address = "New Haven",
                             UserId = Guid.NewGuid().ToString(),
                             FirstName = "Jonathan",
                             LastName = "Jonathan",
                             BirthDate = new DateTime(1980, 3, 31),
                             Email = "Jonathan@mail.com",
                             PhoneNo = "---"
                         });
            user.Add(new User()
                         {
                             Address = "Sarajevo", 
                             Id = Guid.NewGuid().ToString(), 
                             FirstName = "Bones",
                             LastName = "Bones Lastname",
                             BirthDate = new DateTime(1968, 5, 11),
                             Email = "Bones@mail.com"
                         });

            return Json(user, JsonRequestBehavior.AllowGet);
        }

    }

}
