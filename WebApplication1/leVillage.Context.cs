﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class leVillageEntities : DbContext
    {
        public leVillageEntities()
            : base("name=leVillageEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<BloodType> BloodTypes { get; set; }
        public virtual DbSet<Campu> Campus { get; set; }
        public virtual DbSet<CheckListCategory> CheckListCategories { get; set; }
        public virtual DbSet<ChurchHistory> ChurchHistories { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<EmploymentHistory> EmploymentHistories { get; set; }
        public virtual DbSet<EntryPoint> EntryPoints { get; set; }
        public virtual DbSet<Family> Families { get; set; }
        public virtual DbSet<FamilyRole> FamilyRoles { get; set; }
        public virtual DbSet<Industry> Industries { get; set; }
        public virtual DbSet<MaritalStatu> MaritalStatus { get; set; }
        public virtual DbSet<MaritalStatusType> MaritalStatusTypes { get; set; }
        public virtual DbSet<MedicalInfo> MedicalInfoes { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonPhoto> PersonPhotos { get; set; }
        public virtual DbSet<Profession> Professions { get; set; }
        public virtual DbSet<StatusHistory> StatusHistories { get; set; }
        public virtual DbSet<StudyLevel> StudyLevels { get; set; }
        public virtual DbSet<StudyLevelType> StudyLevelTypes { get; set; }
    }
}