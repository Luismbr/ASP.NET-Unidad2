using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI.WebControls;

namespace LuisMiguelBR.Unidad2.Practica4A.Models
{
    public class LibroPersonas
    {
        public void Grabar(string nombre, string cedula, string telefono, string correo)
        {
            StreamWriter archivo = new StreamWriter(HostingEnvironment.MapPath("~") + "/App_Data/datos.txt", true);
            archivo.WriteLine("Nombre:   " + nombre + "<br>Cedula:   " + cedula + "<br>Telefono: " + telefono + "<br>Correo:   "+correo+"<hr>");
            archivo.Close();
        }
        public string Leer()
        {
            StreamReader archivo = new StreamReader(HostingEnvironment.MapPath("~") + "/App_Data/datos.txt", true);
            string todo = archivo.ReadToEnd();
            archivo.Close();
            return todo;
        }
    }
}