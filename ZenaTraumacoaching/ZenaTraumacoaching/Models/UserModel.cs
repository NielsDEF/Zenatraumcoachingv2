﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZenaTraumacoaching.Models
{
    public class UserModel
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

        public UserModel(string username, string password, string firstname, string lastname, string email, string gender)
        {
            this.Username = username;
            this.Password = password;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Email = email;
            this.Gender = gender;
        }
    }
}
