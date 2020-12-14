using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenaTraumacoaching.DAL.Interfaces;

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

        IUser userDAL;


        public User(string username, string password, string firstname, string lastname, string email, string gender)

        {
            this.username = username;
            this.password = password;
            this.firstname = firstname;
            this.lastname = lastname;
            this.emailadress = email;
            this.gender = gender;

        }
        public void SetDal(IUser dal)
        {
            userDAL = dal;
        }
        public void AddUserToDataBase(User user)
        {
            ConvertToDTO converter = new ConvertToDTO();
            userDAL.AddUserToDatabase(converter.ConvertUserToDTO(user));
        }
    }
}
