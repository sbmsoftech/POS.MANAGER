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
    
    public partial class QuoteTenderEntry
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int TenderID { get; set; }
        public string CreditCardExpiration { get; set; }
        public string CreditCardNumber { get; set; }
        public string CreditCardApprovalCode { get; set; }
        public decimal Amount { get; set; }
        public decimal RoundingError { get; set; }
        public string AccountHolder { get; set; }
        public byte[] DBTimeStamp { get; set; }
    }
}