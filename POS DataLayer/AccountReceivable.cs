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
    
    public partial class AccountReceivable
    {
        public int ID { get; set; }
        public int StoreID { get; set; }
        public int CustomerID { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime DueDate { get; set; }
        public decimal OriginalAmount { get; set; }
        public int TransactionNumber { get; set; }
        public short Type { get; set; }
        public decimal Balance { get; set; }
        public byte[] DBTimeStamp { get; set; }
    }
}
