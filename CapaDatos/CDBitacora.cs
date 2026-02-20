using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
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

        public int RegistrarSesion(string usuario)
        {
            using (SqlConnection conexion = new SqlConnection(Conexión.Conn))
            {
                conexion.Open();
                string query = "INSERT INTO bitacora_accesos(usuario, fecha_entrada) VALUES (@user, GETDATE()); SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@user", usuario);
                return Convert.ToInt32(cmd.ExecuteScalar());


            }
        }
        // Método para registrar la salida
        public void RegistrarSalida(int idAcceso)
        {
            using (SqlConnection con = new SqlConnection(Conexión.Conn))
            {
                con.Open();
                string query = "UPDATE bitacora_accesos SET fecha_salida = GETDATE() WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idAcceso); 
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ListarSesiones()
        {
            using (SqlConnection con = new SqlConnection(Conexión.Conn))
            {
                DataTable dt = new DataTable();
                string query = @"SELECT usuario, 
                                 fecha_entrada, 
                                 fecha_salida, 
                                 CONVERT(varchar, ISNULL(fecha_salida, GETDATE()) - fecha_entrada, 108) AS duracion_segundos 
                                 FROM bitacora_accesos 
                                 ORDER BY fecha_entrada DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }
    }
}
