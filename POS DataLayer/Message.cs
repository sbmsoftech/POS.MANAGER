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
    
    public partial class Message
    {
        public int ID { get; set; }
        public int FromCashierID { get; set; }
        public int ToCashierID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public System.DateTime DateSent { get; set; }
        public System.DateTime DateRead { get; set; }
        public bool Deleted { get; set; }
        public byte[] DBTimeStamp { get; set; }
        public int StoreID { get; set; }
    }
}
