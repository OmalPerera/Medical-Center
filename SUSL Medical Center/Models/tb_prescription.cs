//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tb_prescription
    {
        public int presc_id { get; set; }
        public string presc_code { get; set; }
        public System.DateTime presc_date { get; set; }
        public string presc_stu_reg_no { get; set; }
        public string presc_drus_Issued { get; set; }
    
        public virtual tb_drugs tb_drugs { get; set; }
        public virtual tb_student tb_student { get; set; }
    }
}
