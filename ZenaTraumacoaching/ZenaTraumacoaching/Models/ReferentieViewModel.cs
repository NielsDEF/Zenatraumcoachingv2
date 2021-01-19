using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZenaTraumacoaching.Models
{
    public class ReferentieViewModel
    {
        public int ReferentieID { get; set; }
        [Required]
        [Range(0,10)]
        public int ReferentieCijfer { get; set; }
        [Required]
        public string ReferentieTekst { get; set; }

    }
}
