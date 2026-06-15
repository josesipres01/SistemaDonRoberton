using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNPedido
    {
        public static DataTable Listar()
        {
            return new CDPedido().Listar();
        }

        public static string Insertar(DateTime fecha, int idproveedor, int idusuario, double total, string estado, List<CDDetallePedido> detalles)
        {
            CDPedido objeto = new CDPedido();
            objeto.Fecha = fecha;
            objeto.Idproveedor = idproveedor;
            objeto.Idusuario = idusuario;
            objeto.Total = total;
            objeto.Estado = estado;
            objeto.Detalles = detalles;

            return objeto.Insertar(objeto);
        }
        public static string Recibir(int id)
        {
            return new CDPedido().Recibir(id);
        }
        public static string Cancelar(int id)
        {
            return new CDPedido().Cancelar(id);
        }
        public static DataTable ObtenerDetalles(int id)
        {
            return new CDPedido().ObtenerDetalles(id);
        }
        public static string Editar(int idpedido, double total, List<CDDetallePedido> detalles)
        {
            CDPedido objeto = new CDPedido();
            objeto.Idpedido = idpedido;
            objeto.Total = total;
            objeto.Detalles = detalles;

            return objeto.Editar(objeto);
        }
        public static string FinalizarRecepcionItem(int idped, int idprod, int cant)
        {
            return new CDPedido().FinalizarRecepcionItem(idped, idprod, cant);
        }
        public static DataTable BuscarID(int id)
        {
            return new CDPedido().BuscarID(id);
        }

        public static DataTable BuscarProveedor(string nombre)
        {
            return new CDPedido().BuscarProveedor(nombre);
        }
    }

}
