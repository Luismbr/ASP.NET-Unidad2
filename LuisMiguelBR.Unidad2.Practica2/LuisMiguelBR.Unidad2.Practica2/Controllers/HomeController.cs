using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuisMiguelBR.Unidad2.Practica2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Fundadores()
        {
            return View();
        }
        public ActionResult Campeonatos()
        {
            return View();
        }
    }
}