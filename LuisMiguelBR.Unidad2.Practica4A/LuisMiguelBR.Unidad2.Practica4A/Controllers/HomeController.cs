using LuisMiguelBR.Unidad2.Practica4A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuisMiguelBR.Unidad2.Practica4A.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FormularioPersonas()
        {
            return View();
        }
        public ActionResult CargaDatos()
        {
            string nombre = Request.Form["nombre"].ToString();
            string cedula = Request.Form["cedula"].ToString();
            string telefono = Request.Form["telefono"].ToString();
            string correo = Request.Form["correo"].ToString();
            LibroPersonas libro = new LibroPersonas();
            libro.Grabar(nombre, cedula, telefono, correo);
            return View();
        }
        public ActionResult ListadoPersonas()
        {
            LibroPersonas libro = new LibroPersonas();
            string todo = libro.Leer();
            ViewData["libro"] = todo;
            return View();
        }
    }
}