using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZenaTraumacoaching.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please insert the correct Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
