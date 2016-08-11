//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DVTR.DVTR.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public Person()
        {
            this.ApplicantContracts = new HashSet<ApplicantContract>();
            this.ApplicantInfoes = new HashSet<ApplicantInfo>();
            this.Applications = new HashSet<Application>();
            this.BackgroundChecks = new HashSet<BackgroundCheck>();
            this.Educations = new HashSet<Education>();
            this.NextOfKins = new HashSet<NextOfKin>();
            this.ProjectSynopsis = new HashSet<ProjectSynopsi>();
            this.References = new HashSet<Reference>();
        }
    
        public int PersonId { get; set; }
        public string Maidenname { get; set; }
        public string Fullname { get; set; }
        public string Surname { get; set; }
        public string IdentityNumber { get; set; }
        public int GenderId { get; set; }
        public int RaceID { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string CellNumber { get; set; }
        public string HomeLanguage { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalCode { get; set; }
        public string AlternativeNumber { get; set; }
        public int UserId { get; set; }
    
        public virtual ICollection<ApplicantContract> ApplicantContracts { get; set; }
        public virtual ICollection<ApplicantInfo> ApplicantInfoes { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<BackgroundCheck> BackgroundChecks { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual ICollection<NextOfKin> NextOfKins { get; set; }
        public virtual Race Race { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ProjectSynopsi> ProjectSynopsis { get; set; }
        public virtual ICollection<Reference> References { get; set; }
    }
}
