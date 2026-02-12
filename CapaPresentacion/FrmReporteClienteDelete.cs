using CapaNegocio;
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
    public partial class FrmReporteClienteDelete : Form
    {
        public FrmReporteClienteDelete()
        {
            InitializeComponent();
            try
            {
                CargarDatosDelete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        public void CargarDatosDelete()
        {
            DataTable dt = CNBitacora.MostrarEliminaciones();

            this.dlistado.DataSource = dt;
        }



        private void btneliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmReporteClienteDelete_Load(object sender, EventArgs e)
        {

        }
    }
}
