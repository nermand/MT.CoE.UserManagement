using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetOpenAuth.OpenId.Extensions.AttributeExchange;
using MT.CoE.UserManagement.Models;
using MT.CoE.UserManagement.Repositories;
using MT.CoE.UserManagement.ViewModels.Admin;

namespace MT.CoE.UserManagement.Controllers
{
    public class AdminController : Controller
    {
        readonly static UserRep UserRep = new UserRep();
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            InitializeUsers();
            ViewBag.Welcome = "Admin panel - add/edit users";
            return View();
        }

        [HttpGet]
        public JsonResult UserList()
        {
            var userListViewModel = new List<UserList>();
           // CreateCollections();
            var userRep = new UserRep();
            var userList = userRep.GetAllUsers();
            var cities = CityRep.GetAllCities();
            var jobs = JobRep.GetAllJobs();
            var companies = CompanyRep.GetAllCompanies();

            foreach (var user in userList)
            {
                var userItem = user;
                var model = new UserList
                    {
                        Address = userItem.Address,
                        CityName = cities.Where(c => c.CityId.Equals(userItem.CityId)).Select(c => c.CityName).FirstOrDefault(),
                        CompanyName = companies.Where(c => c.CompanyId.Equals(userItem.CompanyId)).Select(c => c.CompanyName).FirstOrDefault(),
                        Id = userItem.UserId,
                        Country = cities.Where(c => c.CityId.Equals(userItem.CityId)).Select(c => c.Country).FirstOrDefault(),
                        FirstName = userItem.FirstName,
                        JobDescription = jobs.Where(c => c.JobId.Equals(userItem.JobId)).Select(c => c.Description).FirstOrDefault(),
                        LastName = userItem.LastName,
                        PhoneNumber = userItem.PhoneNumber,
                        PicUrl = GetUserPic(userItem.FirstName),
                        PostalCode = cities.Where(c => c.CityId.Equals(userItem.CityId)).Select(c => c.PostalCode).FirstOrDefault()
                    };
                userListViewModel.Add(model);
            }


            return Json(userListViewModel, JsonRequestBehavior.AllowGet);
        }

        private string GetUserPic(string firstName)
        {
            var result ="";
            switch (firstName)
            {
                case "Anita":
                    result = @Url.Content("~/Content/Images/Anita.png");
                    break;
                case "Ervin":
                    result = @Url.Content("~/Content/Images/Ervin.PNG");
                    break;
                case "Matej":
                    result = @Url.Content("~/Content/Images/Matej.PNG");
                    break;
                case "Nerman":
                    result = @Url.Content("~/Content/Images/Nerman.PNG");
                    break;
                case "Zinajda":
                    result = @Url.Content("~/Content/Images/Zina.PNG");
                    break;
            }

            return result;
        }

        [HttpPost, ActionName("SingleUser")]
        public JsonResult SingleUserPost()
        {
            var user = new List<User>();

            return Json(user, JsonRequestBehavior.AllowGet);
        }

        [HttpDelete]
        [ActionName("SingleUser")]
        public JsonResult SingleUserDelete(int id)
        {
            try
            {
                UserRep.Delete(id);
            }
            catch (Exception ex)
            {

                return Json(new { error = ex.Message }
                                , JsonRequestBehavior.AllowGet);
            }

            return Json(new { success= true}, "User",  JsonRequestBehavior.AllowGet);
        }

        private void CreateCollections()
        {
            var city = new City() {
                CityId = 1,
                CityName = "Sarajevo",
                PostalCode = "71000",
                Country = "BiH"
            }; var city2 = new City() {
                CityId = 2,
                CityName = "Houston",
                PostalCode = "77077",
                Country = "USA"
            };

            var cityRep = new CityRep();
            cityRep.Add(city);
            cityRep.Add(city2);


            var job = new Job() {
                JobId = 1,
                Description = "Software Developer"
            };
            var jobRep = new JobRep();
            jobRep.Save(job);


            var company = new Company() {
                CompanyId = 1,
                CompanyName = "Mistral Technologies"
            };
            var companyRep = new CompanyRep();
            companyRep.Save(company);



        }

        private void InitializeUsers()
        {
                        var userDb = new User() {
                UserId = 1,
                Address = "Azize Šaćirbegović 1",
                CertId = 0,
                CityId = 1,
                CompanyId = 1,
                Dob = new DateTime(1980, 3, 31),
                Email = "",
                FacultyId = 0,
                FirstName = "Nerman",
                HighSchoolId = 0,
                Hobby = "",
                JobId = 1,
                LastName = "Deliahmetovic",
                PersonalSkills = "",
                PhoneNumber = "",
                TechId = 0
            }; 
            var userDbMatej = new User()
            {
                UserId = 2,
                Address = "Azize Šaćirbegović 1",
                CertId = 0,
                CityId = 1,
                CompanyId = 1,
                Dob = new DateTime(1985, 1, 1),
                Email = "",
                FacultyId = 0,
                FirstName = "Matej",
                HighSchoolId = 0,
                Hobby = "",
                JobId = 1,
                LastName = "Cica",
                PersonalSkills = "",
                PhoneNumber = "",
                TechId = 0
            }; 
            var userDbAnita = new User()
            {
                UserId = 3,
                Address = "Azize Šaćirbegović 1",
                CertId = 0,
                CityId = 1,
                CompanyId = 1,
                Dob = new DateTime(1985, 1, 1),
                Email = "",
                FacultyId = 0,
                FirstName = "Anita",
                HighSchoolId = 0,
                Hobby = "",
                JobId = 1,
                LastName = "Cinac",
                PersonalSkills = "",
                PhoneNumber = "",
                TechId = 0
            }; 
            var userDbErvin = new User()
            {
                UserId = 4,
                Address = "Azize Šaćirbegović 1",
                CertId = 0,
                CityId = 1,
                CompanyId = 1,
                Dob = new DateTime(1980, 3, 31),
                Email = "",
                FacultyId = 0,
                FirstName = "Ervin",
                HighSchoolId = 0,
                Hobby = "",
                JobId = 1,
                LastName = "Sikira",
                PersonalSkills = "",
                PhoneNumber = "",
                TechId = 0
            }; 
            var userDbZina = new User()
            {
                UserId = 5,
                Address = "Azize Šaćirbegović 1",
                CertId = 0,
                CityId = 1,
                CompanyId = 1,
                Dob = new DateTime(1980, 3, 31),
                Email = "",
                FacultyId = 0,
                FirstName = "Zinajda",
                HighSchoolId = 0,
                Hobby = "",
                JobId = 1,
                LastName = "Sarac",
                PersonalSkills = "",
                PhoneNumber = "",
                TechId = 0
            };
            var userRep = new UserRep();
            userRep.DeleteAll();
            userRep.InsertUser(userDbAnita);
            userRep.InsertUser(userDbErvin);
            userRep.InsertUser(userDbMatej);
            userRep.InsertUser(userDbZina);
            userRep.InsertUser(userDb);
        }
    }
}
