
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
    using System.Collections.Generic;
    
public partial class Consola
{

    public Consola()
    {

        this.ProductoConsola = new HashSet<ProductoConsola>();

    }


    public int Id { get; set; }

    public string Descripcion { get; set; }



    public virtual ICollection<ProductoConsola> ProductoConsola { get; set; }

}

}
