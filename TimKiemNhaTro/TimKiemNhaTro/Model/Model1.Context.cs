﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimKiemNhaTro.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NhaTroEntities : DbContext
    {
        public NhaTroEntities()
            : base("name=NhaTroEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AnhNha> AnhNhas { get; set; }
        public virtual DbSet<CoSoVatChat> CoSoVatChats { get; set; }
        public virtual DbSet<DanhGia> DanhGias { get; set; }
        public virtual DbSet<LoaiChoThue> LoaiChoThues { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<Nha> Nhas { get; set; }
        public virtual DbSet<YeuThich> YeuThiches { get; set; }
    }
}