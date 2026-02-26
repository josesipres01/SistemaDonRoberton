using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNProducto
    {
        public static DataTable Listar()
        {
            CDProducto Datos = new CDProducto();
            return Datos.Listar();
        }


        public static string Guardar(string nombre, string descripcion,
                                     DateTime fingreso, double pcompra,
                                     double pventa, int stock, int idcategoria, int idproveedor)
        {
            CDProducto Datos = new CDProducto();
            Datos.Nombre = nombre;
            Datos.Descripcion = descripcion;
            Datos.Fingreso = fingreso;
            Datos.Pcompra = pcompra;
            Datos.Pventa = pventa;
            Datos.Stock = stock;
            Datos.Idcategoria = idcategoria;
            Datos.Idproveedor = idproveedor;
            return Datos.Guardar(Datos);
        }

        public static string Editar(int idproducto, string nombre, string descripcion,
                                     DateTime fingreso, double pcompra,
                                     double pventa, int stock, int idcategoria, int idproveedor)
        {
            CDProducto Datos = new CDProducto();
            Datos.Idproducto = idproducto;
            Datos.Nombre = nombre;
            Datos.Descripcion = descripcion;
            Datos.Fingreso = fingreso;
            Datos.Pcompra = pcompra;
            Datos.Stock = stock;
            Datos.Idcategoria = idcategoria;
            Datos.Idproveedor = idproveedor;

            return Datos.Editar(Datos);

        }

        public static string Eliminar(int idproducto)
        {
            CDProducto Datos = new CDProducto();
            Datos.Idproducto = idproducto;
            return Datos.Eliminar(Datos);
        }

        public static DataTable BuscarNombre(string textoBuscar)
        {
            CDProducto Datos = new CDProducto();
            Datos.Buscar = textoBuscar;
            return Datos.BuscarNombre(Datos);
        }

       
    }
}
