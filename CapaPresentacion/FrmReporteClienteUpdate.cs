using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteClienteUpdate : Form
    {
        public FrmReporteClienteUpdate()
        {
            InitializeComponent();
        try
            {
                CargarDatosUpdates();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
       
        public void CargarDatosUpdates()
        {
            DataTable dt = CNBitacora.MostrarUpdates();

            this.dlistado.DataSource = dt;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmReporteClienteUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
