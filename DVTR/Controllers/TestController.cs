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
    public class TestController : Controller
    {
        DvtRecruitEntities db = new DvtRecruitEntities();
        InsertRepo rep = new InsertRepo();

        // GET: Test
        public ActionResult Index()
        {

            return View();
        }
        InsertRepo ins = new InsertRepo();
        

        

        public ActionResult SavePerson()
        {
            return View("Person",new Person());
            
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
            catch (Exception ex)
            {

                throw ex;
            }
            
            return SavePerson();
        }

        public ActionResult SaveApplicantInfo()
        {
            var personId = Session["personId"];
            return View("ApplicantInfo",new ApplicantInfo());
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
            return View("ApplicantContract",new ApplicantContract());
        }

        [HttpPost]
        public ActionResult SaveContract(ApplicantContract applicantContract)
        {
            Session["applicantContract"] = applicantContract;
            try
            {
                if (ModelState.IsValid)
                {
                    applicantContract.PersonId =21;
                    rep.InsertApplicantContract(applicantContract);
                   rep.Save();
                    return RedirectToAction("SaveEducation");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return SavePerson();
        }

        public ActionResult SaveEducation()
        {
            return View("Education",new Education());
        }

        [HttpPost]
        public ActionResult SaveEducation(Education education)
        {
            Session["education"] = education;
            try
            {
                if (ModelState.IsValid)
                {
                    education.PersonId =21;
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
            return View("NextOfKin", new NextOfKin());
        }

        [HttpPost]
        public ActionResult SaveNextOfKin(NextOfKin nextOfKin)
        {
            Session["nextOfKin"] = nextOfKin;
            try
            {
                if (ModelState.IsValid)
                {
                    nextOfKin.PersonId = 21;
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
            return View("References", new Reference());
        }

        [HttpPost]
        public ActionResult SaveReference(Reference reference)
        {
            Session["reference"] = reference;
            try
            {
                if (ModelState.IsValid)
                {
                    reference.PersonId = 21;
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
            return View("BackgroundChecks", new BackgroundCheck());
        }

        [HttpPost]
        public ActionResult SaveBackgroundCheck(BackgroundCheck backgroundCheck)
        {
            Session["backgroundCheck"] = backgroundCheck;
            try
            {
                if (ModelState.IsValid)
                {
                    backgroundCheck.PersonId =21;
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
            return View("ProjectSynopsis", new ProjectSynopsi());
        }

        [HttpPost]
        public ActionResult SaveProjectSynopsis(ProjectSynopsi projectSynopsis)
        {
            Session["projectSynopsis"] = projectSynopsis;
            try
            {
                if (ModelState.IsValid)
                {
                    projectSynopsis.PersonId = 21;
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