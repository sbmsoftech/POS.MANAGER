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
    
    public partial class Journal
    {
        public int ID { get; set; }
        public int StoreID { get; set; }
        public System.DateTime Time { get; set; }
        public int TransactionType { get; set; }
        public int ReferenceID { get; set; }
        public int CashierID { get; set; }
        public int CustomerID { get; set; }
        public int OrderHistoryID { get; set; }
        public int BatchNumber { get; set; }
        public string ReceiptText { get; set; }
        public byte[] DBTimeStamp { get; set; }
        public bool Compressed { get; set; }
        public byte[] ReceiptCompressed { get; set; }
    }
}