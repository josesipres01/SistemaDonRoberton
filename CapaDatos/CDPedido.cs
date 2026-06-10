using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDPedido
    {
        public int Idpedido { get; set; }
        public DateTime Fecha { get; set; }
        public int Idproveedor { get; set; }
        public int Idusuario { get; set; }
        public double Total { get; set; }
        public string Estado { get; set; }

        // Lista de detalles 
        public List<CDDetallePedido> Detalles { get; set; } = new List<CDDetallePedido>();

        public string Insertar(CDPedido Pedido)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Conn;
                SqlCon.Open();
                SqlTransaction SqlTra = SqlCon.BeginTransaction();

                // 1. Guardar Pedido
                SqlCommand Cmd = new SqlCommand("spguardar_pedido", SqlCon, SqlTra);
                Cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter("@idpedido", SqlDbType.Int);
                parId.Direction = ParameterDirection.Output;
                Cmd.Parameters.Add(parId);

                Cmd.Parameters.AddWithValue("@fecha", Pedido.Fecha);
                Cmd.Parameters.AddWithValue("@idproveedor", Pedido.Idproveedor);
                Cmd.Parameters.AddWithValue("@idusuario", Pedido.Idusuario);
                Cmd.Parameters.AddWithValue("@total", Pedido.Total);
                Cmd.Parameters.AddWithValue("@estado", Pedido.Estado);

                Cmd.ExecuteNonQuery();
                int idGenerado = Convert.ToInt32(Cmd.Parameters["@idpedido"].Value);

                // 2. Guardar Detalles
                foreach (var det in Pedido.Detalles)
                {
                    SqlCommand CmdDet = new SqlCommand("spguardar_detallepedido", SqlCon, SqlTra);
                    CmdDet.CommandType = CommandType.StoredProcedure;

                    // --- AQUÍ ESTÁ LA CORRECCIÓN: Agregar el parámetro OUTPUT ---
                    SqlParameter parIdDetalle = new SqlParameter();
                    parIdDetalle.ParameterName = "@iddetallepedido";
                    parIdDetalle.SqlDbType = SqlDbType.Int;
                    parIdDetalle.Direction = ParameterDirection.Output; // Importante: Salida
                    CmdDet.Parameters.Add(parIdDetalle);
                    // ----------------------------------------------------------

                    CmdDet.Parameters.AddWithValue("@idpedido", idGenerado);
                    CmdDet.Parameters.AddWithValue("@idproducto", det.Idproducto);
                    CmdDet.Parameters.AddWithValue("@cantidad", det.Cantidad);
                    CmdDet.Parameters.AddWithValue("@precio_compra", det.PrecioCompra);
                    CmdDet.Parameters.AddWithValue("@subtotal", det.Subtotal);

                    // Ejecutamos el detalle
                    CmdDet.ExecuteNonQuery();
                    rpta = "OK";

                    if (rpta != "OK") break;
                }

                if (rpta.Equals("OK")) SqlTra.Commit();
                else SqlTra.Rollback();
            }
            catch (Exception ex) { rpta = ex.Message; }
            finally { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); }
            return rpta;
        }

        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexión.Conn))
            {
                SqlCommand cmd = new SqlCommand("splistar_pedido", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
        public string Recibir(int id)
        {
            string rpta = "";
            using (SqlConnection con = new SqlConnection(Conexión.Conn))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sprecibir_pedido", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idpedido", id);

                    cmd.ExecuteNonQuery();
                    rpta = "OK";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            }
            return rpta;
        }
        public string Cancelar(int id)
        {
            string rpta = "";
            using (SqlConnection con = new SqlConnection(Conexión.Conn))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spcancelar_pedido", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idpedido", id);
                    cmd.ExecuteNonQuery();
                    rpta = "OK";
                }
                catch (Exception ex) { rpta = ex.Message; }
            }
            return rpta;
        }
        public DataTable ObtenerDetalles(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexión.Conn))
            {
                SqlCommand cmd = new SqlCommand("spbuscar_detallepedido", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpedido", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
        public string Editar(CDPedido Pedido)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Conn;
                SqlCon.Open();
                SqlTransaction SqlTra = SqlCon.BeginTransaction();

                // 1. Actualizar el Total en la Cabecera
                SqlCommand CmdTotal = new SqlCommand("spactualizar_pedido_total", SqlCon, SqlTra);
                CmdTotal.CommandType = CommandType.StoredProcedure;
                CmdTotal.Parameters.AddWithValue("@idpedido", Pedido.Idpedido);
                CmdTotal.Parameters.AddWithValue("@total", Pedido.Total);
                CmdTotal.ExecuteNonQuery();

                // 2. Borrar los detalles anteriores
                SqlCommand CmdDel = new SqlCommand("speliminar_detalles_pedido", SqlCon, SqlTra);
                CmdDel.CommandType = CommandType.StoredProcedure;
                CmdDel.Parameters.AddWithValue("@idpedido", Pedido.Idpedido);
                CmdDel.ExecuteNonQuery();

                // 3. Insertar los nuevos detalles (reutilizamos tu SP de guardar detalle)
                foreach (var det in Pedido.Detalles)
                {
                    SqlCommand CmdDet = new SqlCommand("spguardar_detallepedido", SqlCon, SqlTra);
                    CmdDet.CommandType = CommandType.StoredProcedure;

                    // Parámetro output para el ID del detalle (aunque no lo usemos aquí, SQL lo pide)
                    SqlParameter parIdDet = new SqlParameter("@iddetallepedido", SqlDbType.Int);
                    parIdDet.Direction = ParameterDirection.Output;
                    CmdDet.Parameters.Add(parIdDet);

                    CmdDet.Parameters.AddWithValue("@idpedido", Pedido.Idpedido);
                    CmdDet.Parameters.AddWithValue("@idproducto", det.Idproducto);
                    CmdDet.Parameters.AddWithValue("@cantidad", det.Cantidad);
                    CmdDet.Parameters.AddWithValue("@precio_compra", det.PrecioCompra);
                    CmdDet.Parameters.AddWithValue("@subtotal", det.Subtotal);

                    CmdDet.ExecuteNonQuery();
                }

                SqlTra.Commit(); // Si todo salió bien, guardamos
                rpta = "OK";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); }
            return rpta;
        }
    }

    // Clase para los items del pedido
    public class CDDetallePedido
    {
        public int Idproducto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioCompra { get; set; }
        public double Subtotal { get; set; }
    }

}

