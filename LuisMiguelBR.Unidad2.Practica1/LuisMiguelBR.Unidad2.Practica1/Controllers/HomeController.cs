using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuisMiguelBR.Unidad2.Practica1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "<html><body>" +
                "<h1>Universidad Autonoma de Santo Domingo (UASD)</h1>" +
                "<p>Diplomado Desarrollo Web C#, MVC </p>" +
                "</body></html>";
        }

        public string DiplomadoWeb()
        {
            return "<html><body>" +
                "<h1>Estudiantes:</h1>" +
                "<p>Estudiante1<br>" +
                "Estudiante2<br>" +
                "Estudiante3</p>" +
                "</body></html>";
        }
    }
}