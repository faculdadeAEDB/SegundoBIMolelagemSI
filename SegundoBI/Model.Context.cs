﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SegundoBI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Sistema_ImoveisEntities : DbContext
    {
        public Sistema_ImoveisEntities()
            : base("name=Sistema_ImoveisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alguel> Alguel { get; set; }
        public virtual DbSet<Imovel> Imovel { get; set; }
        public virtual DbSet<Inquilino> Inquilino { get; set; }
        public virtual DbSet<Pagamento> Pagamento { get; set; }
        public virtual DbSet<Proprietario> Proprietario { get; set; }
        public virtual DbSet<Taxa> Taxa { get; set; }
    }
}
