//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Blood_Donations_Management_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Recipient
    {
        public int RecipientID { get; set; }
        public System.DateTime DateOfUse { get; set; }
        public string RelatedCondition { get; set; }
        public System.Guid RecipientIdentifier { get; set; }
        public string RecipientCodedName { get; set; }
    }
}