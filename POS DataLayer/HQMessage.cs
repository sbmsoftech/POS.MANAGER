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
    
    public partial class HQMessage
    {
        public int ID { get; set; }
        public short Status { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public short Style { get; set; }
        public int FromStoreID { get; set; }
        public int ToStoreID { get; set; }
        public int AttachmentID { get; set; }
        public Nullable<System.DateTime> DateSent { get; set; }
        public Nullable<System.DateTime> DateReceived { get; set; }
        public byte[] DBTimeStamp { get; set; }
    }
}
