using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNUsuario
    {
        public bool LoginAdministrador(string user, string pass)
        {
            CDUsuario objetoCD= new CDUsuario();
            return objetoCD.ValidarAccesoAdmin(user, pass);
        }
    }
}
