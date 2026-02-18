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
            FrmReporteClienteUpdate frmupdate = new FrmReporteClienteUpdate();

          
            frmupdate.ShowDialog();
        }

        private void btnelimaciones_Click(object sender, EventArgs e)
        {
            FrmReporteClienteDelete frmDelete = new FrmReporteClienteDelete();

            frmDelete.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReporteSesion_Click(object sender, EventArgs e)
        {
            FrmReporteSesiones frmSesiones= new FrmReporteSesiones();
            frmSesiones.ShowDialog();
        }
    }
}
