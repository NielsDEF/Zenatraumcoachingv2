using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZenaTraumacoaching.Models
{
    public class RegistratieViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please insert the correct Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Gender { get; set; }
    }
}
