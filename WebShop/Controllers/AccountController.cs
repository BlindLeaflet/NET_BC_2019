using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Logic;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(RegisteredUserModel model)
        {
            if (ModelState.IsValid)
            {
                UserManager manager = new UserManager();
                var user = manager.GetByEmail(model.Email);
                if (user == null)
                {
                    ModelState.AddModelError("error", "Account does not exist");
                }
                else if (manager.GetByEmailAndPassword(model.Email, model.Password) == null)
                {
                    ModelState.AddModelError("error", "Incorrect password");
                }
                else
                {
                    TempData["message"] = "Login succesful";
                    return RedirectToAction("SignIn");
                }
                if (user==null)
                {
                    ModelState.AddModelError("error", "Invalid email/password!");
                }
                else
                {
                    HttpContext.Session.SetInt32("userId");
                    HttpContext.Session.SetInt32("userId");
                }
                

            }
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {
            if (ModelState.IsValid)
            {
                UserManager manager = new UserManager();
                if (manager.GetByEmail(model.Email) !=null)
                {
                    ModelState.AddModelError("error", "Email already exists!");
                }
                else
                {
                    manager.Create(new Logic.User()
                    {
                        Email=model.Email,
                        Password=model.Password
                    });

                    TempData["message"] = "Account created!";
                    return RedirectToAction("SignIn");
                }                
            }            
            
            return View();
        }

    }
}