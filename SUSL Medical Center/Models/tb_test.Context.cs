﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SUSL_Medical_Center.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class susl_medicalEntities1 : DbContext
    {
        public susl_medicalEntities1()
            : base("name=susl_medicalEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_drugs> tb_drugs { get; set; }
        public virtual DbSet<tb_prescription> tb_prescription { get; set; }
        public virtual DbSet<tb_student> tb_student { get; set; }
        public virtual DbSet<tb_test> tb_test { get; set; }
    }
}
