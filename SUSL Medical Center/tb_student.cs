//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SUSL_Medical_Center
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_student()
        {
            this.tb_prescription = new HashSet<tb_prescription>();
        }
    
        public int stu_id { get; set; }
        public string stu_reg_number { get; set; }
        public string stu_first_name { get; set; }
        public string stu_last_name { get; set; }
        public Nullable<System.DateTime> stu_dob { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_prescription> tb_prescription { get; set; }
    }
}