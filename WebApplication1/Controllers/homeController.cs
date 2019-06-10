using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class homeController : Controller
    {
        cmpEntities en = new cmpEntities();
        // GET: home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult savedata(city ct)
        {

          en.cities.Add(ct);
            en.SaveChanges();
            return View();
        }
    }
}