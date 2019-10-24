using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class UserManager
    {
        private static int CurrentId = 1000;
        private static List<User> Users = new List<User>();

        public UserManager()
        {

        }
        public List<User> GetAll()
        {
            return Users;
        }

        public User GetByEmailAndPassword(string email, string password)
        {
            var user = Users.Find(u => u.Email == email && u.Password == password);

            return user;
        }

        public User Create(User user)
        {
            user.Id = CurrentId;
            Users.Add(user);
            CurrentId++;

            return user;
        }

        public User GetByEmail(string email)
        {
            var user = Users.Find(u => u.Email == email);

            return user;
        }
        public User GetById(int Id)
        {
            var user = Users.Find(u => u.Id == Id);

            return user;
        }

        public void Delete(int id)
        {
            var user = Users.Find(u => u.Id == id);
            Users.Remove(user);
        }

        public void Update(User user)
        {
            var currentUser = Users.Find(u => u.Id == user.Id);
            currentUser.Email = user.Email;
            currentUser.Password = user.Password;
        }
        // STUB data 
        // dummy data
        public void Seed()
        {
            Users.Add(new User()
            {
                Id = 1,
                Email = "email1@email.com",
                Password = "pass1"
            });

            Users.Add(new User()
            {
                Id = 2,
                Email = "email2@email.com",
                Password = "pass2"
            });
        }
    }
}
