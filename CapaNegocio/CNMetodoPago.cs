using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNMetodoPago
    {
        public static DataTable Listar()
        {
            return new CDMetodoPago().Listar();
        }
    }
}
