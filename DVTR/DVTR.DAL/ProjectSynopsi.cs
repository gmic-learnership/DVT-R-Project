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
    
    public partial class ProjectSynopsi
    {
        public int ProjectSynopsisId { get; set; }
        public string Company { get; set; }
        public string ProjectDescription { get; set; }
        public string RoleOnProject { get; set; }
        public int ProjectDuration { get; set; }
        public string PrimaryStakeholders { get; set; }
        public string ArtifactsProdused { get; set; }
        public string Methodologies { get; set; }
        public string TaskResponsibility { get; set; }
        public int PersonId { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
