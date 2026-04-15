using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CNRespaldo
    {
        private CDRespaldo objDato = new CDRespaldo();

        public bool CrearCopia(string ruta) => objDato.GenerarBackup(ruta);

        public bool CargarCopia(string ruta) => objDato.RestaurarBackup(ruta);
    }
}