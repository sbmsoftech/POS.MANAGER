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
    
    public partial class RR_UserPrivileges
    {
        public int ID { get; set; }
        public int HQID { get; set; }
        public int UserID { get; set; }
        public int CmRoleID { get; set; }
        public int MdRoleID { get; set; }
        public short Deleted { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public byte[] DBTimeStamp { get; set; }
    }
}
