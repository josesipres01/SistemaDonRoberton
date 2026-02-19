using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNUsuario
    {
        public DataTable IniciarSesion(string user, string pass)
        {
            CDUsuario objetoCD = new CDUsuario();
            return objetoCD.ValidarAcceso(user, pass);
        }
    }
}
