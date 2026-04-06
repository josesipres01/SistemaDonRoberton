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
    public partial class FrmListadoPedidos : Form
    {
        public FrmListadoPedidos()
        {
            InitializeComponent();
        }

        private void FrmListadoPedidos_Load(object sender, EventArgs e)
        {
            this.Mostrar();

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            PantallaInicio objetoPadre = (PantallaInicio)Application.OpenForms["PantallaInicio"];

            // Abrimos el formulario de REGISTRO (el carrito), no el buscador
            objetoPadre.AbrirFormulario(new FrmRegistrarPedido());
        }
        private void Mostrar()
        {
            // Llamamos a la capa de negocio que creamos anteriormente
            this.dlistado.DataSource = CNPedido.Listar();

            // Ocultamos el ID si no quieres que se vea
            if (dlistado.Rows.Count > 0)
            {
                this.dlistado.Columns["idpedido"].Visible = false;
            }
        }

        private void dlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dlistado.CurrentRow != null)
            {
                string estado = Convert.ToString(dlistado.CurrentRow.Cells["estado"].Value);
                if (estado == "CANCELADO")
                {
                    MessageBox.Show("Este pedido ya está cancelado."); return;
                }

                DialogResult opcion = MessageBox.Show("¿Desea cancelar este pedido? Se restará el stock sumado.",
                    "DonRoberton", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dlistado.CurrentRow.Cells["idpedido"].Value);
                    // Aquí llamarías a un método CNPedido.Cancelar(id) que ejecute el SP de arriba
                    this.Mostrar(); // Refrescar
                }
            }   
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dlistado.CurrentRow != null)
            {
                // 1. Validar estado actual
                string estado = Convert.ToString(dlistado.CurrentRow.Cells["estado"].Value);
                if (estado == "RECIBIDO")
                {
                    MessageBox.Show("Este pedido ya fue recibido anteriormente."); return;
                }

                // 2. Confirmación
                DialogResult op = MessageBox.Show("¿Confirmas que la mercancía ha llegado? El stock se sumará ahora.",
                    "DonRoberton", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (op == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dlistado.CurrentRow.Cells["idpedido"].Value);
                    string rpta = CNPedido.Recibir(id);

                    if (rpta == "OK")
                    {
                        MessageBox.Show("¡Inventario actualizado con éxito!");
                        this.Mostrar(); // Refrescar la tabla
                    }
                    else
                    {
                        MessageBox.Show(rpta);
                    }
                }
            }
        }
    }
}
