using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LuisMiguelBR.Unidad2.Practica6.Models
{
    public class RegistroPelicula
    {
        private SqlConnection con;

        private void Conectar()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConexionDB"].ToString();
            con = new SqlConnection(constr);
        }

        public int GrabarPelicula(Pelicula peli)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("Insert Into TBL_PELICULA (Codigo, Titulo, Director, AutorPrincipal, No_Autores, Duracion, Estreno)" +
                                                "Values (@Codigo, @Titulo, @Director, @AutorPrincipal, @No_Actores, @Duracion, @Estreno)", con);
            comando.Parameters.Add("@Codigo", SqlDbType.VarChar);
            comando.Parameters.Add("@Titulo", SqlDbType.VarChar);
            comando.Parameters.Add("@Director", SqlDbType.VarChar);
            comando.Parameters.Add("@AutorPrincipal", SqlDbType.VarChar);
            comando.Parameters.Add("@No_Actores", SqlDbType.VarChar);
            comando.Parameters.Add("@Duracion", SqlDbType.VarChar);
            comando.Parameters.Add("@Estreno", SqlDbType.VarChar);
            comando.Parameters["@Titulo"].Value = peli.Titulo;
            comando.Parameters["@Director"].Value = peli.Director;
            comando.Parameters["@AutorPrincipal"].Value = peli.AutorPrincipal;
            comando.Parameters["@No_Actores"].Value = peli.numAutores;
            comando.Parameters["@Duracion"].Value = peli.Duracion;
            comando.Parameters["@Estreno"].Value = peli.Estreno;
            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public List<Pelicula> RecuperarTodo()
        {
            Conectar();
            List<Pelicula> peliculas = new List<Pelicula>();
            SqlCommand com = new SqlCommand("Select Codigo, Titulo, Director, AutorPrincipal, No_Actores, Duracion, Estreno From TBL_PELICULA", con);
            con.Open();
            SqlDataReader registros = com.ExecuteReader();
            while (registros.Read())
            {
                Pelicula peli = new Pelicula
                {
                    Codigo = int.Parse(registros["Codigo"].ToString()),
                    Titulo = registros["Titulo"].ToString(),
                    Director = registros["Director"].ToString(),
                    AutorPrincipal = registros["AutorPrincipal"].ToString(),
                    numAutores = int.Parse(registros["No_Actores"].ToString()),
                    Duracion = float.Parse(registros["Duracion"].ToString()),
                    Estreno = int.Parse(registros["Estreno"].ToString())
                };
                peliculas.Add(peli);
            }
            con.Close();
            return peliculas;
        }

        public Pelicula Recuperar (int codigo)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("Select Codigo, Titulo, Director, AutorPrincipal, No_Actores, Duracion, Estreno From TBL_PELICULA" +
                                                "From TBL_PELICULA where Codigo=@Codigo", con);
            comando.Parameters.Add("@Codigo", SqlDbType.Int);
            comando.Parameters["@Codigo"].Value = codigo;
            con.Open();
            SqlDataReader registros = comando.ExecuteReader();
            Pelicula pelicula = new Pelicula();
            if (registros.Read())
            {
                pelicula.Codigo = int.Parse(registros["Codigo"].ToString());
                pelicula.Titulo = registros["Titulo"].ToString();
                pelicula.Director = registros["Director"].ToString();
                pelicula.AutorPrincipal = registros["AutorPrincipal"].ToString();
                pelicula.numAutores = int.Parse(registros["No_Actores"].ToString());
                pelicula.Duracion = double.Parse(registros["Titulo"].ToString());
                pelicula.Estreno = int.Parse(registros["Estreno"].ToString());
            }
            con.Close();
            return pelicula;
        }

        public int Modificar (Pelicula peli)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("Update TBL_PELICULA set Titulo=@Titulo, Director=@Director, AutorPrincipal=@AutorPrincipal, No_Autores=@No_Actores, "+
                                                "Duracion=@Duracion, Estreno=@Estreno where Codigo=@Codigo", con);
            comando.Parameters.Add("@Titulo", SqlDbType.VarChar);
            comando.Parameters["@Titulo"].Value = peli.Titulo;
            comando.Parameters.Add("@Director", SqlDbType.VarChar);
            comando.Parameters["@Director"].Value = peli.Director;
            comando.Parameters.Add("@AutorPrincipal", SqlDbType.VarChar);
            comando.Parameters["@AutorPrincipal"].Value = peli.AutorPrincipal;
            comando.Parameters.Add("@No_Actores", SqlDbType.VarChar);
            comando.Parameters["@No_Actores"].Value = peli.numAutores;
            comando.Parameters.Add("@Duracion", SqlDbType.VarChar);
            comando.Parameters["@Duracion"].Value = peli.Duracion;
            comando.Parameters.Add("@Estreno", SqlDbType.VarChar);
            comando.Parameters["@Estreno"].Value = peli.Estreno;

            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public int Borrar (int codigo)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("Delete From TBL_PELICULA where Codigo=@Codigo", con);
            comando.Parameters.Add("@Codigo", SqlDbType.VarChar);
            comando.Parameters["@Codigo"].Value = codigo;
            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}