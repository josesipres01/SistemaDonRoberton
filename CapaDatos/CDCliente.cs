using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Globalization;

namespace CapaDatos
{
    public class CDCliente
    {
        public int Idcliente { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public String Rfc { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Buscar { get; set; }

        public DataTable Listar()
        {
            DataTable result = new DataTable("cliente");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand Cmd = new SqlCommand("splistar_cliente", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;
                    
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(result);
            }
            catch (Exception ex)
            {
                result = null;
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();

                }

            }
            return result;

        }

        public string Guardar(CDCliente cli)
        {
            string result = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("spguardar_cliente", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@idcliente", SqlDbType.Int).Direction = ParameterDirection.Output;
                Cmd.Parameters.AddWithValue("@nombre", cli.Nombre);
                Cmd.Parameters.AddWithValue("@apellidos", cli.Apellidos);
                Cmd.Parameters.AddWithValue("rfc", cli.Rfc);
                Cmd.Parameters.AddWithValue("telefono", cli.Telefono);
                Cmd.Parameters.AddWithValue("correo", cli.Correo);

                result = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el registro";

            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();

            }
            return result;
        }

        public string Editar(CDCliente cli)
        {
            string result = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("speditar_cliente", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@idcliente", cli.Idcliente);
                Cmd.Parameters.AddWithValue("@nombre", cli.Nombre);
                Cmd.Parameters.AddWithValue("@apellidos", cli.Apellidos);
                Cmd.Parameters.AddWithValue("rfc", cli.Rfc);
                Cmd.Parameters.AddWithValue("telefono", cli.Telefono);
                Cmd.Parameters.AddWithValue("correo", cli.Correo);

                result = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo editar el registro";

            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();

            }
            return result;
        }

        public string Eliminar(CDCliente cli)
        {
            string result = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("speliminar_cliente", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@idcliente", cli.Idcliente);

                result = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";

            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();

            }
            return result;
        }
        public DataTable BuscarNombre(CDCliente cli)
        {
            DataTable result = new DataTable("cliente");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand Cmd = new SqlCommand("spbuscar_cliente_nombre", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@nombre", cli.Buscar);
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(result);


            }
            catch (Exception ex)
            {
                result = null;
                throw ex;
            }

            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();

            }
            return result;
        }

        public DataTable BuscarRfc(CDCliente cli)
        {
            DataTable result = new DataTable("cliente");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand Cmd = new SqlCommand("spbuscar_cliente_rfc", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@rfc", cli.Buscar);
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(result);

            }
            catch (Exception ex)
            {
                result = null;
                throw ex;
            }

            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();

            }
            return result;
        }


    }
}
