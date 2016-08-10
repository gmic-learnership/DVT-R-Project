using DVTR.BL;
using DVTR.DVTR.DAL;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Security;
using System.Linq;

namespace DVTR.Controllers
{
    public class HomeController : Controller
    {
        DvtRecruitEntities dbContext = new DvtRecruitEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmploymentType()
        {
            return View();
        }


        public ActionResult Person()
        {
            return View();
        }

        public ActionResult NextOfKin()
        {
            return View();
        }

        public ActionResult ProjectSynopsis()
        {
            return View();
        }

        public ActionResult References()
        {
            return View();
        }




        public ActionResult DvtForm()
        {
            return View();
        }

        public ActionResult ApplicantInfo()
        {
            return View();
        }

        public ActionResult ApplicantContract()
        {
            return View();
        }

        public ActionResult Application()
        {
            return View();
        }

        public ActionResult BackgroundCheck()
        {
            return View();
        }

        public ActionResult Education()
        {
            return View();
        }


        public ActionResult NectOfKin()
        {
            return View();
        }


        // GET: /User/ 
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]

        [ValidateAntiForgeryToken]

        public ActionResult Register(User U)

        {
            using (DvtRecruitEntities dc = new DvtRecruitEntities())
            {

                if (ModelState.IsValid)

                {

                    dc.Users.Add(U);

                    dc.SaveChanges();

                    //ModelState.Clear();

                    //U = null;

                    ViewBag.Message = "Successfully Registration Done";

                }
                return RedirectToAction("Index");
            }
        }
        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult login(User Getuser, string returnUrl1)
        {
            
                List<User> mylist = LoginMethod.GetUserPassword(Getuser.Password,Getuser.UserName);

              
                foreach (var item in mylist)
                {
                    if (string.IsNullOrEmpty(item.UserName))
                    {
                        ModelState.AddModelError("", "Incorrect username ");
                    }
                    else
                    {
                        if (Getuser.Password.Equals(item.Password))
                        {
                            FormsAuthentication.SetAuthCookie(Getuser.UserName, false);

                            Session["Username"] =item.UserId;
                            return RedirectToAction("LoggedInMenu");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Incorrect password ");
                        }
                    }
                
            }
            return View(Getuser);
        }

        [HttpGet]
        public ActionResult RetrieveInformation()
        {
           
            User user = dbContext.Users.Find( Session["Username"]);
            return View(user);

        }

        public ActionResult LoggedInMenu()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UpdateMainMenu()
        {
            return View();
        }

    }

}