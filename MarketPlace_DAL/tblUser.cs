//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketPlace_DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;
    using MarketPlace.Models;

    [MetadataType(typeof(LoginMetaData))]

    public partial class tblUser
    {
        public int userID { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Nullable<int> credential_ID { get; set; }
        public string picture { get; set; }
    
        public virtual tblCredential tblCredential { get; set; }
    }
}
