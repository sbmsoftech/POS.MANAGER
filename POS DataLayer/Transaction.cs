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
    
    public partial class Transaction
    {
        public int ShipToID { get; set; }
        public int StoreID { get; set; }
        public int TransactionNumber { get; set; }
        public int BatchNumber { get; set; }
        public System.DateTime Time { get; set; }
        public int CustomerID { get; set; }
        public int CashierID { get; set; }
        public decimal Total { get; set; }
        public decimal SalesTax { get; set; }
        public string Comment { get; set; }
        public string ReferenceNumber { get; set; }
        public byte[] DBTimeStamp { get; set; }
        public int Status { get; set; }
        public int ExchangeID { get; set; }
        public int ChannelType { get; set; }
        public int RecallID { get; set; }
        public int RecallType { get; set; }
    }
}
