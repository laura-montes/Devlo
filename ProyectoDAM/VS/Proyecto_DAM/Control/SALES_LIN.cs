//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Control
{
    using System;
    using System.Collections.Generic;
    
    public partial class SALES_LIN
    {
        public int IDLIN { get; set; }
        public Nullable<int> N_LIN { get; set; }
        public Nullable<int> IDPRODUCT { get; set; }
        public Nullable<int> UNITS { get; set; }
        public Nullable<int> IDCAB { get; set; }
    
        public virtual PRODUCT PRODUCT { get; set; }
        public virtual SALES_CAB SALES_CAB { get; set; }
    }
}
