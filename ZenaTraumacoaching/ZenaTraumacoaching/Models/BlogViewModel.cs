using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZenaTraumacoaching.Models
{
    public class BlogViewModel
    {
        public int BlogID { get; set; }
        [Required]
        public string BlogTitel { get; set; }
        [Required]
        public string BlogTekst { get; set; }
    }
}
