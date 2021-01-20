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
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace ZenaTraumacoaching.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult BlogpaginaNonUser()
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

        public IActionResult ReferentiePaginaNonUser()
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
