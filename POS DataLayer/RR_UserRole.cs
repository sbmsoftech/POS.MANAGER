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
    
    public partial class RR_UserRole
    {
        public int ID { get; set; }
        public int HQID { get; set; }
        public string ProductNumber { get; set; }
        public string RoleName { get; set; }
        public int Privileges { get; set; }
        public int Flag { get; set; }
        public short Deleted { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public byte[] DBTimeStamp { get; set; }
    }
}
