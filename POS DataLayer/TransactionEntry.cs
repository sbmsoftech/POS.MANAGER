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
    
    public partial class TransactionEntry
    {
        public decimal Commission { get; set; }
        public decimal Cost { get; set; }
        public decimal FullPrice { get; set; }
        public int StoreID { get; set; }
        public int ID { get; set; }
        public int TransactionNumber { get; set; }
        public int ItemID { get; set; }
        public decimal Price { get; set; }
        public short PriceSource { get; set; }
        public double Quantity { get; set; }
        public int SalesRepID { get; set; }
        public bool Taxable { get; set; }
        public int DetailID { get; set; }
        public string Comment { get; set; }
        public byte[] DBTimeStamp { get; set; }
        public int DiscountReasonCodeID { get; set; }
        public int ReturnReasonCodeID { get; set; }
        public int TaxChangeReasonCodeID { get; set; }
        public decimal SalesTax { get; set; }
        public int QuantityDiscountID { get; set; }
        public int ItemType { get; set; }
        public Nullable<double> ComputedQuantity { get; set; }
        public Nullable<System.DateTime> TransactionTime { get; set; }
        public bool IsAddMoney { get; set; }
        public int VoucherID { get; set; }
    }
}
