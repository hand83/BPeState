﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BPeState
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tudbaseEntities2 : DbContext
    {
        public tudbaseEntities2()
            : base("name=tudbaseEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Contractor> Contractors { get; set; }
        public virtual DbSet<IC> ICs { get; set; }
        public virtual DbSet<Investment> Investments { get; set; }
        public virtual DbSet<IS> ISs { get; set; }
        public virtual DbSet<IT> IT { get; set; }
        public virtual DbSet<Street> Streets { get; set; }
        public virtual DbSet<Transport> Transports { get; set; }
    }
}
