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
    
    public partial class DimensionAttribute
    {
        public int Id { get; set; }
        public string Attribute { get; set; }
        public string Code { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public int DimensionId { get; set; }
        public byte[] DBTimeStamp { get; set; }
    }
}
