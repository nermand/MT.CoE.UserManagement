using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Linq.Expressions;
using MT.CoE.UserManagement.Models;
using MongoRepository;

namespace MT.CoE.UserManagement.Repositories
{
    public class UserRepository : MongoRepository<User>, IUserRepository
    {
        static MongoRepository<User> _userRepo = new MongoRepository<User>();

        /// <summary>
        /// Test method- showcase for working with Mongo
        /// </summary>
        public void TestMongoProvider()
        {            
            var currentInDb = _userRepo.All();

            var user1 = new User() { FirstName = "Marko Vesovic", PhoneNo = "66", Address = "Sarajevo", Email = "71000" };
            var user2 = new User() { FirstName = "keremito", PhoneNo = "21", Address = "NYC", Email = null };
            var user3 = new User() { FirstName = "Omer Asik", PhoneNo = "29", Address = "Houston", Email = "77077" };
            _userRepo.Add(new[] { user1, user2, user3 });

            ShowAllUsers(currentInDb);
            
            user2.FirstName = "John Kerry";
            _userRepo.Update(user2);

            user3.PhoneNo = "25";
            _userRepo.Update(user3);

            ShowAllUsers(currentInDb);

            //user2.Skills.AddRange(new[]
            //    {
            //        new Skill(){FirstName = "Javascript",Category = "Programming Language"}, 
            //        new Skill(){FirstName = "C#",Category = "Programming Language"}, 
            //        new Skill(){FirstName = "Table Football",Category = "Social Skills"}
            //    });
            _userRepo.Update(user2);
            ShowAllUsers(currentInDb);

            var getUser1 = _userRepo.GetById(user2.Id);
            Debug.WriteLine("User get by ID. FirstName: {0} (having {1} skills)",
                getUser1.FirstName, "Skills");
            var getUser2 = _userRepo.GetSingle(u => u.FirstName.StartsWith( "Marko"));
            if (getUser2 != null)
            {
                            Debug.WriteLine("User get by predicate. FirstName: {0} (having {1} skills)",
                getUser2.FirstName, "Skills");
            }
            
            _userRepo.DeleteAll();
            Debug.WriteLine("After delete all....");
            ShowAllUsers(currentInDb);

        }

        public IQueryable<User> GetUsers(Expression<Func<User, bool>> inCriteria)
        {
            return _userRepo.All(inCriteria).AsQueryable();
        }

        private void ShowAllUsers(IEnumerable<User> allUsers )
        {
            foreach (var user in allUsers)
            {
                Debug.WriteLine("Debug : User FirstName = " + user.FirstName);
                Debug.WriteLine("Debug : User address = " + user.Address);
                Debug.WriteLine("Debug : User has {0} skills = ", "" );
                //foreach (var userSkill in user.Skills)
                //{
                //    Debug.WriteLine("Debug : User skill = " + userSkill.FirstName);
                //}
                Debug.WriteLine("-------");
                
            }
        }
    }
}