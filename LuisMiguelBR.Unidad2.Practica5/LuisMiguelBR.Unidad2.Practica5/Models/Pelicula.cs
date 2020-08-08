using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace LuisMiguelBR.Unidad2.Practica5.Models
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string ActorPrincipal { get; set; }
        public int NumActore { get; set; }
        public double Duracion { get; set; }
        public int Estreno { get; set; }
    }
}