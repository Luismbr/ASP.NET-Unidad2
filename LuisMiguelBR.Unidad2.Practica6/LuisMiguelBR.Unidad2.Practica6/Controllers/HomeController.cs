using LuisMiguelBR.Unidad2.Practica6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
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
                //Codigo=int.Parse(collection["Codigo"]),
                Titulo = collection["Titulo"],
                Director = collection["Director"],
                ActorPrincipal = collection["ActorPrincipal"],
                No_Actores = int.Parse(collection["No_Actores"]),
                Duracion = float.Parse(collection["Duracion"].ToString()),
                Estreno = int.Parse(collection["Estreno"]),
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

        public ActionResult Modificar(int cod)
        {
            RegistroPelicula peli = new RegistroPelicula();
            Pelicula rpt = peli.Recuperar(cod);
            
            return View(rpt);
        }

        [HttpPut]
        public ActionResult Modificar(FormCollection collection)
        {
            RegistroPelicula rpt = new RegistroPelicula();
            Pelicula peli = new Pelicula
            {
                //Codigo = int.Parse(collection["Codigo"]),
                Titulo = collection["Titulo"],
                Director = collection["Director"],
                ActorPrincipal = collection["ActorPrincipal"],
                No_Actores = int.Parse(collection["No_Actores"]),
                Duracion = float.Parse(collection["Duracion"].ToString()),
                Estreno = int.Parse(collection["Estreno"]),
            };
            rpt.Modificar(peli);
            return RedirectToAction("Index");
        }
    }
}