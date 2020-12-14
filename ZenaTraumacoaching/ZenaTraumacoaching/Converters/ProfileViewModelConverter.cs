using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using ZenaTraumacoaching.Models;

namespace ZenaTraumacoaching.Converters
{
    public class ProfileViewModelConverter
    {
        public ProfileViewModel UserToViewModel(User userdto)
        {
            ProfileViewModel profileviewmodel = new ProfileViewModel()
            {
                Firstname = userdto.Firstname,
                Lastname = userdto.Lastname,
                Email = userdto.Emailadress,
                Gender = userdto.Gender
            };
            return profileviewmodel;
        }
    }
}
