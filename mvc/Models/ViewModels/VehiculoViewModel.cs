using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
namespace mvc.Models.ViewModels
{
    public class VehiculoViewModel
    {
        [Required]
        [Display(Name ="ID")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Required]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Required]
        [Display(Name = "Año")]
        public int Año { get; set; }

        [Required]
        [Display(Name = "Condicion")]
        public int Condicion { get; set; }

        [Required]
        [Display(Name = "Foto")]
        public string Foto { get; set; }

    }
    public class EditVehiculoViewModel
    {
        [Required]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Required]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Required]
        [Display(Name = "Año")]
        public int? Año { get; set; }

        [Required]
        [Display(Name = "Condicion")]
        public int? Condicion { get; set; }

        [Required]
        [Display(Name = "Foto")]
        public string Foto { get; set; }

    }
}