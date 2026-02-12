using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class CDBitacora
    {
        public DataTable ListarActualizaciones()
        {
            DataTable resultado = new DataTable("bitacora_clientes");

            using (SqlConnection conexion = new SqlConnection(Conexión.Conn))
            {
                using (SqlCommand cmd = new SqlCommand("sp_listar_updates_bitacora", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(resultado);
                    }
                }
            }

            return resultado;
        }


        public DataTable ListarEliminaciones()
        {
            DataTable resultado = new DataTable("bitacora_eliminados");

            using (SqlConnection conexion = new SqlConnection(Conexión.Conn))
            {
                using (SqlCommand cmd = new SqlCommand("sp_listar_delete_bitacora", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(resultado);
                    }
                }
            }
            return resultado;
        }
    }
}
