﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenCRM.DataBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OpenCRMEntities : DbContext
    {
        public OpenCRMEntities()
            : base("name=OpenCRMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Account_Ownership> Account_Ownership { get; set; }
        public DbSet<Account_Priority> Account_Priority { get; set; }
        public DbSet<Account_SLA> Account_SLA { get; set; }
        public DbSet<Account_Type> Account_Type { get; set; }
        public DbSet<Account_Up_Sell_Opportunity> Account_Up_Sell_Opportunity { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Address_Type> Address_Type { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Campaign_Status> Campaign_Status { get; set; }
        public DbSet<Campaign_Type> Campaign_Type { get; set; }
        public DbSet<Case_Origin> Case_Origin { get; set; }
        public DbSet<Case_Priority> Case_Priority { get; set; }
        public DbSet<Case_Reason> Case_Reason { get; set; }
        public DbSet<Case_Status> Case_Status { get; set; }
        public DbSet<Case_Type> Case_Type { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Contact_Level_Languages> Contact_Level_Languages { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Industry> Industries { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Lead_Source> Lead_Source { get; set; }
        public DbSet<Lead> Leads { get; set; }
        public DbSet<Level_Language> Level_Language { get; set; }
        public DbSet<Object_Fields> Object_Fields { get; set; }
        public DbSet<Object> Objects { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }
        public DbSet<Opportunities_Competidor> Opportunities_Competidor { get; set; }
        public DbSet<Opportunities_Delivery_Status> Opportunities_Delivery_Status { get; set; }
        public DbSet<Opportunities_Products> Opportunities_Products { get; set; }
        public DbSet<Opportunities_Stage> Opportunities_Stage { get; set; }
        public DbSet<Opportunities_Status> Opportunities_Status { get; set; }
        public DbSet<Opportunities_Type> Opportunities_Type { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Profile_Object> Profile_Object { get; set; }
        public DbSet<Profile_Object_Fields> Profile_Object_Fields { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Salutation> Salutations { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<User> Users { get; set; }
    }
}