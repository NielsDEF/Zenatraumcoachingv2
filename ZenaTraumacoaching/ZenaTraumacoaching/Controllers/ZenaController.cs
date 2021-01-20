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
using ZenaTraumacoaching.DAL.Helpers;
using Microsoft.AspNetCore.Http.Features;

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
            int ID = (int)HttpContext.Session.GetInt32("UserID");
            if (ID == 7)
            {
                ConvertBlogModel converter = new ConvertBlogModel();
                Blog blog = converter.ConvertModelToBlogPost(model);
                blog.AddBlogToDatabase(new BlogDAL());
                return RedirectToAction("Blogpagina");
            }
            else { return RedirectToAction("Blogpagina"); }
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

        public ActionResult BlogPostDeleteClick(string id)
        {
            int ID = (int)HttpContext.Session.GetInt32("UserID");
            if (ID == 7)
            {
                BlogContainer container = new BlogContainer(new BlogDAL());
                container.DeleteBlogFromDatabase(Convert.ToInt32(id));
                return RedirectToAction("Blogpagina");
            }
            else { return RedirectToAction("Blogpagina"); }
        }
        [HttpPost]
        public ActionResult BlogUpdateClick(BlogViewModel model)
        {
            int ID = (int)HttpContext.Session.GetInt32("UserID");
            if (ID == 7)
            {
                ConvertBlogModel converter = new ConvertBlogModel();
                Blog blog = converter.ConvertModelToBlogPost(model);
                blog.BlogPostUpdate(new BlogDAL());
                return RedirectToAction("Blogpagina");
            }
            else { return RedirectToAction("Blogpagina"); }
        }

        [HttpGet]
        public ActionResult BlogBewerken(string id)
        {
            int ID = (int)HttpContext.Session.GetInt32("UserID");
            if (ID == 7)
            {
                BlogContainer container = new BlogContainer(new BlogDAL());
                container.GetBlogPost(Convert.ToInt32(id));
                BlogToModel converter = new BlogToModel();
                BlogViewModel model = converter.ConvertBlogToModel(container.GetBlogPost(Convert.ToInt32(id)));
                return View(model);
            }
            else { return RedirectToAction("Blogpagina"); }
        }
        [HttpPost]
        public ActionResult ReferentieToevoegenClick(ReferentieViewModel model)
        {
            ConvertReferentieModel converter = new ConvertReferentieModel();
            Referentie referentie = converter.ConvertModelToReferentie(model);
            referentie.AddReferentieToDatabase(new ReferentieDAL());
            return RedirectToAction("Referentiepagina");
        }

        public IActionResult ReferentiePagina()
        {
            ReferentieContainer container = new ReferentieContainer(new ReferentieDAL());

            List<Referentie> referenties = container.GetAllReferenties();
            ReferentieToModel converter = new ReferentieToModel();
            ReferentiepaginaViewModel model = new ReferentiepaginaViewModel();
            model.referentie = new List<ReferentieViewModel>();
            foreach (var referentie in referenties)
            {
                model.referentie.Add(converter.ConvertReferentieToModel(referentie));
            }
            return View(model);
        }

        public ActionResult ReferentieDeleteClick(string id)
        {
            int ID = (int)HttpContext.Session.GetInt32("UserID");
            if (ID == 7)
            {
                ReferentieContainer container = new ReferentieContainer(new ReferentieDAL());
                container.DeleteReferentieFromDatabase(Convert.ToInt32(id));
                return RedirectToAction("Referentiepagina");
            }
            else { return RedirectToAction("Referentiepagina"); }
        }
        [HttpPost]
        public ActionResult ReferentieUpdateClick(ReferentieViewModel model)
        {
            int ID = (int)HttpContext.Session.GetInt32("UserID");
            if (ID == 7)
            {
                ConvertReferentieModel converter = new ConvertReferentieModel();
                Referentie referentie = converter.ConvertModelToReferentie(model);
                referentie.ReferentieUpdate(new ReferentieDAL());
                return RedirectToAction("Referentiepagina");
            }

            else { return RedirectToAction("Referentiepagina"); }
        }
        
        [HttpGet]
        public ActionResult ReferentieBewerken(string id)
        {
            ReferentieContainer container = new ReferentieContainer(new ReferentieDAL());
            container.GetReferentie(Convert.ToInt32(id));
            ReferentieToModel converter = new ReferentieToModel();
            ReferentieViewModel model = converter.ConvertReferentieToModel(container.GetReferentie(Convert.ToInt32(id)));
            return View(model);
        }
    }
}
