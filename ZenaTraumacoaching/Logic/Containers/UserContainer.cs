using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenaTraumacoaching.DAL.Interfaces;
using ZenaTraumacoaching.DAL;
using ZenaTraumacoaching.DAL.DTO;

namespace Logic.Containers
{
    public class UserContainer
    {


        IUserContainer userDAL;
        public UserContainer(IUserContainer userdal)
        {
            userDAL = userdal;
        }


        public bool ComparePasswords(string username, string password)
        {
            if (password == userDAL.RequestPassword(username))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public User PullUserFromDatabase(int userid)
        {
            UserDTO user = userDAL.PullUserFromDatabase(userid);
            User USER = new User(user.Username, user.Password, user.Firstname, user.Lastname, user.Emailadress, user.Gender);
            return USER;
        }
        public void AddUserToDataBase(User user)
        {
            ConvertToDTO converter = new ConvertToDTO();
            userDAL.AddUserToDatabase(converter.ConvertUserToDTO(user));
        }

        public int GetUserID(string username)
        {
            int id = userDAL.GetUserID(username);
            return id;
        }
    }
}
