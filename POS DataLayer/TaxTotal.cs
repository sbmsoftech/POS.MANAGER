//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS_DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaxTotal
    {
        public int ID { get; set; }
        public System.DateTime Date { get; set; }
        public int StoreID { get; set; }
        public int BatchNumber { get; set; }
        public int TaxID { get; set; }
        public decimal Total { get; set; }
        public byte[] DBTimeStamp { get; set; }
    }
}
