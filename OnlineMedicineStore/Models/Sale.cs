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
    
    public partial class Sale
    {
        public int Sales_ID { get; set; }
        public Nullable<int> M_ID { get; set; }
        public Nullable<int> User_ID { get; set; }
        public int Quantity { get; set; }
        public System.DateTime Sale_Date { get; set; }
        public decimal Price { get; set; }
    
        public virtual Medicine Medicine { get; set; }
        public virtual User User { get; set; }
    }
}
