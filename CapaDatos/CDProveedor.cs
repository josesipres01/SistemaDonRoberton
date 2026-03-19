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
        public int Idproveedor { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Dni { get; set; }
        public string Rfc { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }

        public string Buscar { get; set; }


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

        public string Guardar(CDProveedor prov)
        {
            string res = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();
                SqlCommand cmd = new SqlCommand("spguardar_proveedor", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproveedor", prov.Idproveedor);
                cmd.Parameters.AddWithValue("@nombre", prov.Nombre);
                cmd.Parameters.AddWithValue("@telefono", prov.Telefono);
                cmd.Parameters.AddWithValue("@correo", prov.Correo);
                cmd.Parameters.AddWithValue("@dni", prov.Dni);
                cmd.Parameters.AddWithValue("@rfc", prov.Rfc);
                cmd.Parameters.AddWithValue("@direccion", prov.Direccion);
                cmd.Parameters.AddWithValue("@estado", prov.Estado);

                res = cmd.ExecuteNonQuery() == 1 ? "OK" : "no se guardaron los datos";
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return res;
        }

        public string Editar(CDProveedor prov)
        {
            string res = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();
                SqlCommand cmd = new SqlCommand("speditar_proveedor", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproveedor", prov.Idproveedor);
                cmd.Parameters.AddWithValue("@nombre", prov.Nombre);
                cmd.Parameters.AddWithValue("@telefono", prov.Telefono);
                cmd.Parameters.AddWithValue("@correo", prov.Correo);
                cmd.Parameters.AddWithValue("@dni", prov.Dni);
                cmd.Parameters.AddWithValue("@rfc", prov.Rfc);
                cmd.Parameters.AddWithValue("@direccion", prov.Direccion);
                cmd.Parameters.AddWithValue("@estado", prov.Estado);
                res = cmd.ExecuteNonQuery() == 1 ? "OK" : "no se editaron los datos";
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return res;
        }

        public string Eliminar(CDProveedor prov)
        {
            string res = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                conexion.Open();

                // 1. Cambiamos el nombre del procedimiento a llamar
                SqlCommand cmd = new SqlCommand("spdesactivar_proveedor", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                // 2. Solo pasamos el ID para saber a quién desactivar
                cmd.Parameters.AddWithValue("@idproveedor", prov.Idproveedor);

                // 3. Ejecutamos (Si devuelve 1 fila afectada, todo salió bien)
                res = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el proveedor";
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return res;
        }

        public DataTable BuscarNombre(CDProveedor prov)
        {
            DataTable resul = new DataTable("proveedor");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand cmd = new SqlCommand("spbuscar_proveedor_nombre", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", prov.Buscar);

                SqlDataAdapter sqldat = new SqlDataAdapter(cmd);
                sqldat.Fill(resul);
            }
            catch (Exception ex)
            {
                resul = null;
            }
            return resul;
        }

        public DataTable BuscarDni(CDProveedor prov)
        {
            DataTable resul = new DataTable("proveedor");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand cmd = new SqlCommand("spbuscar_proveedor_dni", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", prov.Buscar);

                SqlDataAdapter sqldat = new SqlDataAdapter(cmd);
                sqldat.Fill(resul);
            }
            catch (Exception ex)
            {
                resul = null;
            }
            return resul;
        }
    }
}
