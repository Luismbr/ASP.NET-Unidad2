using LuisMiguelBR.Unidad2.Practica5A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuisMiguelBR.Unidad2.Practica5A.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var productos = new List<Producto>
            {
                new Producto{Id=1,  Descripcion="Boligrafo",        Precio=8.35},
                new Producto{Id=2,  Descripcion="Cuaderno grande",  Precio=21.5},
                new Producto{Id=3,  Descripcion="Cuaderno pequeño", Precio=10},
                new Producto{Id=4,  Descripcion="Folios 500 uds.",  Precio=550.55},
                new Producto{Id=5,  Descripcion="Grapadora",        Precio=85.25},
                new Producto{Id=6,  Descripcion="Tijeras",          Precio=62},
                new Producto{Id=7,  Descripcion="Cinta adhesiva",   Precio=45.10},
                new Producto{Id=8,  Descripcion="Rotulador",        Precio=20.75},
                new Producto{Id=9,  Descripcion="Mochila escolar",  Precio=800.90},
                new Producto{Id=10, Descripcion="Pegamento barra",  Precio=30.15},
                new Producto{Id=11, Descripcion="Lapicero",         Precio=15.55},
                new Producto{Id=12, Descripcion="Grapas",           Precio=40.90}
            };
            var resulProductos = from Producto in productos
                                 where Producto.Descripcion.Contains("i")
                                 //where Producto.Descripcion.StartsWith("C")
                                 //where Producto.Descripcion.EndsWith("o")
                                 //where Producto.Precio > 20
                                 //where Producto.Precio < 70
                                 select Producto;
            return View(resulProductos);
        }
    }
}