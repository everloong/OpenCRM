//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenCRM.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account_Type
    {
        public Account_Type()
        {
            this.Accounts = new HashSet<Account>();
        }
    
        public int AccountTypeId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
