using DVTR.DVTR.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DVTR.DVTR.BL
{
    public class InsertRepo
    {


        DvtRecruitEntities db = new DvtRecruitEntities();

        public void Save()
        {
            db.SaveChanges();
        }

        public void InsertPerson(Person person)
        {
            
            db.People.Add(person);
        }

        public void InsertApplicantInfo(ApplicantInfo applicantInfo)
        {
            db.ApplicantInfoes.Add(applicantInfo);
        }

        public void InsertApplicantContract(ApplicantContract applicantContract)
        {
            db.ApplicantContracts.Add(applicantContract);
        }

        public void InsertEducation(Education education)
        {
            db.Educations.Add(education);
        }

        public void InsertNextOfKin(NextOfKin nextOfKin)
        {
            db.NextOfKins.Add(nextOfKin);
        }

        public void InsertReference(Reference reference)
        {
            db.References.Add(reference);
        }

        public void InsertBackgroundCheck(BackgroundCheck backgroundCheck)
        {
            db.BackgroundChecks.Add(backgroundCheck);
        }

        public void InsertProjectSynopsis(ProjectSynopsi projectSynopsis)
        {
            db.ProjectSynopsis.Add(projectSynopsis);
        }       

      
       
        
    }
}