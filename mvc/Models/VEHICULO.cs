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
    
    public partial class VEHICULO
    {
        public int ID { get; set; }
        public string MARCA { get; set; }
        public Nullable<double> PRECIO { get; set; }
        public Nullable<int> CONDICION { get; set; }
        public Nullable<int> ESTATUS { get; set; }
        public string DETALLES { get; set; }
        public string FOTOS { get; set; }
        public string MODELO { get; set; }
        public Nullable<int> nYEAR { get; set; }
    
        public virtual mESTATUS mESTATUS { get; set; }
    }
}