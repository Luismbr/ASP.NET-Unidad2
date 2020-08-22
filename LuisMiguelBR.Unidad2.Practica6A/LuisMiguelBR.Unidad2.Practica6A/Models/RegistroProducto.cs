using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LuisMiguelBR.Unidad2.Practica6A.Models
{
    public class RegistroProducto
    {
        private SqlConnection con;

        //Conectarse a la DB
        private void Conectar()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConexionDB"].ToString();
            con = new SqlConnection(constr);
        }
      
        //Grabar un registro en la DB
        public int GrabarProducto(Productos prod)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("Insert Into Producto (Descripcion, Tipo, Precio) Values (@Descripcion, @Tipo, @Precio)", con);

            comando.Parameters.Add("@Descripcion", SqlDbType.VarChar);
            comando.Parameters.Add("@Tipo", SqlDbType.VarChar);
            comando.Parameters.Add("@Precio", SqlDbType.Decimal);
            comando.Parameters["@Descripcion"].Value = prod.Descripcion;
            comando.Parameters["@Tipo"].Value = prod.Tipo;
            comando.Parameters["@Precio"].Value = prod.Precio;

            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }

        //Mostrar todos los registros de la DB
        public List<Productos> RecuperarTodos()
        {
            Conectar();
            List<Productos> productos = new List<Productos>();

            SqlCommand comando = new SqlCommand("Select Id, Descripcion, Tipo, Precio From Productos", con);

            con.Open();
            SqlDataReader registros = comando.ExecuteReader();
            while(registros.Read())
            {
                Productos producto = new Productos
                {
                    Id = int.Parse(registros["Id"].ToString()),
                    Descripcion = registros["Descripcion"].ToString(),
                    Tipo = registros["Tipo"].ToString(),
                    Precio = double.Parse(registros["Descripcion"].ToString())
                };
                productos.Add(producto);
            }
            con.Close();
            return productos;
        }

        //Mostrar un registro especifico de la DB.
        public Productos Recuperar(int codigo)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("Select Id, Descripcion, Tipo, Precio From Productos where Id=@Id", con);

            comando.Parameters.Add("@Id", SqlDbType.Int);
            comando.Parameters["@Id"].Value = codigo;
            con.Open();
            SqlDataReader registro = comando.ExecuteReader();
            Productos producto = new Productos();

            if (registro.Read())
            {
                producto.Descripcion = registro["Descripcion"].ToString();
                producto.Tipo = registro["Tipo"].ToString();
                producto.Precio = double.Parse(registro["Precio"].ToString());
            }
            con.Close();
            return producto;
        }

        //Modificar un registro especifica
        public int Modificar(Productos producto)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("Update Productos set Descripcion=@Descripcion, Tipo=@Tipo, Precio=@Precio where Id=@Id", con);

            comando.Parameters.Add("@Descripcion", SqlDbType.VarChar);
            comando.Parameters["@Descripcion"].Value = producto.Descripcion;
            comando.Parameters.Add("@Tipo", SqlDbType.VarChar);
            comando.Parameters["@Tipo"].Value = producto.Tipo;
            comando.Parameters.Add("@Precio", SqlDbType.VarChar);
            comando.Parameters["@Precion"].Value = producto.Precio;

            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }

        //Borrar un registro especifico de la DB\
        public int Borrar(int Id)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("Delete from Productos where Id=@Id", con);
            
            comando.Parameters.Add("@Id", SqlDbType.Int);
            comando.Parameters["@Id"].Value = Id;
            
            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}