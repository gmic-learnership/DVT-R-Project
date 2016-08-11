using DVTR.DVTR.BL;
using DVTR.DVTR.Core;
using DVTR.DVTR.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DVTR.Controllers
{
    public class UserController : Controller
    {
        DvtRecruitEntities db = new DvtRecruitEntities();
        UserRepository repo = new UserRepository();
        // GET: User
        public ActionResult Index()
        {
            //db = repo.GetUsers().ToList();
            return View();
        }

        public ActionResult SignUp(bool? failed)
        {
            User user = new DVTR.DAL.User();

            if (failed != null)
            {
                user.RegistrationFailed = true;
            }
            return View(user);
        }

        [HttpPost]
        public ActionResult SignUp(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        repo.AddUser(user);
                        repo.Save();
                        return RedirectToAction("SuccessMessage");
                    }
                    catch {
                        return RedirectToAction("SignUp", new { failed = true });
                    }
                }
            }
            catch (Exception )
            {             
            }
            return View(user);
        }

        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult login(User Getuser, string returnUrl1)
        {
            if (ModelState.IsValid)
            {
                string password = repo.GetUserPassword(Getuser.UserName);
                if (string.IsNullOrEmpty(password))
                {
                    ModelState.AddModelError("", "Incorrect username ");
                }

                else
                {
                    if (Getuser.Password.Equals(password))
                    {
                        FormsAuthentication.SetAuthCookie(Getuser.UserName, false);
                        return RedirectToAction("SavePerson","Application");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Incorrect password ");
                    }
                }
            }
            return View(Getuser);
        }

        public ActionResult SuccessMessage()
        {
            //string message = "You've successfully registered";
            //ViewBag.Message = 
            ViewBag.massage = "successfully registered";
           return View();
        }
    }
}