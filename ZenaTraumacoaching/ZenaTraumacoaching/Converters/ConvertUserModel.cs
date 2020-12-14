using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenaTraumacoaching.Models;
using Logic;

namespace ZenaTraumacoaching.Converters
{
    public class ConvertUserModel
    {
        public User ConvertModelToUser(UserModel model)
        {
            User user = new User(model.Username, model.Password, model.Firstname, model.Lastname, model.Email, model.Gender);

            return user;
        }
    }
}
