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

                    CmdDet.Parameters.AddWithValue("@idpedido", idGenerado);
                    CmdDet.Parameters.AddWithValue("@idproducto", det.Idproducto);
                    CmdDet.Parameters.AddWithValue("@cantidad", det.Cantidad);
                    CmdDet.Parameters.AddWithValue("@precio_compra", det.PrecioCompra); // Tu cambio solicitado
                    CmdDet.Parameters.AddWithValue("@subtotal", det.Subtotal);

                    rpta = CmdDet.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo registrar el producto: " + det.Idproducto;

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

