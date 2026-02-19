using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNCliente
    {
        public static DataTable Listar()
        {
            CDCliente Datos = new CDCliente();
            return Datos.Listar();
        }


        public static string Guardar(string nombre, string apellidos, string rfc, string telefono, string correo)
        {
            CDCliente Datos = new CDCliente();
            Datos.Nombre = nombre;
            Datos.Apellidos = apellidos;
            Datos.Rfc = rfc;
            Datos.Telefono = telefono;
            Datos.Correo = correo;
            return Datos.Guardar(Datos);
        }

        public static string Editar(int idcliente, string nombre, string apellidos, string rfc, string telefono, string correo)
        {
            CDCliente Datos = new CDCliente();
            Datos.Idcliente = idcliente;
            Datos.Nombre = nombre;
            Datos.Apellidos = apellidos;
            Datos.Rfc = rfc;
            Datos.Telefono = telefono;
            Datos.Correo = correo;
            return Datos.Editar(Datos);
        }

        public static string Eliminar(int idcliente)
        {
            CDCliente Datos = new CDCliente();
            Datos.Idcliente = idcliente;
            return Datos.Eliminar(Datos);
        }

        public static DataTable BuscarNombre(string textoBuscar)
        {
            CDCliente Datos = new CDCliente();
            Datos.Buscar = textoBuscar;
            return Datos.BuscarNombre(Datos);
        }

        public static DataTable BuscarRfc(string textoBuscar)
        {
            CDCliente Datos = new CDCliente();
            Datos.Buscar = textoBuscar;
            return Datos.BuscarRfc(Datos);
        }

        public DataTable Login(string user, string pass)
        {
            CDUsuario objetoCD = new CDUsuario();
            return objetoCD.ValidarAcceso(user, pass);
        }



    }
}

