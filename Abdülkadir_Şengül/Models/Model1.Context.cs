﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abdülkadir_Şengül.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MakaleEntities : DbContext
    {
        public MakaleEntities()
            : base("name=MakaleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bolum> Bolum { get; set; }
        public virtual DbSet<Dergi> Dergi { get; set; }
        public virtual DbSet<Endeks> Endeks { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Makale> Makale { get; set; }
        public virtual DbSet<MakaleKategori> MakaleKategori { get; set; }
        public virtual DbSet<MakaleTur> MakaleTur { get; set; }
        public virtual DbSet<MakaleYazar> MakaleYazar { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Unvan> Unvan { get; set; }
        public virtual DbSet<Log> Log { get; set; }
    }
}
