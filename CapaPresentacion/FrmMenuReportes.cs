using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MenuReportes : Form
    {
        PantallaInicio objetoPadre = (PantallaInicio)Application.OpenForms["PantallaInicio"];

        public MenuReportes()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmodificaciones_Click(object sender, EventArgs e)
        {

            if (objetoPadre != null)
            {
                FrmReporteClienteUpdate form = new FrmReporteClienteUpdate { };

                objetoPadre.AbrirFormulario(form);

                this.Close();
            }
        }

        private void btnelimaciones_Click(object sender, EventArgs e)
        {
            if (objetoPadre != null)
            {
                FrmReporteClienteDelete form = new FrmReporteClienteDelete { };

                objetoPadre.AbrirFormulario(form);

                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReporteSesion_Click(object sender, EventArgs e)
        {
            if (objetoPadre != null)
            {
                FrmReporteSesiones form = new FrmReporteSesiones { };

                objetoPadre.AbrirFormulario(form);

                this.Close();
            }
        }

        private void MenuReportes_Load(object sender, EventArgs e)
        {

        }
    }
}
