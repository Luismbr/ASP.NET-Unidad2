using LuisMiguelBR.Unidad2.Practica6A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuisMiguelBR.Unidad2.Practica6A.Controllers
{
    public class HomeController : Controller
    {
        //GET: Home
        public ActionResult Index()
        {
            RegistroProducto rp = new RegistroProducto();
            return View(rp.RecuperarTodos());
        }

        public ActionResult Grabar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Grabar(FormCollection collection)
        {
            RegistroProducto rp = new RegistroProducto();
            Productos prod = new Productos
            {
                //Id=int.Parse(collection["Id"]),
                Descripcion=collection["Descripcion"],
                Tipo=collection["Tipo"],
                Precio=double.Parse(collection["Precio"].ToString())
            };
            rp.GrabarProducto(prod);
            return RedirectToAction("Index");
        }

    }
}