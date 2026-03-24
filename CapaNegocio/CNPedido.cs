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
    }
}
