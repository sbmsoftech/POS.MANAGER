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
    
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    
    public partial class Item
    {    


        public string I_BinLocation = "";
        public decimal I_BuydownPrice = 0;
        public double I_BuydownQuantity = 0;
        public decimal I_CommissionAmount = 0;
        public decimal I_CommissionMaximum = 0;
        public int I_CommissionMode = 0;
        public float I_CommissionPercentProfit = 0;
        public float I_CommissionPercentSale = 0;
        public string I_Description = "";
        public bool I_FoodStampable = false;
        public int I_HQID = 0;
        public bool I_ItemNotDiscountable = false;
        public string I_Notes = "";
        public double I_QuantityCommitted = 0;
        public int I_SerialNumberCount = 0;
        public double I_TareWeightPercent = 0;
        public int I_ID = 0;
        public string I_ItemLookupCode = "";
        public int I_DepartmentID = 0;
        public int I_CategoryID = 0;
        public int I_MessageID = 0;
        public decimal I_Price = 0;
        public decimal I_PriceA = 0;
        public decimal I_PriceB = 0;
        public decimal I_PriceC = 0;
        public decimal I_SalePrice = 0;
        public int I_QuantityDiscountID = 0;
        public int I_TaxID = 0;
        public short I_ItemType = 0;
        public decimal I_Cost = 0;
        public double I_Quantity = 0;
        public double I_ReorderPoint = 0;
        public double I_RestockLevel = 0;
        public double I_TareWeight = 0;
        public int I_SupplierID = 0;
        public int I_TagAlongItem = 0;
        public double I_TagAlongQuantity = 0;
        //public int I_ParentItem = _ParentItem;
        public double I_ParentQuantity = 0;
        public short I_BarcodeFormat = 0;
        public decimal I_PriceLowerBound = 0;
        public decimal I_PriceUpperBound = 0;
        public string I_PictureName = "";
        public string I_ExtendedDescription = "";
        public string I_SubDescription1 = "";
        public string I_SubDescription2 = "";
        public string I_SubDescription3 = "";
        public string I_UnitOfMeasure = "";
        public int I_SubCategoryID = 0;
        public bool I_QuantityEntryNotAllowed = false;
        public bool I_PriceMustBeEntered = false;
        public string I_BlockSalesReason = "";
        public double I_Weight = 0;
        public bool I_Taxable = false;
        public decimal I_LastCost = 0;
        public decimal I_ReplacementCost = 0;
        public bool I_WebItem = false;
        public int I_BlockSalesType = 0;
        public int I_BlockSalesScheduleID = 0;
        public int I_SaleType = 0;
        public int I_SaleScheduleID = 0;
        public bool I_Consignment = false;
        public bool I_Inactive = false;
        public bool I_DoNotOrder = false;
        public decimal I_MSRP = 0;
        public string I_Content = "";
        public string I_UsuallyShip = "";
        public string I_NumberFormat = "";
        public bool? I_ItemCannotBeRet = false;
        public bool? I_ItemCannotBeSold = false;
        public bool? I_IsAutogenerated = false;
        public bool I_IsGlobalvoucher = false;
        public bool? I_DeleteZeroBalanceEntry = false;
        public int I_TenderID = 0;
        public int I_ParentItem = 0;


        public DateTime? I_LastReceived = DateTime.Now;
        public DateTime I_LastUpdated = DateTime.Now;

        public DateTime? I_SaleStartDate = DateTime.Now;
        public DateTime? I_SaleEndDate = DateTime.Now;
        public DateTime? I_LastSold = DateTime.Now;
        public DateTime? I_BlockSalesAfterDate = DateTime.Now;
        public DateTime? I_BlockSalesBeforeDate = DateTime.Now;
        public DateTime? I_LastCounted = DateTime.Now;
        public DateTime I_DateCreated = DateTime.Now;

        [DefaultValue("")]
        public string BinLocation { get { return I_BinLocation; } set { I_BinLocation = value; } }
       
        public decimal BuydownPrice { get { return I_BuydownPrice; } set { I_BuydownPrice = value; } }
        
        public double BuydownQuantity { get { return I_BuydownQuantity; } set { I_BuydownQuantity = value; } }
        
        public decimal CommissionAmount { get { return I_CommissionAmount; } set { I_CommissionAmount = value; } }
        
        public decimal CommissionMaximum { get { return I_CommissionMaximum; } set { I_CommissionMaximum = value; } }
       
        public int CommissionMode { get { return I_CommissionMode; } set { I_CommissionMode = value; } }
        
        public float CommissionPercentProfit { get { return I_CommissionPercentProfit; } set { I_CommissionPercentProfit = value; } }
        
        public float CommissionPercentSale { get { return I_CommissionPercentSale; } set { I_CommissionPercentSale = value; } }
        [DefaultValue("")]
        public string Description { get { return I_Description; } set { I_Description = value; } }
        [DefaultValue(false)]
        public bool FoodStampable { get { return I_FoodStampable; } set { I_FoodStampable = value; } }
        
        public int HQID { get { return I_HQID; } set { I_HQID = value; } }
        [DefaultValue(false)]
        public bool ItemNotDiscountable { get { return I_ItemNotDiscountable; } set { I_ItemNotDiscountable = value; } }
        [DefaultValue(null)]
        public Nullable<System.DateTime> LastReceived { get { return I_LastReceived; } set { I_LastReceived = value; } }
        [DefaultValue(null)]
        public System.DateTime LastUpdated { get { return I_LastUpdated; } set { I_LastUpdated = value; } }
        [DefaultValue("")]
        public string Notes { get { return I_Notes; } set { I_Notes = value; } }
        
        public double QuantityCommitted { get { return I_QuantityCommitted; } set { I_QuantityCommitted = value; } }
       
        public int SerialNumberCount { get { return I_SerialNumberCount; } set { I_SerialNumberCount = value; } }
        
        public double TareWeightPercent { get { return I_TareWeightPercent; } set { I_TareWeightPercent = value; } }
        
        public int ID { get { return I_ID; } set { I_ID = value; } }
        [DefaultValue("")]
        public string ItemLookupCode { get { return I_ItemLookupCode; } set { I_ItemLookupCode = value; } }
      
        public int DepartmentID { get { return I_DepartmentID; } set { I_DepartmentID = value; } }
        
        public int CategoryID { get { return I_CategoryID; } set { I_CategoryID = value; } }
       
        public int MessageID { get { return I_MessageID; } set { I_MessageID = value; } }
        
        public decimal Price { get { return I_Price; } set { I_Price = value; } }
        
        public decimal PriceA { get { return I_PriceA; } set { I_PriceA = value; } }
        
        public decimal PriceB { get { return I_PriceB; } set { I_PriceB = value; } }
       
        public decimal PriceC { get { return I_PriceC; } set { I_PriceC = value; } }
       
        public decimal SalePrice { get { return I_SalePrice; } set { I_SalePrice = value; } }
        [DefaultValue(null)]
        public Nullable<System.DateTime> SaleStartDate { get { return I_SaleStartDate; } set { I_SaleStartDate = value; } }
        [DefaultValue(null)]
        public Nullable<System.DateTime> SaleEndDate { get { return I_SaleEndDate; } set { I_SaleEndDate = value; } }
        
        public int QuantityDiscountID { get { return I_QuantityDiscountID; } set { I_QuantityDiscountID = value; } }
        
        public int TaxID { get { return I_TaxID; } set { I_TaxID = value; } }
        [DefaultValue("")]
        public short ItemType { get { return I_ItemType; } set { I_ItemType = value; } }
        
        public decimal Cost { get { return I_Cost; } set { I_Cost = value; } }
       
        public double Quantity { get { return I_Quantity; } set { I_Quantity = value; } }
       
        public double ReorderPoint { get { return I_ReorderPoint; } set { I_ReorderPoint = value; } }
        
        public double RestockLevel { get { return I_RestockLevel; } set { I_RestockLevel = value; } }
       
        public double TareWeight { get { return I_TareWeight; } set { I_TareWeight = value; } }
        
        public int SupplierID { get { return I_SupplierID; } set { I_SupplierID = value; } }
      
        public int TagAlongItem { get { return I_TagAlongItem; } set { I_TagAlongItem = value; } }
       
        public double TagAlongQuantity { get { return I_TagAlongQuantity; } set { I_TagAlongQuantity = value; } }
        
        public int ParentItem { get { return I_ParentItem; } set { I_ParentItem = value; } }
        
        public double ParentQuantity { get { return I_ParentQuantity; } set { I_ParentQuantity = value; } }
        [DefaultValue("")]
        public short BarcodeFormat { get { return I_BarcodeFormat; } set { I_BarcodeFormat = value; } }
       
        public decimal PriceLowerBound { get { return I_PriceLowerBound; } set { I_PriceLowerBound = value; } }
       
        public decimal PriceUpperBound { get { return I_PriceUpperBound; } set { I_PriceUpperBound = value; } }
        [DefaultValue("")]
        public string PictureName { get { return I_PictureName; } set { I_PictureName = value; } }
        [DefaultValue(null)]
        public Nullable<System.DateTime> LastSold { get { return I_LastSold; } set { I_LastSold = value; } }
        [DefaultValue("")]
        public string ExtendedDescription { get { return I_ExtendedDescription; } set { I_ExtendedDescription = value; } }
        [DefaultValue("")]
        public string SubDescription1 { get { return I_SubDescription1; } set { I_SubDescription1 = value; } }
        [DefaultValue("")]
        public string SubDescription2 { get { return I_SubDescription2; } set { I_SubDescription2 = value; } }
        [DefaultValue("")]
        public string SubDescription3 { get { return I_SubDescription3; } set { I_SubDescription3 = value; } }
        [DefaultValue("")]
        public string UnitOfMeasure { get { return I_UnitOfMeasure; } set { I_UnitOfMeasure = value; } }
        
        public int SubCategoryID { get { return I_SubCategoryID; } set { I_SubCategoryID = value; } }
        [DefaultValue(false)]
        public bool QuantityEntryNotAllowed { get { return I_QuantityEntryNotAllowed; } set { I_QuantityEntryNotAllowed = value; } }
        [DefaultValue(false)]
        public bool PriceMustBeEntered { get { return I_PriceMustBeEntered; } set { I_PriceMustBeEntered = value; } }
        [DefaultValue("")]
        public string BlockSalesReason { get { return I_BlockSalesReason; } set { I_BlockSalesReason = value; } }
        [DefaultValue(null)]
        public Nullable<System.DateTime> BlockSalesAfterDate { get { return I_BlockSalesAfterDate; } set { I_BlockSalesAfterDate = value; } }
       
        public double Weight { get { return I_Weight; } set { I_Weight = value; } }
        [DefaultValue(false)]
        public bool Taxable { get { return I_Taxable; } set { I_Taxable = value; } }
        [DefaultValue(null)]
        public byte[] DBTimeStamp { get; set; }
        [DefaultValue(null)]
        public Nullable<System.DateTime> BlockSalesBeforeDate { get { return I_BlockSalesBeforeDate; } set { I_BlockSalesBeforeDate = value; } }
        
        public decimal LastCost { get { return I_LastCost; } set { I_LastCost = value; } }
       
        public decimal ReplacementCost { get { return I_ReplacementCost; } set { I_ReplacementCost = value; } }
        [DefaultValue(false)]
        public bool WebItem { get { return I_WebItem; } set { I_WebItem = value; } }
       
        public int BlockSalesType { get { return I_BlockSalesType; } set { I_BlockSalesType = value; } }
        
        public int BlockSalesScheduleID { get { return I_BlockSalesScheduleID; } set { I_BlockSalesScheduleID = value; } }
       
        public int SaleType { get { return I_SaleType; } set { I_SaleType = value; } }
        
        public int SaleScheduleID { get { return I_SaleScheduleID; } set { I_SaleScheduleID = value; } }
        [DefaultValue(false)]
        public bool Consignment { get { return I_Consignment; } set { I_Consignment = value; } }
        [DefaultValue(false)]
        public bool Inactive { get { return I_Inactive; } set { I_Inactive = value; } }
        [DefaultValue(null)]
        public Nullable<System.DateTime> LastCounted { get { return I_LastCounted; } set { I_LastCounted = value; } }
        [DefaultValue(false)]
        public bool DoNotOrder { get { return I_DoNotOrder; } set { I_DoNotOrder = value; } }
        
        public decimal MSRP { get { return I_MSRP; } set { I_MSRP = value; } }
        [DefaultValue(null)]
        public System.DateTime DateCreated { get { return I_DateCreated; } set { I_DateCreated = value; } }
        [DefaultValue("")]
        public string Content { get { return I_Content; } set { I_Content = value; } }
        [DefaultValue("")]
        public string UsuallyShip { get { return I_UsuallyShip; } set { I_UsuallyShip = value; } }
        [DefaultValue("")]
        public string NumberFormat { get { return I_NumberFormat; } set { I_NumberFormat = value; } }
        [DefaultValue(false)]
        public Nullable<bool> ItemCannotBeRet { get { return I_ItemCannotBeRet; } set { I_ItemCannotBeRet = value; } }
        [DefaultValue(false)]
        public Nullable<bool> ItemCannotBeSold { get { return I_ItemCannotBeSold; } set { I_ItemCannotBeSold = value; } }
        [DefaultValue(false)]
        public Nullable<bool> IsAutogenerated { get { return I_IsAutogenerated; } set { I_IsAutogenerated = value; } }
        [DefaultValue(false)]
        public bool IsGlobalvoucher { get { return I_IsGlobalvoucher; } set { I_IsGlobalvoucher = value; } }
        [DefaultValue(false)]
        public Nullable<bool> DeleteZeroBalanceEntry { get { return I_DeleteZeroBalanceEntry; } set { I_DeleteZeroBalanceEntry = value; } }
       
        public int TenderID { get { return I_TenderID; } set { I_TenderID = value; } }




       
    }
}
