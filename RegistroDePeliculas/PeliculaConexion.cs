using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RegistroDePeliculas
{
    class PeliculaConexion
    {
        public static int Agregar(Pelicula pelicula)
        {
            int retorno = 0;
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("insert into Categorias(titulo,descripcion) values('{0}','{1}')", pelicula.Titulo, pelicula.Descripcion),con);
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }
        public static List<Pelicula> BuscarPeliculas(int id)
        {
            List<Pelicula> lista = new List<Pelicula>();
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("select *from Categorias where categoriaId like '%{0}%'",id), conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while(reader.Read())
                {
                    Pelicula p = new  Pelicula();
                    p.Id = reader.GetInt32(0);
                    p.Titulo = reader.GetString(1);
                    p.Descripcion = reader.GetString(2);

                    lista.Add(p);
                }
                conexion.Close();
                return lista;
            }
        }
    }
}
