using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc.Models.TableVewModel
{
    public class VehiculoTableViewModel
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int? Año { get; set; }
        public int? Condicion { get; set; }
        public string Imagen { get; set; }
    }
}