﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _25EEJEM_PLANTILLA_POR_HOSPITAL_AJAX_HIPERVINCULOS.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntidadHospital : DbContext
    {
        public EntidadHospital()
            : base("name=EntidadHospital")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HOSPITAL> HOSPITAL { get; set; }
        public virtual DbSet<PLANTILLA> PLANTILLA { get; set; }
    }
}
