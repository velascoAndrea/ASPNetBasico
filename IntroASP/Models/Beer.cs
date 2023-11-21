using System;
using System.Collections.Generic;

#nullable disable

namespace IntroASP.Models
{
    public partial class Beer
    {
        public int BeerId { get; set; }
        public string Nombre { get; set; }
        public int? BrandId { get; set; }

        public virtual Brand Brand { get; set; }
    }
}
