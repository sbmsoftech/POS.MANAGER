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
    
    public partial class ItemValueLog
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public double OldAmount { get; set; }
        public double NewAmount { get; set; }
        public string AmountType { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public int StoreID { get; set; }
        public byte[] DBTimeStamp { get; set; }
    }
}
