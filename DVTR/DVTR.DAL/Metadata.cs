using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DVTR.Models
{
    public class UserMetadata
    {
        [Required]
        public int UserId { get; set; }
       
        [StringLength(50), Required]
        public string FirstName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [Required]
        [Display(Name ="UserName")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Password must be numeric")]
      //  [Range(6,12,ErrorMessage = "Please enter password range that is between 6 and 12")]
        public string Password { get; set; }
    }

    public class PersonMetadata
    {
        [Required]
        public int PersonId { get; set; }
        [Display(Name ="Maiden name")]
        public string Maidenname { get; set; }
        [Required]
        [Display(Name ="Full name")]
        public string Fullname { get; set; }
        [Required]
        [Display(Name ="Surname")]
        public string Surname { get; set; }
        [Required]
        //[Range(1000000000000,9999999999999, ErrorMessage ="Identity number is only 13 digits!")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "ID must be numeric")]
        public int IdentityNumber { get; set; }
        [Required]
        [DataType(DataType.Date), ]
        [DisplayFormat(DataFormatString ="{YYYY/MM/dd}")]
        public System.DateTime DateOfBirth { get; set; }
        [Required]
       // [RegularExpression("^[0-9]*$", ErrorMessage = "Cellphone must be numeric")]
        [Range(0000000000,9999999999, ErrorMessage ="Must be 10 digits")]
        public string CellNumber { get; set; }
        [Required]
        public string HomeLanguage { get; set; }
        [Required]
        public string PhysicalAddress { get; set; }
        [Required]
        [Range(1000,9999, ErrorMessage ="Postal code is four characters long")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Postal code must be numeric")]
        [Display(Name ="Postal Code")]
        public string PostalCode { get; set; }
        public string AlternativeNumber { get; set; }
        [Required]
        [Display(Name = "Gender")]
        public int GenderId { get; set; }
        [Required]
        [Display(Name ="Race")]
        public int RaceID { get; set; }
        [Required]
        public int UserId { get; set; }

    }   

    public class ApplicantContractMetadata
    {
        [Required]
        public int ApplicantContractId { get; set; }
        [Required]
        [Display(Name ="Current Gross Salary")]
        public decimal CurrentGrossSalary { get; set; }
        [Required]
        [Display(Name ="Current Performance Bonus")]
        public decimal CurrentPerformanceBonus { get; set; }
        [Required]
        [Display(Name ="Medical Aid Employer Contribution")]
        public decimal MedicalAidEmpContribution { get; set; }
        [Required]
        [Display(Name ="Medical Aid Individual Contribution")]
        public decimal MedicalAidIndContribution { get; set; }
        [Required]
        [Display(Name = "Provident/Pension Fund Employer Contribution")]
        public decimal ProvidentfundEmpContribution { get; set; }
        [Required]
        [Display(Name ="Provident/Pension Fund Individual Contribution")]
        public decimal ProvidentfundIndContribution { get; set; }
        [Required]
        [Display(Name ="Other(specify)")]
        public decimal OtherEmpContribution { get; set; }
        [Display(Name = "Other(specify)"), Required]
        public decimal OtherIndContribution { get; set; }
        [Required]
        [Display(Name ="Current Employment")]
        public int CurrentEmpTypeId { get; set; }
        [Required]
        [Display(Name = "Expected Employment")]
        public int ExpectedEmpTypeId { get; set; }
        [Required]
        public string NoticePeriod { get; set; }
        [Required]
        [Display(Name ="Permanent Salary Expectation")]
        public decimal PermanentSalaryExpectation { get; set; }
        [Required]
        [Display(Name ="Contract Salary Expectation")]
        public decimal ContractSalaryExpectation { get; set; }
        [Display(Name ="Have you recently sent your CV to any other companies? If yes, which companies?"),DataType(DataType.MultilineText)]
        public string RecentlySentCvToOtherComp { get; set; }
        [Required,Display(Name ="Interviews scheduled yet?")]
        public string InterviewsScheduled { get; set; }
        [Required,Display(Name ="Reasons for leaving current company?"),DataType(DataType.MultilineText)]
        public string ReasonLeavingCurrentComp { get; set; }
        [Required,Display(Name ="Do ypu prefer a Structured or Unstructured environment?")]
        public string PreferredEnvironment { get; set; }
        [Required]
        public int PersonId { get; set; }
    }

    public class ApplicationInfoMetadata
    {
        [Required]
        public int ApplicationInfoId { get; set; }
        [Required, Display(Name = "Work Permit Number")]
        public string WorkPermitNumber { get; set; }
        [Required, Display(Name = "Work Permit End Date")]
        public System.DateTime WorkPermitEndDate { get; set; }
        [Required]
        public string Health { get; set; }
        [Required, Display(Name = "Drivers License")]
        public string DriversLicense { get; set; }
        [Required, Display(Name = "Own Transport")]
        public string OwnTransport { get; set; }
        [Required, Display(Name = "Other Languages")]
        public string OtherLanguages { get; set; }
        [Required, Display(Name = "Current Work Location")]
        public string CurrentWorkLocation { get; set; }
        [Required, Display(Name = "Current Job Title")]
        public string CurrentJobTitle { get; set; }
        [Required, Display(Name = "Preferred job Title")]
        public string PreferredJobTitle { get; set; }
        [Required, Display(Name = "JHB CBD")]
        public bool PrefJhbCbd { get; set; }
        [Required, Display(Name = "JHB North")]
        public bool PrefJhbNorth { get; set; }
        [Required, Display(Name = "JHB South")]
        public bool PrefJhbSouth { get; set; }
        [Required, Display(Name = "JHB West")]
        public bool PrefJhbWest { get; set; }
        [Required, Display(Name = "Midrand")]
        public bool PrefMidrand { get; set; }
        [Required, Display(Name = "Pretoria")]
        public bool PrefPretoria { get; set; }
        [Required, Display(Name = "willing to relocate within RSA?")]
        public bool RelocateRsa { get; set; }
        [Required, Display(Name = "Will you consider relocate to the UK, Singapore or The Middle East for long term assignments(2 years and longer")]
        public bool RelocateInternational { get; set; }
        [Required]
        public int PersonId { get; set; }
    }

    public class EducationMetadata
    {
        [Required]
        public int EducationId { get; set; }
        [Required, Display(Name = "Qualification")]
        public string EducationType { get; set; }
        [Required, Display(Name = "Institution")]
        public string Institution { get; set; }
        [Required,Display(Name ="year Completed"), DataType(DataType.Date)]
        public System.DateTime YearCompleted { get; set; }
        [Required]
        public int PersonId { get; set; }
    }

    public class NextOfKinMetadata
    {
        [Required]
        public int NextOfKinId { get; set; }
        [Required, Display(Name = "Name & Surname")]
        public string NameSurname { get; set; }
        [Required, Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }
        [Required, Display(Name = "Relationship")]
        public string Relationship { get; set; }
        [Required]
        public int PersonId { get; set; }
    }

    public class ReferenceMetadata
    {
        [Required]
        public int ReferenceId { get; set; }
        [Required, Display(Name = "Name & Surname")]
        public string NameSurname { get; set; }
        [Required, Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }
        [Required, Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Required, Display(Name = "Report directly to referee")]
        public bool ReportDirectly { get; set; }
        [Required, Display(Name = "Referee Job Title")]
        public string ReferenceJobTitle { get; set; }
        [Required, Display(Name = "Candidate Job title")]
        public string CandidateJobTitle { get; set; }
        [Required, Display(Name = "Company")]
        public string Company { get; set; }
        [Required, Display(Name = "Period")]
        public string Period { get; set; }
        [Required]
        public int PersonId { get; set; }
    }

    public class BackgroundCheckMetadata
    {
        [Required]
        public int BackgroundCheckId { get; set; }
        [Required, Display(Name = "Do you have any current and/or previous conviction")]
        public bool Convictions { get; set; }
        [Display(Name = "Criminal Record")]
        public string CriminalRecord { get; set; }
        [Display(Name ="CCMA Case")]
        public string CcmaCase { get; set; }
        [Display(Name ="Fraud Case")]
        public string FraudCase { get; set; }
        [Display(Name ="Credit Record")]
        public string CreditRecord { get; set; }
        [Display(Name ="Other")]
        public string Other { get; set; }
        [Required]
        public int PersonId { get; set; }
    }

    public class ProjectSynopsisMetadata
    {
        [Required]
        public int ProjectSynopsisId { get; set; }
        [Required, Display(Name = "Company")]
        public string Company { get; set; }
        [Required, Display(Name = "Project Description"), DataType(DataType.MultilineText)]
        public string ProjectDescription { get; set; }
        [Required, Display(Name = "Role on Project")]
        public string RoleOnProject { get; set; }
        [Required, Display(Name = "Project Duration(in months)")]
        public int ProjectDuration { get; set; }
        [Required, Display(Name = "Primary Stakeholders")]
        public string PrimaryStakeholders { get; set; }
        [Required, Display(Name = "Artifacts Produced")]
        public string ArtifactsProduced { get; set; }
        [Required, Display(Name = "Methodologies")]
        public string Methodologies { get; set; }
        [Required, Display(Name = "Tasks/responsibilty on the project")]
        public string TaskResponsibility { get; set; }
        [Required]
        public int PersonId { get; set; }
    }

}