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
    
    public partial class Configuration
    {
        public int AccountDefaultID { get; set; }
        public short AccountMonthlyClosingDay { get; set; }
        public int CostUpdateMethod { get; set; }
        public Nullable<System.DateTime> HQCreationDate { get; set; }
        public Nullable<System.DateTime> LastBackupMessage { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public float LayawayDeposit { get; set; }
        public double LimitItem { get; set; }
        public decimal LimitPurchase { get; set; }
        public int LimitTimeFrame { get; set; }
        public int LimitType { get; set; }
        public string SerialNumber { get; set; }
        public string StoreCountry { get; set; }
        public int StoreID { get; set; }
        public string StoreState { get; set; }
        public int SyncID { get; set; }
        public int TaxSystem { get; set; }
        public string VATRegistrationNumber { get; set; }
        public int ID { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress1 { get; set; }
        public string StoreAddress2 { get; set; }
        public string StoreCity { get; set; }
        public string StoreZip { get; set; }
        public string StorePhone { get; set; }
        public string StoreFax { get; set; }
        public short QuoteExpirationDays { get; set; }
        public short BackOrderExpirationDays { get; set; }
        public short LayawayExpirationDays { get; set; }
        public short WorkOrderDueDays { get; set; }
        public decimal LayawayFee { get; set; }
        public int ReceiptCount { get; set; }
        public int ReceiptCount2 { get; set; }
        public int EDCTimeout { get; set; }
        public double WorkOrderDeposit { get; set; }
        public int PriceCalculationRule { get; set; }
        public int Options { get; set; }
        public string StoreEmail { get; set; }
        public int TaxBasis { get; set; }
        public int TaxField { get; set; }
        public int ItemTaxID { get; set; }
        public byte[] DBTimeStamp { get; set; }
        public int DefaultTenderID { get; set; }
        public int Options2 { get; set; }
        public int VoucherExpirationDays { get; set; }
        public bool EnableGlobalCustomers { get; set; }
        public bool DefaultGlobalCustomer { get; set; }
        public string SoftwareValidation1 { get; set; }
        public string SoftwareValidation2 { get; set; }
        public string SoftwareValidation3 { get; set; }
        public string SoftwareValidation4 { get; set; }
        public string SoftwareValidation5 { get; set; }
        public string VATDetailID { get; set; }
        public int Options3 { get; set; }
        public int Options4 { get; set; }
        public int NextAutoAccountNumber { get; set; }
        public int AccountingInterface { get; set; }
        public string BillPostingAccount { get; set; }
        public string AccountingFilename { get; set; }
        public string AccountingCompany { get; set; }
        public bool PasswordExpireCheck { get; set; }
        public int PasswordWillExpire { get; set; }
        public int ReminderPeriod { get; set; }
        public int KeepPasswordHistory { get; set; }
        public bool AccountLockedCheck { get; set; }
        public int LockOutAttempts { get; set; }
        public int LockOutPeriod { get; set; }
        public bool ComplexityRequired { get; set; }
        public int PasswordLength { get; set; }
        public int NoOfUpperCase { get; set; }
        public int NoOfNumeric { get; set; }
        public int NoOfSpecialChar { get; set; }
        public int DefaultDistributionMethod { get; set; }
        public bool UseLandedCost { get; set; }
        public double BackorderDeposit { get; set; }
        public string NumberFormat { get; set; }
        public string NextNumber { get; set; }
        public bool useAutonumberConfig { get; set; }
    }
}
