//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DGHCM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserDetail
    {
        public System.Guid CompanyId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Userpassword { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
