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



    }
}
