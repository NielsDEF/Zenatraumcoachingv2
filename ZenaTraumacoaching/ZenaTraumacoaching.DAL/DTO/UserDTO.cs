using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenaTraumacoaching.DAL.DTO
{
    public class UserDTO
    {
        private string username;

        public string Username
        {
            get { return username; }
        }
        private string password;

        public string Password
        {
            get { return password; }
        }
        private string firstname;

        public string Firstname
        {
            get { return firstname; }
        }
        private string lastname;

        public string Lastname
        {
            get { return lastname; }
        }
        private string emailadress;

        public string Emailadress
        {
            get { return emailadress; }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
        }

        public UserDTO(string username, string password, string firstname, string lastname, string email, string gender)
        {
            this.username = username;
            this.password = password;
            this.firstname = firstname;
            this.lastname = lastname;
            this.emailadress = email;
            this.gender = gender;
        }
        public UserDTO(string firstname, string lastname, string email, string gender)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.emailadress = email;
            this.gender = gender;
        }
    }
}
