﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LuisMiguelBR.Unidad2.Practica6.Models
{
    public class Pelicula
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string AutorPrincipal { get; set; }
        public int numAutores { get; set; }
        public Double Duracion { get; set; }
        public int Estreno { get; set; }
    }
}