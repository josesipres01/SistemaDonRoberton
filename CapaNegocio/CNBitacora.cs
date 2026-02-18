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
         CDBitacora cb = new CDBitacora();  
        public static DataTable MostrarUpdates()
        {
            return new CDBitacora().ListarActualizaciones();
        }
        public static DataTable MostrarEliminaciones()
        {
            return new CDBitacora().ListarEliminaciones();
        }

        public int LoginEntrada(string user)
        {
            return cb.RegistrarSesion(user);

        }

        public void LoginSalida(int id)
        {
            cb.RegistrarSalida(id);

        }

        public static DataTable MostrarSesiones()
        {
           return new CDBitacora().ListarSesiones();
        }
    }
}
    