using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class User
    {
        private string username;
        public string Username { get => username; }

        private string password;
        public string Password { get => password; }

        private string firstname;
        public string Firstname { get => firstname; }

        private string lastname;
        public string Lastname { get => lastname; }

        private string emailadress;
        public string Emailadress { get => emailadress; }

        private string gender;
        public string Gender { get => gender; }

        private string usertype;
        public string Usertype { get => usertype; }



        public User(string username, string password, string firstname, string lastname, string email, string gender, string usertype)

        {
            this.username = username;
            this.password = password;
            this.firstname = firstname;
            this.lastname = lastname;
            this.emailadress = email;
            this.gender = gender;
            this.usertype = usertype;

        }
    }
}
