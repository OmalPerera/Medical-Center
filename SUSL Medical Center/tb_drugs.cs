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
    
    public partial class tb_drugs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_drugs()
        {
            this.tb_prescription = new HashSet<tb_prescription>();
        }
    
        public int drug_id { get; set; }
        public string drug_code { get; set; }
        public string drug_name { get; set; }
        public int drug_availabale_qty { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_prescription> tb_prescription { get; set; }
    }
}