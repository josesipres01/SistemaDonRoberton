using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDProveedor
    {
        public DataTable Listar()
        {

            DataTable resul = new DataTable("proveedor");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand Cmd = new SqlCommand("splistar_proveedor", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(resul);
            }
            catch (Exception ex)
            {
                resul = null;
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return resul;
        }
    }
}
