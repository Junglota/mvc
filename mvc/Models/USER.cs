//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public Nullable<int> Edad { get; set; }
        public Nullable<int> idEstatus { get; set; }
    
        public virtual uEstatus uEstatus { get; set; }
    }
}
