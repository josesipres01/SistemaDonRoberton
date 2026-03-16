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
    public partial class FrmSeleccionarProductoVenta : Form
    {
        public List<DataGridViewRow> ProductosSeleccionados { get; set; } = new List<DataGridViewRow>();

     

        private void FrmSeleccionarProductoVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            ProductosSeleccionados.Clear();

            foreach (DataGridViewRow row in dseleccionar.Rows)
            {
                // Verificamos si el checkbox está marcado
                bool isSelected = Convert.ToBoolean(row.Cells["chkSeleccionar"].Value);

                if (isSelected)
                {
                    ProductosSeleccionados.Add(row);
                }
            }

            if (ProductosSeleccionados.Count > 0)
            {
                this.DialogResult = DialogResult.OK; // Indica que se aceptó la selección
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione al menos un producto.");
            }

        }

        private void label1_Click(object sender, EventArgs e)
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
    }
}
