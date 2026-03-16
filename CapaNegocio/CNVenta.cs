using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos; // Importante para acceder a CDVenta y CDDetalleVenta

namespace CapaNegocio
{
    public class CNVenta
    {
        // Método para listar las ventas 
        public static DataTable Listar()
        {
            CDVenta Datos = new CDVenta();
            return Datos.Listar();
        }

        // Método Insertar 
        public static string Insertar(DateTime fecha, double subtotal, double iva, double total,
                                    int idcliente, int idcajero, int idmetodopago,
                                    List<CDDetalleVenta> detalles)
        {
            CDVenta Datos = new CDVenta();

            Datos.Fecha = fecha;
            Datos.Subtotal = subtotal;
            Datos.Iva = iva;
            Datos.Total = total;
            Datos.Idcliente = idcliente;
            Datos.Idcajero = idcajero;
            Datos.Idmetodopago = idmetodopago;

            Datos.Detalles = detalles;

            return Datos.Guardar(Datos);
        }
    }
}