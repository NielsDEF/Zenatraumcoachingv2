using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZenaTraumacoaching.Models;

namespace ZenaTraumacoaching.Controllers
{
    public class ZenaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ReferentieToevoegenClick(ReferentieViewModel model)
        {
            return View();
        }
        [HttpPost]
        public IActionResult BlogToevoegenClick(BlogViewModel model)
        {
            return View();
        }
    }
}
