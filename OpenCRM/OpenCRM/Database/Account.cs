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
    
    public partial class Account
    {
        public Account()
        {
            this.Cases = new HashSet<Case>();
            this.Contacts = new HashSet<Contact>();
            this.Opportunities = new HashSet<Opportunity>();
        }
    
        public int AccountId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Name { get; set; }
        public Nullable<int> AccountBillingId { get; set; }
        public Nullable<int> AccountOwnerShipId { get; set; }
        public Nullable<int> AccountShippingId { get; set; }
        public Nullable<int> AccountTypeId { get; set; }
        public Nullable<int> AccountPriorityId { get; set; }
        public Nullable<int> AccountSLAId { get; set; }
        public Nullable<int> AccountUpSellOpportunityId { get; set; }
        public string AccountSite { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<float> AnualRevenue { get; set; }
        public string Description { get; set; }
        public Nullable<int> Employees { get; set; }
        public string FaxNumber { get; set; }
        public Nullable<int> IndustryId { get; set; }
        public Nullable<int> NumberOfLocation { get; set; }
        public string PhoneNumber { get; set; }
        public string SlaSerialNumber { get; set; }
        public Nullable<int> RatingId { get; set; }
        public string TickerSymbol { get; set; }
        public string WebSite { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual Account_Ownership Account_Ownership { get; set; }
        public virtual Account_Priority Account_Priority { get; set; }
        public virtual Account_SLA Account_SLA { get; set; }
        public virtual Account_Type Account_Type { get; set; }
        public virtual Account_Up_Sell_Opportunity Account_Up_Sell_Opportunity { get; set; }
        public virtual Address Address { get; set; }
        public virtual Address Address1 { get; set; }
        public virtual Industry Industry { get; set; }
        public virtual Rating Rating { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Case> Cases { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Opportunity> Opportunities { get; set; }
    }
}
