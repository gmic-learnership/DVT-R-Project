﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DvtRecruitEntities : DbContext
    {
        public DvtRecruitEntities()
            : base("name=DvtRecruitEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ApplicantContract> ApplicantContracts { get; set; }
        public DbSet<ApplicantInfo> ApplicantInfoes { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<BackgroundCheck> BackgroundChecks { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<NextOfKin> NextOfKins { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<ProjectSynopsi> ProjectSynopsis { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
