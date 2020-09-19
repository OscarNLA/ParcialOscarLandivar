using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialOscarLandivar.Models
{
    public class Languajes
    {
        [Key]
        [Required]
        [StringLength(3, ErrorMessage = "Poner el codigo correcto", MinimumLength = 1)]
        public string Iso639_1 { get; set; }
        [Required]
        [StringLength(5, ErrorMessage = "Poner el codigo correcto", MinimumLength = 1)]
        public string Iso639_2 { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Poner el codigo correcto", MinimumLength = 1)]
        public string Name { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Poner el codigo correcto", MinimumLength = 1)]
        public string NativeName { get; set; }


    }
    public class Paises
    {
        [Key]
        [Required]
        [StringLength(3, ErrorMessage = "Poner el codigo correcto", MinimumLength = 1)]
        public string Alpha3Code { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Poner el nombre completo", MinimumLength = 3)]
        public string Region { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Poner el codigo correcto", MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [Range(1, 99)]
        public int CallingCodes { get; set; }
        [Required]
        public List<Languajes> languajes { get; set; }
        [Required]
        public string Flags { get; set; }

    }
}
