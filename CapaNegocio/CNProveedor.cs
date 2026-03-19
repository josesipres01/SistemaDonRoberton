using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNProveedor
    {

        public static DataTable Listar()
        {
            CDProveedor Datos = new CDProveedor();
            return Datos.Listar();
        }

        public static string Guardar(string nombre, string telefono, string correo, string dni, string rfc, string direccion, string estado)
        {
            CDProveedor objeto = new CDProveedor();
            objeto.Nombre = nombre;
            objeto.Telefono = telefono;
            objeto.Correo = correo;
            objeto.Dni = dni;
            objeto.Rfc = rfc;
            objeto.Direccion = direccion;
            objeto.Estado = estado;

            return objeto.Guardar(objeto);
        }

        public static string Editar(int idproveedor, string nombre, string telefono, string correo, string dni, string rfc, string direccion, string estado)
        {
            CDProveedor objeto = new CDProveedor();
            objeto.Idproveedor = idproveedor; // El ID es vital para el WHERE en SQL
            objeto.Nombre = nombre;
            objeto.Telefono = telefono;
            objeto.Correo = correo;
            objeto.Dni = dni;
            objeto.Rfc = rfc;
            objeto.Direccion = direccion;
            objeto.Estado = estado;

            return objeto.Editar(objeto);
        }

        public static string Eliminar(int idproveedor)
        {
            CDProveedor objeto = new CDProveedor();
            objeto.Idproveedor = idproveedor;
            return objeto.Eliminar(objeto);
        }

        public static DataTable BuscarNombre(string textoBuscar)
        {
            CDProveedor Datos = new CDProveedor();
            Datos.Buscar = textoBuscar;
            return Datos.BuscarNombre(Datos);
        }

        public static DataTable BuscarDni(string textoBuscar)
        {
            CDProveedor Datos = new CDProveedor();
            Datos.Buscar = textoBuscar;
            return Datos.BuscarDni(Datos);
        }




    }
}
