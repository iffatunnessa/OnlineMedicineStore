//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineMedicineStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medicine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medicine()
        {
            this.Manages = new HashSet<Manage>();
            this.Sales = new HashSet<Sale>();
            this.Supply_Info = new HashSet<Supply_Info>();
        }
    
        public int M_ID { get; set; }
        public string Medicine_Name { get; set; }
        public decimal Price { get; set; }
        public string Company_Name { get; set; }
        public string Batch_No { get; set; }
        public System.DateTime Exp_Date { get; set; }
        public System.DateTime Mfg_date { get; set; }
        public string Type { get; set; }
        public string Prescription_Required { get; set; }
        public byte[] Image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Manage> Manages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supply_Info> Supply_Info { get; set; }
    }
}
