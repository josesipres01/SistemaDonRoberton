using CapaDatos;
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
    public partial class FrmRegistrarPedido : Form
    {
        public FrmRegistrarPedido()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)

        {
            // VALIDACIÓN: Si no ha seleccionado proveedor, no lo dejamos abrir el buscador
            if (cbproveedor.SelectedValue == null || cbproveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione primero el proveedor para filtrar sus productos.",
                                "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si pasó la validación, abrimos el buscador pasándole el ID del proveedor
            FrmSeleccionarProductoPedido buscador = new FrmSeleccionarProductoPedido();
            buscador.IdProveedorSeleccionado = Convert.ToInt32(cbproveedor.SelectedValue); // Le pasamos el ID

            if (buscador.ShowDialog() == DialogResult.OK)
            {

                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    foreach (DataRow fila in buscador.ProductosSeleccionados.Rows)
                    {
                        int id = Convert.ToInt32(fila["idproducto"]);
                        string nombre = fila["nombre"].ToString();
                        double precio = Convert.ToDouble(fila["precio_venta"]);
                        int cantidad = Convert.ToInt32(fila["cantidad"]);
                        double subtotal = precio * cantidad;

                        dlistadocompra.Rows.Add(id, nombre, cantidad, precio, subtotal);
                    }

                    this.CalcularGranTotal();
                }
                if (dlistadocompra.Rows.Count > 0)
                {
                    cbproveedor.Enabled = false; // Bloqueamos el combo para no cambiar de proveedor a mitad del pedido
                }
            }




        }
        private void CalcularGranTotal()
        {
            double subtotalAcumulado = 0;
            double porcentajeIva = 0.16; // 16% de IVA

            // 1. Recorremos la tabla para sumar los subtotales de cada fila
            foreach (DataGridViewRow fila in dlistadocompra.Rows)
            {
                if (fila.Cells["cantidad"].Value != null && fila.Cells["precio_unit"].Value != null)
                {
                    // Calculamos: Cantidad * Precio Unitario
                    double cant = Convert.ToDouble(fila.Cells["cantidad"].Value);
                    double precio = Convert.ToDouble(fila.Cells["precio_unit"].Value);

                    subtotalAcumulado += (cant * precio);
                }
            }
        }

        private void FrmListadoPedido_Load(object sender, EventArgs e)
        {
            // 1. Cargamos los proveedores
            cbproveedor.DataSource = CNProveedor.Listar();
            cbproveedor.DisplayMember = "nombre";
            cbproveedor.ValueMember = "idproveedor";
            cbproveedor.SelectedIndex = -1;

            // 2. Mostramos el usuario que inició sesión
            cbusuario.Text = Sesion.Usuario;
        }

        private void btnrealizarventa_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. VALIDACIONES
                if (dlistadocompra.Rows.Count == 0)
                {
                    MessageBox.Show("No hay productos en el pedido."); return;
                }
                if (cbproveedor.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un proveedor."); return;
                }

                // 2. PREPARAR LOS DETALLES
                List<CDDetallePedido> detalles = new List<CDDetallePedido>();
                foreach (DataGridViewRow fila in dlistadocompra.Rows)
                {
                    if (fila.Cells["idproducto"].Value != null)
                    {
                        CDDetallePedido det = new CDDetallePedido();
                        det.Idproducto = Convert.ToInt32(fila.Cells["idproducto"].Value);
                        det.Cantidad = Convert.ToInt32(fila.Cells["cantidad"].Value);
                        det.PrecioCompra = Convert.ToDouble(fila.Cells["precio_unit"].Value);
                        det.Subtotal = det.Cantidad * det.PrecioCompra;
                        detalles.Add(det);
                    }
                }

                // 3. LLAMAR A LA CAPA DE NEGOCIO
                // Enviamos el pedido como "PENDIENTE"
                string rpta = CNPedido.Insertar(
                    DateTime.Now,
                    Convert.ToInt32(cbproveedor.SelectedValue),
                    Sesion.IdUsuario,
                    Convert.ToDouble(tboxtotal.Text),
                    "PENDIENTE",
                    detalles
                );

                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("¡Pedido registrado como PENDIENTE!\nRecuerda confirmarlo en el listado cuando llegue la mercancía.");
                    this.Close(); // Cerramos y volvemos al listado
                }
                else
                {
                    MessageBox.Show("Error: " + rpta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico: " + ex.Message);
            }
        }
    }
}   
