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
        public string EstadoRecibido = "";
        string criterioBusqueda = "Proveedor"; 
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

        private void btnrecibir_Click(object sender, EventArgs e)
        {
            if (dlistado.CurrentRow != null)
            {
                if (dlistado.CurrentRow != null)
                {
                    int id = Convert.ToInt32(dlistado.CurrentRow.Cells["idpedido"].Value);

                    FrmRegistrarPedido frm = new FrmRegistrarPedido();
                    frm.IdPedidoCargado = id;
                    frm.ModoRecepcion = true;

                    // PASO 1: Abrimos el formulario primero (esto carga la lista de proveedores)
                    PantallaInicio objetoPadre = (PantallaInicio)Application.OpenForms["PantallaInicio"];
                    objetoPadre.AbrirFormulario(frm);

                    // PASO 2: AHORA SÍ, asignamos el texto del proveedor
                    frm.cbproveedor.Text = Convert.ToString(dlistado.CurrentRow.Cells["Proveedor"].Value);
                }
            }
          }
        

   

        private void btnverdetalle_Click(object sender, EventArgs e)
        {
            if (dlistado.CurrentRow != null)
            {
                int id = Convert.ToInt32(dlistado.CurrentRow.Cells["idpedido"].Value);
                string provNombre = Convert.ToString(dlistado.CurrentRow.Cells["proveedor"].Value);

                // 1. CAPTURAMOS EL ESTADO REAL
                string estado = Convert.ToString(dlistado.CurrentRow.Cells["estado"].Value).ToUpper().Trim();

                FrmRegistrarPedido frm = new FrmRegistrarPedido();
                frm.IdPedidoCargado = id;
                frm.ModoVista = true;

                // 2. PASAMOS EL ESTADO AL FORMULARIO HIJO
                frm.EstadoRecibido = estado;

                PantallaInicio objetoPadre = (PantallaInicio)Application.OpenForms["PantallaInicio"];
                objetoPadre.AbrirFormulario(frm);

                frm.cbproveedor.Text = provNombre;
            }
        }

        private void rbtnid_Click(object sender, EventArgs e)
        {
            criterioBusqueda = "ID";
            txtbuscar.Hint = "Escriba el número de ID...";
            txtbuscar.Clear();
        }

        private void rbtnproveedor_Click(object sender, EventArgs e)
        {
            criterioBusqueda = "Proveedor";
            txtbuscar.Hint = "Escriba el nombre del proveedor...";
            txtbuscar.Clear();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbuscar.Text))
            {
                this.Mostrar(); // Si está vacío, mostramos todos los pedidos
                return;
            }

            if (criterioBusqueda == "ID")
            {
                int id;
                if (int.TryParse(txtbuscar.Text, out id))
                {
                    this.dlistado.DataSource = CNPedido.BuscarID(id);
                }
            }
            else
            {
                this.dlistado.DataSource = CNPedido.BuscarProveedor(txtbuscar.Text);
            }
        }
    }
}
