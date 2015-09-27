using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RegistroDePeliculas
{
    class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection con = new SqlConnection("Data source = JUNIOR-PC\\ROOT;Initial Catalog = Pelicula;Integrated Security = true");
            con.Open();

            return con;
        }
    }
}
