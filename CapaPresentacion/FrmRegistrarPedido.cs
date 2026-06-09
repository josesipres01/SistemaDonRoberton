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
            if (cbproveedor.SelectedValue == null || cbproveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione primero el proveedor.", "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmSeleccionarProductoPedido buscador = new FrmSeleccionarProductoPedido();
            buscador.IdProveedorSeleccionado = Convert.ToInt32(cbproveedor.SelectedValue);

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                // Limpiamos para no duplicar si ya había algo (opcional)
                foreach (DataRow fila in buscador.ProductosSeleccionados.Rows)
                {
                    int id = Convert.ToInt32(fila["idproducto"]);
                    string nombre = fila["nombre"].ToString();
                    double precio = Convert.ToDouble(fila["precio_compra"]); // PRECIO DE COMPRA
                    int cantidad = Convert.ToInt32(fila["cantidad"]);
                    double subtotal = precio * cantidad;

                    // Asegúrate de que las columnas en tu dlistadocompra se llamen así internamente
                    dlistadocompra.Rows.Add(id, nombre, cantidad, precio, subtotal);
                }

                this.CalcularGranTotal();

                if (dlistadocompra.Rows.Count > 0)
                    cbproveedor.Enabled = false; // Bloqueamos el proveedor
            }
        }

        // 2. Corregimos el Cálculo del Total (que se vea en los Textbox)
        private void CalcularGranTotal()
        {
            double subtotalAcumulado = 0;
            foreach (DataGridViewRow fila in dlistadocompra.Rows)
            {
                if (fila.Cells["cantidad"].Value != null)
                {
                    // Nota: Verifica que el nombre de la columna sea "precio_unit" o "precio"
                    double cant = Convert.ToDouble(fila.Cells["cantidad"].Value);
                    double precio = Convert.ToDouble(fila.Cells["precio_unit"].Value);
                    subtotalAcumulado += (cant * precio);
                }
            }

            // Mostramos los resultados en tus controles
            tboxsubtotal.Text = subtotalAcumulado.ToString("N2");
            tboxiva.Text = (subtotalAcumulado * 0.16).ToString("N2");
            tboxtotal.Text = (subtotalAcumulado * 1.16).ToString("N2");
        }

        // 3. Corregimos el evento Load (Asegúrate de que en el rayito de eventos diga este nombre)
        private void FrmRegistrarPedido_Load(object sender, EventArgs e)
        {
            cbproveedor.DataSource = CNProveedor.Listar();
            cbproveedor.DisplayMember = "nombre";
            cbproveedor.ValueMember = "idproveedor";
            cbproveedor.SelectedIndex = -1;

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Verificamos que haya una fila seleccionada y que no sea la fila vacía del final
                if (dlistadocompra.CurrentRow != null && !dlistadocompra.CurrentRow.IsNewRow)
                {
                    // 2. Pedimos confirmación (Opcional, para evitar errores del cajero)
                    DialogResult opcion = MessageBox.Show("¿Desea quitar este producto del pedido?",
                                                        "DonRoberton", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (opcion == DialogResult.Yes)
                    {
                        // 3. Eliminamos la fila seleccionada
                        dlistadocompra.Rows.RemoveAt(dlistadocompra.CurrentRow.Index);

                        // 4. Recalculamos los totales generales
                        this.CalcularGranTotal();

                        // 5. MEJORA: Si la tabla queda vacía, volvemos a habilitar el combo de proveedor
                        // (Por si el usuario se equivocó de proveedor y quiere cambiarlo)
                        if (dlistadocompra.Rows.Count == 0 || (dlistadocompra.AllowUserToAddRows && dlistadocompra.Rows.Count == 1))
                        {
                            cbproveedor.Enabled = true;
                        }

                        MessageBox.Show("Producto eliminado de la lista.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione el producto que desea eliminar.",
                                    "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
    }
}   
