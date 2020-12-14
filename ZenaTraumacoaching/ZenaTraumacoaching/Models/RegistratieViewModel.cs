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
        public string Username { get; private set; }

        [Required(ErrorMessage = "Please insert the correct Password")]
        [DataType(DataType.Password)]
        public string Password { get; private set; }

        [Required]
        public string Firstname { get; private set; }

        [Required]
        public string Lastname { get; private set; }

        [Required]
        public string Email { get; private set; }

        [Required]
        public string Gender { get; private set; }
    }
}
