using DVTR.DVTR.BL;
using DVTR.DVTR.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DVTR.Controllers
{
    public class ApplicationController : Controller
    {
        DvtRecruitEntities db = new DvtRecruitEntities();
        InsertRepo rep = new InsertRepo();
        // GET: Application

        public ActionResult SavePerson()
        {
            ViewBag.GenderId = new SelectList(db.Genders, "GenderId", "Gender1");
            ViewBag.RaceId = new SelectList(db.Races, "RaceId", "Race1");
            return View("SavePerson", new Person());

        }

        [HttpPost]
        public ActionResult SavePerson(Person person)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    person.UserId = 2;
                    //person.PersonId = 2;
                    rep.InsertPerson(person);
                    rep.Save();
                    var personId = person.PersonId;
                    Session["personId"] = personId;
                    return RedirectToAction("SaveApplicantInfo");
                }
            }
            catch (DbEntityValidationException dbEx)
            {

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                                                validationError.PropertyName,
                                                validationError.ErrorMessage);
                    }
                }
            }

            return SavePerson();
        }

        public ActionResult SaveApplicantInfo()
        {
            var personId = Session["personId"];
            return View("SaveApplicantInfo", new ApplicantInfo());
        }

        [HttpPost]
        public ActionResult SaveApplicantInfo(ApplicantInfo applicantInfo)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    //applicantInfo.PersonId = 21;
                    var personId = Session["personId"];
                    applicantInfo.PersonId = Convert.ToInt32(personId);
                    rep.InsertApplicantInfo(applicantInfo);
                    rep.Save();
                    return RedirectToAction("SaveContract");
                }
            }
            catch (DbEntityValidationException dbEx)
            {

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                                                validationError.PropertyName,
                                                validationError.ErrorMessage);
                    }
                }
            }
            return SaveApplicantInfo();
        }

        public ActionResult SaveContract()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveContract(ApplicantContract applicantContract)
        {
            Session["applicantContract"] = applicantContract;
           

                var personId = Session["personId"];
                applicantContract.PersonId = Convert.ToInt32(personId);
                rep.InsertApplicantContract(applicantContract);
                rep.Save();
                return RedirectToAction("SaveEducation");
         
         
        }

        public ActionResult SaveEducation()
        {
            return View("SaveEducation", new Education());
        }

        [HttpPost]
        public ActionResult SaveEducation(Education education)
        {
            Session["education"] = education;
            try
            {
                if (ModelState.IsValid)
                {
                    var personId = Session["personId"];
                    education.PersonId = Convert.ToInt32(personId);
                    rep.InsertEducation(education);
                    rep.Save();
                    return RedirectToAction("SaveNextOfKin");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return SavePerson();
        }

        public ActionResult SaveNextOfKin()
        {
            return View("SaveNextOfKin", new NextOfKin());
        }

        [HttpPost]
        public ActionResult SaveNextOfKin(NextOfKin nextOfKin)
        {
            Session["nextOfKin"] = nextOfKin;
            try
            {
                if (ModelState.IsValid)
                {
                    var personId = Session["personId"];
                    nextOfKin.PersonId = Convert.ToInt32(personId);
                    rep.InsertNextOfKin(nextOfKin);
                    rep.Save();
                    return RedirectToAction("SaveReference");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return SavePerson();
        }

        public ActionResult SaveReference()
        {
            return View("SaveReference", new Reference());
        }

        [HttpPost]
        public ActionResult SaveReference(Reference reference)
        {
            Session["reference"] = reference;
            try
            {
                if (ModelState.IsValid)
                {
                    var personId = Session["personId"];
                    reference.PersonId = Convert.ToInt32(personId);
                    rep.InsertReference(reference);
                    rep.Save();
                    return RedirectToAction("SaveBackgroundCheck");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return SavePerson();
        }

        public ActionResult SaveBackgroundCheck()
        {
            return View("SaveBackgroundCheck", new BackgroundCheck());
        }

        [HttpPost]
        public ActionResult SaveBackgroundCheck(BackgroundCheck backgroundCheck)
        {
            Session["backgroundCheck"] = backgroundCheck;
            try
            {
                if (ModelState.IsValid)
                {
                    var personId = Session["personId"];
                    backgroundCheck.PersonId = Convert.ToInt32(personId);
                    rep.InsertBackgroundCheck(backgroundCheck);
                    rep.Save();
                    return RedirectToAction("SaveProjectSynopsis");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return SavePerson();
        }

        public ActionResult SaveProjectSynopsis()
        {
            return View("SaveProjectSynopsis", new ProjectSynopsi());
        }

        [HttpPost]
        public ActionResult SaveProjectSynopsis(ProjectSynopsi projectSynopsis)
        {
            Session["projectSynopsis"] = projectSynopsis;
            try
            {
                if (ModelState.IsValid)
                {
                    var personId = Session["personId"];
                    projectSynopsis.PersonId = Convert.ToInt32(personId);
                    rep.InsertProjectSynopsis(projectSynopsis);
                    rep.Save();
                    return RedirectToAction("Done");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return SaveProjectSynopsis();
        }

        public ActionResult Done()
        {

            return View();
        }
    }
}