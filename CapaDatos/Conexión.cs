using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexión
    {
        public static string Conn = "Data Source=LAPTOP-RF1M8NB9; Initial Catalog=sistemaDonRoberton;Integrated Security=True";

        public static SqlConnection CrearConexion()
        {
            SqlConnection cadenaConex = new SqlConnection();
            try
            {
                cadenaConex.ConnectionString = Conn;
            }
            catch (Exception ex)
            {
                cadenaConex = null;
                throw ex;
            }
            return cadenaConex;
        }

    }
}
