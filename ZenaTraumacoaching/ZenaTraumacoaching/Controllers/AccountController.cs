using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenaTraumacoaching.Converters;
using ZenaTraumacoaching.Models;
using Microsoft.AspNetCore.Http;
using Logic.Containers;
using ZenaTraumacoaching.DAL.DTO;
using ZenaTraumacoaching.DAL.DAL;
using Logic;

namespace ZenaTraumacoaching.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Registratie()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistreerClick(RegistratieViewModel model)
        {
            ConvertUserModel converter = new ConvertUserModel();
            User user = converter.ConvertModelToUser(model);
            user.AddUserToDataBase(new UserDAL());
            return View("Login");
        }
        [HttpPost]
        public ActionResult LoginClick(LoginViewModel model)
        {
            UserContainer userContainer = new UserContainer(new UserDAL());


            if (userContainer.ComparePasswords(model.Username, model.Password))
            {
                HttpContext.Session.SetInt32("UserID", userContainer.GetUserID(model.Username));

                ProfileViewModelConverter profileconv = new ProfileViewModelConverter();
                User user = userContainer.PullUserFromDatabase(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));
                ProfileViewModel vm = new ProfileViewModel();
                vm = profileconv.UserToViewModel(user);
                return View("Profiel", vm);

            }
            else
            {
                return View("Login");
            }
        }
        [HttpGet]
        public IActionResult Profiel()
        {
                ProfileViewModelConverter profileconv = new ProfileViewModelConverter();
                UserContainer userContainer = new UserContainer(new UserDAL());
                User user = userContainer.PullUserFromDatabase(Convert.ToInt32(HttpContext.Session.GetInt32("UserID")));
                ProfileViewModel vm = new ProfileViewModel();
                vm = profileconv.UserToViewModel(user);
            if (vm != null)
            { return View(vm); }
            else { return View("Login"); }
        }
    }
}
