//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TC_Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cotizacion_Producto
    {
        public int noCotizacion { get; set; }
        public Nullable<int> productId { get; set; }
        public int cantidad { get; set; }
        public decimal subTotal { get; set; }
    
        public virtual Cotizacion Cotizacion { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
