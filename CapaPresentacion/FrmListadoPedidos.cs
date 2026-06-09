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

            objetoPadre.AbrirFormulario(new FrmRegistrarPedido());
        }
        private void Mostrar()

        {
            this.dlistado.AutoGenerateColumns = false;

            this.dlistado.DataSource = CNPedido.Listar();

            if (dlistado.Rows.Count > 0)
            {
                this.dlistado.Columns["idpedido"].Visible = true;
            }
        }

        private void dlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dlistado.CurrentRow != null)
            {
                string idTexto = Convert.ToString(dlistado.CurrentRow.Cells["idpedido"].Value);
                string estado = Convert.ToString(dlistado.CurrentRow.Cells["estado"].Value).ToUpper().Trim();

                if (string.IsNullOrEmpty(idTexto)) return;

                int id = Convert.ToInt32(idTexto);
                string mensaje = (estado == "RECIBIDO")
                    ? "¿Desea regresar este pedido a PENDIENTE? El stock se restará."
                    : "¿Desea ELIMINAR este pedido pendiente de forma permanente?";

                DialogResult opcion = MessageBox.Show(mensaje, "DonRoberton", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (opcion == DialogResult.Yes)
                {
                    // --- AQUÍ SE HACE LA MAGIA ---
                    string rpta = CNPedido.Cancelar(id);

                    if (rpta == "OK")
                    {
                        MessageBox.Show("Operación realizada con éxito.");
                        this.Mostrar(); // Refrescamos la tabla para ver los cambios
                    }
                    else
                    {
                        MessageBox.Show("Error: " + rpta);
                    }
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
                    string idTexto = Convert.ToString(dlistado.CurrentRow.Cells["idpedido"].Value);
                    MessageBox.Show("ID capturado: " + idTexto);

                    if (string.IsNullOrEmpty(idTexto))
                    {
                        MessageBox.Show("No se pudo obtener el ID del pedido. Revisa el nombre de la columna.");
                        return;
                    }
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
