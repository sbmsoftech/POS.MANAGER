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
    
    public partial class AccountReceivableHistory
    {
        public int ID { get; set; }
        public int StoreID { get; set; }
        public int AccountReceivableID { get; set; }
        public int BatchNumber { get; set; }
        public decimal Amount { get; set; }
        public int PaymentID { get; set; }
        public string Comment { get; set; }
        public int CashierID { get; set; }
        public System.DateTime Date { get; set; }
        public byte[] DBTimeStamp { get; set; }
        public int HistoryType { get; set; }
        public int TransferArID { get; set; }
        public int ReasonCodeID { get; set; }
        public int RemoteStoreID { get; set; }
        public int RemotePaymentID { get; set; }
    }
}