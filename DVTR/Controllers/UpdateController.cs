using DVTR.DVTR.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DVTR.Controllers
{
    public class UpdateController : Controller
    {
        DvtRecruitEntities dbContext = new DvtRecruitEntities();
        // GET: Update
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UpdatePerson()
        {
            Person user = null;
            int num = Convert.ToInt32(Session["Username"]);
            List<Person> userID = (from x in dbContext.People where x.UserId ==num select x).ToList();
            foreach (var item in userID)
            {
                user = dbContext.People.Find(item.PersonId);
            }
           
            return View(user);
        }
        [HttpPost]
        public ActionResult UpdatePerson(Person person)
        {
            if (ModelState.IsValid)
            {
                dbContext.Entry(person).State = EntityState.Modified;
                dbContext.SaveChanges();

            }

            return View();
        }

        public ActionResult UpdateEducation()
        {
            Education user = null;
            int num = Convert.ToInt32(Session["Username"]);
            List<Education> userID = (from x in dbContext.Educations where x.PersonId == num select x).ToList();
            foreach (var item in userID)
            {
                user = dbContext.Educations.Find(item.PersonId);
            }
            return View(user);

        }
        [HttpPost]
        public ActionResult UpdateEducation(Education edu)
        {
            if (ModelState.IsValid)
            {
                dbContext.Entry(edu).State = EntityState.Modified;
                dbContext.SaveChanges();

            }
            return View();

        }


        public ActionResult ApplicantInformation()
        {

            ApplicantInfo  user = null;
            int num = Convert.ToInt32(Session["Username"]);
            List<ApplicantInfo> userID = (from x in dbContext.ApplicantInfoes  where x.PersonId == num select x).ToList();
            foreach (var item in userID)
            {
                user = dbContext.ApplicantInfoes.Find(item.ApplicantInfoId);
            }
            return View(user);
        }


        [HttpPost ]
        public ActionResult ApplicantInformation(ApplicantInfo applicantinfo)
        {

            if (ModelState.IsValid)
            {
                dbContext.Entry(applicantinfo).State = EntityState.Modified;
                dbContext.SaveChanges();

            }
            return View();
        }


        public ActionResult ProjectSynopsis()
        {
            ProjectSynopsi  user = null;
            int num = Convert.ToInt32(Session["Username"]);
            List<ProjectSynopsi > userID = (from x in dbContext.ProjectSynopsis  where x.PersonId == num select x).ToList();
            foreach (var item in userID)
            {
                user = dbContext.ProjectSynopsis.Find(item.ProjectSynopsisId );
            }
            return View(user);
           
        }

        [HttpPost ]
        public ActionResult ProjectSynopsis(ProjectSynopsi project)
        {

            if (ModelState.IsValid)
            {
                dbContext.Entry(project ).State = EntityState.Modified;
                dbContext.SaveChanges();

            }
            return View();
        }

        public ActionResult NextOfKin()
        {
            NextOfKin user = null;
            int num = Convert.ToInt32(Session["Username"]);
            List<NextOfKin> userID = (from x in dbContext.NextOfKins where x.PersonId == num select x).ToList();
            foreach (var item in userID)
            {
                user = dbContext.NextOfKins.Find(item.NextOfKinId);
            }
            return View(user);

        }

        [HttpPost]
        public ActionResult NextOfKin(NextOfKin nextOfKin)
        {

            if (ModelState.IsValid)
            {
                dbContext.Entry(nextOfKin).State = EntityState.Modified;
                dbContext.SaveChanges();

            }
            return View();
        }

    }
}