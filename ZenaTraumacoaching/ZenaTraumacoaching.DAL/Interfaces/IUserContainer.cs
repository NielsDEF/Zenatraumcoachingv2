using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenaTraumacoaching.DAL.DTO;

namespace ZenaTraumacoaching.DAL.Interfaces
{
    public interface IUserContainer
    {
        string RequestPassword(string username);
        void AddUserToDatabase(UserDTO user);
        int GetUserID(string username);
        string GetUserType(string username);
        UserDTO PullUserFromDatabase(int userid);

    }
}
