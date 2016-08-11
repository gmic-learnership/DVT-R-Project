using DVTR.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DVTR.DVTR.DAL
{
    [MetadataType(typeof(UserMetadata))]
    public  partial class User
    {
    }

    [MetadataType(typeof(PersonMetadata))]
    public partial class Person
    {
    }

    [MetadataType(typeof(ApplicantContractMetadata))]
    public partial class ApplicantContract
    {
    }

    [MetadataType(typeof(ApplicationInfoMetadata))]
    public partial class ApplicationInfo
    {
    }

    [MetadataType(typeof(EducationMetadata))]
    public partial class Education
    {
        public string addMoreFlag { get; set; }

        private List<Education> myEducationList;

        public List<Education> MyEducationList
        {
            get
            {
                if (myEducationList == null)
                {
                    myEducationList = new List<Education>();   
                }
                return myEducationList;
            }
            set { myEducationList = value; }
        }



        //public List<Education> myEducationList
        //{ get; set; }
    }

    [MetadataType(typeof(NextOfKinMetadata))]
    public partial class NextOfKin
    {
    }

    [MetadataType(typeof(ReferenceMetadata))]
    public partial class Reference
    {
    }

    [MetadataType(typeof(BackgroundCheckMetadata))]
    public partial class BackgroundCheck
    {
    }

    [MetadataType(typeof(ProjectSynopsisMetadata))]
    public partial class ProjectSynopsi
    {
    }
}