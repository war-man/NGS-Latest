//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SEA_Application.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AspNetNotification
    {
        public AspNetNotification()
        {
            this.AspNetNotification_User = new HashSet<AspNetNotification_User>();
        }
    
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public string SenderID { get; set; }
        public string Url { get; set; }
        public Nullable<int> SessionID { get; set; }
    
        public virtual AspNetSession AspNetSession { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual ICollection<AspNetNotification_User> AspNetNotification_User { get; set; }
    }
}