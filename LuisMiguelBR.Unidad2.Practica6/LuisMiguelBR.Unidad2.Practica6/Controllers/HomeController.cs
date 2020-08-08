using LuisMiguelBR.Unidad2.Practica6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuisMiguelBR.Unidad2.Practica6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            RegistroPelicula rp = new RegistroPelicula();

            return View(rp.RecuperarTodo());
        }

        public ActionResult Grabar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Grabar (FormCollection collection)
        {
            RegistroPelicula rp = new RegistroPelicula();
            Pelicula peli = new Pelicula
            {
                Codigo= int.Parse(collection["Codigo"]),
                Titulo= collection["Titulo"],
                Director=collection["Director"],
                AutorPrincipal=collection["AutorPrincipal"],
                numAutores=int.Parse(collection["numAutores"]),
                Duracion=float.Parse(collection["Duracion"].ToString()),
                Estreno=int.Parse(collection["Estreno"]),
            };
            rp.GrabarPelicula(peli);
            return RedirectToAction("Index");
        }

        public ActionResult Borrar (int cod)
        {
            RegistroPelicula peli = new RegistroPelicula();
            peli.Borrar(cod);
            return RedirectToAction("Index");
        }

        public ActionResult Modificacion(int cod)
        {
            RegistroPelicula peli = new RegistroPelicula();
            Pelicula rpt = peli.Recuperar(cod);
            return View(rpt);
        }

        [HttpPost]
        public ActionResult Modificacion(FormCollection collection)
        {
            RegistroPelicula peli = new RegistroPelicula();
            Pelicula rpt = new Pelicula
            {
                Codigo = int.Parse(collection["Codigo"]),
                Titulo = collection["Titulo"],
                Director = collection["Director"],
                AutorPrincipal = collection["AutorPrincipal"],
                numAutores = int.Parse(collection["numAutores"]),
                Duracion = float.Parse(collection["Duracion"].ToString()),
                Estreno = int.Parse(collection["Estreno"]),
            };
            peli.Modificar(rpt);
            return RedirectToAction("Index");
        }
    }
}