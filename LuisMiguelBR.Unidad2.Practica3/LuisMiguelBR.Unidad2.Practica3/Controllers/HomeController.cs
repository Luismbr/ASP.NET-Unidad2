using LuisMiguelBR.Unidad2.Practica3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuisMiguelBR.Unidad2.Practica3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var Coches = new List<Coche>
            { 
            new Coche{Tipo="Jeepeta", Marca= "Alfa Romeo", Modelo="Stelvio", Color="Gris"},
            new Coche{Tipo="Jeep", Marca= "BMW", Modelo="X6", Color="Azul"},
            new Coche{Tipo="Jeep", Marca= "Cadillac", Modelo="ATS", Color="Negro"},
            new Coche{Tipo="Sedan", Marca= "Kia", Modelo="K-5", Color="Blanco"},
            new Coche{Tipo="Sedan", Marca= "Nissan", Modelo="Versa", Color="Blanco"},
            new Coche{Tipo="Camioneta", Marca= "Mitsubishi", Modelo="L 200", Color="Negra"},
            new Coche{Tipo="Jeep", Marca= "BMW", Modelo="X6", Color="Azul"},
            new Coche{Tipo="Camioneta", Marca= "Nissan", Modelo="Frontier LE X-Gear", Color="Blanco"},
            new Coche{Tipo="Sedan", Marca= "Mercedes-Benz", Modelo="Clase GT", Color="Negro"},
            new Coche{Tipo="Coupe", Marca= "Toyota", Modelo="Supra", Color="Negro"},
            new Coche{Tipo="Coupe", Marca= "McLaren", Modelo="570 S", Color="Azul"}
            };

            return View(Coches);
        }
    }
}