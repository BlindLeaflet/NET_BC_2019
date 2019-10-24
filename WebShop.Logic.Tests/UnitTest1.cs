using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebShop.Logic.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetAllUsers()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            var result = manager.GetAll();

            Assert.AreEqual("email1@email.com", result[0].Email);
            Assert.AreEqual("email2@email.com", result[1].Email);
            Assert.AreEqual("pass1", result[0].Password);
            Assert.AreEqual("pass2", result[1].Password);
            Assert.AreEqual(1, result[0].Id);
            Assert.AreEqual(2, result[1].Id);            
            Assert.AreEqual(2, result.Count);
        }
        [TestMethod]
        public void TestGetAllCategories()
        {
            CategoryManager manager = new CategoryManager();
            manager.Seed();

            var result = manager.GetAll();

            Assert.AreEqual("Title 1", result[0].Title);
            Assert.AreEqual(2, result.Count);
        }
        [TestMethod]
        public void TestGetCategory()
        {
            CategoryManager manager = new CategoryManager();
            manager.Seed();

            Category category1 = manager.Get(1);
            Category category2 = manager.Get(2);
            Category category3 = manager.Get(3);

            Assert.AreEqual("Title 1", category1.Title);
            Assert.AreEqual("Title 2", category2.Title);
            Assert.IsNull(category3);
        }
        [TestMethod]
        public void TestGetByEmailAndPasswordUser()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            User user1 = manager.GetByEmailAndPassword("email1@email.com","pass1");
            User user2 = manager.GetByEmailAndPassword("email2@email.com", "pass2");
            User user3 = manager.GetByEmailAndPassword("email3@email.com", "pass3");


            Assert.AreEqual("email1@email.com", user1.Email);
            Assert.AreEqual("email2@email.com", user2.Email);
            Assert.AreEqual("pass1", user1.Password);
            Assert.AreEqual("pass2", user2.Password);
            Assert.AreEqual(1, user1.Id);
            Assert.AreEqual(2, user2.Id);
            Assert.IsNull(user3);
        }
        [TestMethod]
        public void TestCreateUser()
        {
            UserManager manager = new UserManager();
            User user = manager.Create(new User()
            {
                Email = "newEmail@email.com",
                Password= "newPassword"
            });

            Assert.AreEqual("newEmail@email.com", user.Email);
            Assert.AreEqual("newPassword", user.Password);
            Assert.IsTrue(user.Id > 0);
        }
        [TestMethod]
        public void TestGetByEmailUser()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            User user1 = manager.GetByEmail("email1@email.com");
            User user2 = manager.GetByEmail("email2@email.com");
            User user3 = manager.GetByEmail("email3@email.com");

            Assert.AreEqual("email1@email.com", user1.Email);
            Assert.AreEqual("email2@email.com", user2.Email);
            Assert.AreEqual("pass1", user1.Password);
            Assert.AreEqual("pass2", user2.Password);
            Assert.AreEqual(1, user1.Id);
            Assert.AreEqual(2, user2.Id);
            Assert.IsNull(user3);
        }
        [TestMethod]
        public void TestGetByIdUser()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            User user1 = manager.GetById(1);
            User user2 = manager.GetById(2);
            User user3 = manager.GetById(3);

            Assert.AreEqual("email1@email.com", user1.Email);
            Assert.AreEqual("email2@email.com", user2.Email);
            Assert.AreEqual("pass1", user1.Password);
            Assert.AreEqual("pass2", user2.Password);
            Assert.AreEqual(1, user1.Id);
            Assert.AreEqual(2, user2.Id);
            Assert.IsNull(user3);
        }
        [TestMethod]
        public void TestDeleteUser()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            manager.Delete(1);

            var allUsers = manager.GetAll();
            var deletedUser = manager.GetById(1);

            Assert.AreEqual(1, allUsers.Count);
            Assert.IsNull(deletedUser);
        }
        [TestMethod]
        public void TestUpdateUser()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            manager.Update(new User()
            {
                Id = 2,
                Email = "newEmail2@email.com",
                Password = "newPassword2"
            });

            var user = manager.GetById(2);

            Assert.AreEqual(2, user.Id);
            Assert.AreEqual("newEmail2@email.com", user.Email);
            Assert.AreEqual("newPassword2", user.Password);
        }
        
        
    }
}
