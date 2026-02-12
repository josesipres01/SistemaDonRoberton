using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNBitacora
    {
        public static DataTable MostrarUpdates()
        {
            return new CDBitacora().ListarActualizaciones();
        }
        public static DataTable MostrarEliminaciones()
        {
            return new CDBitacora().ListarEliminaciones();
        }
    }
}
    