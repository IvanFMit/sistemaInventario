﻿

//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DAL.VideoJuegos
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class VideoJuegosDatabaseEntities : DbContext
{
    public VideoJuegosDatabaseEntities()
        : base("name=VideoJuegosDatabaseEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public DbSet<Categoria> Categoria { get; set; }

    public DbSet<Consola> Consola { get; set; }

    public DbSet<Producto> Producto { get; set; }

    public DbSet<ProductoConsola> ProductoConsola { get; set; }

    public DbSet<Renta> Renta { get; set; }

    public DbSet<TipoRenta> TipoRenta { get; set; }

    public DbSet<Usuario> Usuario { get; set; }

    public DbSet<Cliente> Cliente { get; set; }

}

}

