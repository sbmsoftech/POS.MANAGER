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
    
    public partial class InventoryTransferLog
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public int DetailID { get; set; }
        public double Quantity { get; set; }
        public System.DateTime DateTransferred { get; set; }
        public int StoreID { get; set; }
        public byte[] DBTimeStamp { get; set; }
        public int ReferenceID { get; set; }
        public int ReasonCodeID { get; set; }
        public int CashierID { get; set; }
        public int Type { get; set; }
        public int ReferenceEntryID { get; set; }
        public decimal Cost { get; set; }
        public int BatchNumber { get; set; }
        public Nullable<double> ComputedQuantity { get; set; }
    }
}