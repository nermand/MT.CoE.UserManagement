using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using MT.CoE.UserManagement.Models;
using MongoRepository;

namespace MT.CoE.UserManagement.Repositories
{
    public class UserRepository : MongoRepository<User>, IUserRepository
    {
        static MongoRepository<User> _userRepo = new MongoRepository<User>();

        public void TestMongoProvider()
        {            var currentInDb = _userRepo.All();

            var user1 = new User() { Name = "Marko Vesovic", Age = 66, City = "Sarajevo", ZipCode = "71000" };
            var user2 = new User() { Name = "keremito", Age = 21, City = "NYC", ZipCode = null };
            var user3 = new User() { Name = "Omer Asik", Age = 29, City = "Houston", ZipCode = "77077" };
            _userRepo.Add(new[] { user1, user2, user3 });

            ShowAllUsers(currentInDb);
            
            user2.Name = "John Kerry";
            _userRepo.Update(user2);

            user3.Age = 25;
            _userRepo.Update(user3);

            ShowAllUsers(currentInDb);

            user2.Skills.AddRange(new[]
                {
                    new Skill(){Name = "Javascript",Category = "Programming Language"}, 
                    new Skill(){Name = "C#",Category = "Programming Language"}, 
                    new Skill(){Name = "Table Football",Category = "Social Skills"}
                });
            _userRepo.Update(user2);
            ShowAllUsers(currentInDb);

            var getUser1 = _userRepo.GetById(user2.Id);
            Debug.WriteLine("User get by ID. Name: {0} (having {1} skills)",
                getUser1.Name, getUser1.Skills.Count);
            var getUser2 = _userRepo.GetSingle(u => u.Name.StartsWith( "Marko"));
            if (getUser2 != null)
            {
                            Debug.WriteLine("User get by predicate. Name: {0} (having {1} skills)",
                getUser2.Name, getUser2.Skills.Count);
            }


            _userRepo.DeleteAll();
            Debug.WriteLine("After delete all....");
            ShowAllUsers(currentInDb);

        }

        private void ShowAllUsers(IEnumerable<User> allUsers )
        {
            foreach (var user in allUsers)
            {
                Debug.WriteLine("Debug : User name = " + user.Name);
                Debug.WriteLine("Debug : User age = " + user.Age);
                Debug.WriteLine("Debug : User has {0} skills = ", user.Skills.Count );
                foreach (var userSkill in user.Skills)
                {
                    Debug.WriteLine("Debug : User skill = " + userSkill.Name);
                }
                Debug.WriteLine("-------");
                
            }
        }
    }
}