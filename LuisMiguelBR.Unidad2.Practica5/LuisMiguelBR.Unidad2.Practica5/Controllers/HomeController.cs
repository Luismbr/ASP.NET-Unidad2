using LuisMiguelBR.Unidad2.Practica5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuisMiguelBR.Unidad2.Practica5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var peliculas = new List<Pelicula>
            {
                new Pelicula{Titulo="The GodFather", Director=" Francis Ford Coppola",ActorPrincipal="Al Pacino", NumActore=30, Duracion=2,Estreno=1994},
                new Pelicula{Titulo="The Shawshank", Director=" Frank Darabont",ActorPrincipal="Moran Freeman", NumActore=15, Duracion=3,Estreno=1972},
                new Pelicula{Titulo="The Matrix", Director=" Lara Wachowski",ActorPrincipal="Keanu Reeves", NumActore=15, Duracion=2.3,Estreno=1999}
            };

            var resulPeliculas = from Pelicula in peliculas
                                 where Pelicula.Titulo.Contains("The")
                                 select Pelicula;
            return View(resulPeliculas);
        }

    }
}