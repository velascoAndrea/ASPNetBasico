using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntroASP.Models.ViewModels
{
    public class BeerViewModel
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Marca")]
        public int BrandId { get; set; }

    }
}
