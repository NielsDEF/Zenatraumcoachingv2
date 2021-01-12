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
    public class ZenaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Referentie()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BlogToevoegenClick(BlogViewModel model)
        {
            ConvertBlogModel converter = new ConvertBlogModel();
            Blog blog = converter.ConvertModelToBlogPost(model);
            blog.AddBlogToDatabase(new BlogDAL());
            return View("Blog");
        }

        public IActionResult Blogpagina()
        {
            BlogContainer container = new BlogContainer(new BlogDAL());

            List<Blog> blogs = container.GetAllBlogposts();
            BlogToModel converter = new BlogToModel();
            BlogpaginaViewModel model = new BlogpaginaViewModel();
            model.blog = new List<BlogViewModel>();
            foreach (var blog in blogs)
            {
                model.blog.Add(converter.ConvertBlogToModel(blog));
            }
            return View(model);
        }

        //[HttpPost]
        //public ActionResult ReferentieToevoegenClick(ReferentieViewModel model)
        //{
        //    ConvertUserModel converter = new ConvertUserModel();
        //    User user = converter.ConvertModelToUser(model);
        //    user.SetDal(new UserDAL());
        //    user.AddUserToDataBase(converter.(model));
        //    return View("Login");
        //}

    }
}
