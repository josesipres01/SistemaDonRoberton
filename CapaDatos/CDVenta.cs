using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{

    public class CDDetalleVenta
    {
        public int Idproducto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public double TotalDetalle { get; set; }

    }


    public class CDVenta
    {
        public int Idventa { get; set; }
        public DateTime Fecha { get; set; }
        public double Subtotal { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
        public int Idcliente { get; set; }
        public int Idcajero { get; set; }
        public int Idmetodopago { get; set; }


        public List<CDDetalleVenta> Detalles { get; set; } = new List<CDDetalleVenta>();


        public DataTable Listar()
        {
            DataTable result = new DataTable("venta");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexión.Conn;
                SqlCommand Cmd = new SqlCommand("splistar_venta", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(result);
            }
            catch (Exception ex)
            {
                result = null;
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

        public string Insertar(CDVenta Venta)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Conn;
                SqlCon.Open();
                SqlTransaction SqlTra = SqlCon.BeginTransaction();

                // 1. Insertar Cabecera de Venta
                SqlCommand CmdVenta = new SqlCommand("spguardar_venta", SqlCon, SqlTra);
                CmdVenta.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdVenta = new SqlParameter();
                parIdVenta.ParameterName = "@idventa";
                parIdVenta.SqlDbType = SqlDbType.Int;
                parIdVenta.Direction = ParameterDirection.Output;
                CmdVenta.Parameters.Add(parIdVenta);

                CmdVenta.Parameters.AddWithValue("@fecha", Venta.Fecha);
                CmdVenta.Parameters.AddWithValue("@subtotal", Venta.Subtotal);
                CmdVenta.Parameters.AddWithValue("@iva", Venta.Iva);
                CmdVenta.Parameters.AddWithValue("@total", Venta.Total);
                CmdVenta.Parameters.AddWithValue("@idcliente", Venta.Idcliente);
                CmdVenta.Parameters.AddWithValue("@idcajero", Venta.Idcajero);
                CmdVenta.Parameters.AddWithValue("@idmetodopago", Venta.Idmetodopago);

                // Obtenemos el ID de la venta generada
                CmdVenta.ExecuteNonQuery();
                int idVentaGenerada = Convert.ToInt32(CmdVenta.Parameters["@idventa"].Value);


                // 2. Insertar Detalles uno por uno (Esto activa tu Trigger de SQL)
                foreach (var det in Venta.Detalles)
                {
                    SqlCommand CmdDet = new SqlCommand("spguardar_detalleventa", SqlCon, SqlTra);
                    CmdDet.CommandType = CommandType.StoredProcedure;

                    // Parámetro de salida para el ID del detalle (según tu SP)
                    SqlParameter parIdDetalle = new SqlParameter("@iddetalleventa", SqlDbType.Int);
                    parIdDetalle.Direction = ParameterDirection.Output;
                    CmdDet.Parameters.Add(parIdDetalle);

                    CmdDet.Parameters.AddWithValue("@cantidad", det.Cantidad);
                    CmdDet.Parameters.AddWithValue("@preciounitario", det.PrecioUnitario);
                    CmdDet.Parameters.AddWithValue("@total", det.TotalDetalle); // Cantidad * Precio
                    CmdDet.Parameters.AddWithValue("@idventa", idVentaGenerada);
                    CmdDet.Parameters.AddWithValue("@idproducto", det.Idproducto);

                    CmdDet.ExecuteNonQuery();
                    rpta = "OK";
                }

                if (rpta.Equals("OK")) SqlTra.Commit(); // Se guarda todo
                else SqlTra.Rollback(); // Si algo falló, se cancela todo
            }
            catch (Exception ex) { rpta = ex.Message; }
            finally { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); }
            return rpta;
        }
    }

   
}

