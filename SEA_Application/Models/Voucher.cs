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
    
    public partial class Voucher
    {
        public Voucher()
        {
            this.VoucherRecords = new HashSet<VoucherRecord>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<int> VoucherNo { get; set; }
        public Nullable<int> SessionID { get; set; }
    
        public virtual AspNetSession AspNetSession { get; set; }
        public virtual ICollection<VoucherRecord> VoucherRecords { get; set; }
    }
}