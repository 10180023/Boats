﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BoatsProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BoatsEntities : DbContext
    {
        public BoatsEntities()
            : base("name=BoatsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accessuars> Accessuars { get; set; }
        public virtual DbSet<Boats> Boats { get; set; }
        public virtual DbSet<BoatTypes> BoatTypes { get; set; }
        public virtual DbSet<Colors> Colors { get; set; }
        public virtual DbSet<Companies> Companies { get; set; }
        public virtual DbSet<Contracts> Contracts { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<DeliveryDetails> DeliveryDetails { get; set; }
        public virtual DbSet<Fits> Fits { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<Managers> Managers { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Partners> Partners { get; set; }
        public virtual DbSet<PassportTypes> PassportTypes { get; set; }
        public virtual DbSet<ProductionProcesses> ProductionProcesses { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<WoodTypes> WoodTypes { get; set; }
    }
}