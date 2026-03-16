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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

        }

        private void rbtnrfc_Click(object sender, EventArgs e)
        {

        }

        private void rbtnnombre_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscar_Click(object sender, EventArgs e)
        {

        }

        private void dlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            cbcliente.DataSource = CNCliente.Listar();
            cbcliente.DisplayMember = "nombre"; 
            cbcliente.ValueMember = "idcliente"; 
            cbcliente.SelectedIndex = -1;
            cbcliente.Text = "PÚBLICO GENERAL"; 
        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
