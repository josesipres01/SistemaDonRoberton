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
    public partial class FrmVenta : Form
    {


        public FrmVenta()
        {
            InitializeComponent();
        }



        private void FrmVenta_Load(object sender, EventArgs e)
        {

            LlenarComboClientes();
            LlenarComboUsuarios();
            LlenarComboMetodoPago();
        }

        public void LlenarComboClientes()
        {
            DataTable dt = CNCliente.Listar();
            dt.Columns.Add("NombreCompleto", typeof(string), "nombre + ' ' + apellidos");
            cbcliente.DataSource = dt;
            cbcliente.DisplayMember = "NombreCompleto";
            cbcliente.ValueMember = "idcliente";
            cbcliente.SelectedIndex = -1;
            cbcliente.Text = "PÚBLICO GENERAL";
        }

        public void LlenarComboUsuarios()
        {
            cbcajero.Text = Sesion.Usuario;
            cbcajero.Enabled = false;
        }
        public void LlenarComboMetodoPago()
        {
            cbmetodopago.DataSource = CNMetodoPago.Listar();

            cbmetodopago.DisplayMember = "descripcion";
            cbmetodopago.ValueMember = "idmetodopago";

            cbmetodopago.SelectedIndex = 0;
        }



        private void cbcajero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            FrmSeleccionarProductoVenta buscador = new FrmSeleccionarProductoVenta();

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

            // 2. Calculamos los impuestos
            double ivaCalculado = subtotalAcumulado * porcentajeIva;
            double totalFinal = subtotalAcumulado + ivaCalculado;

            // 3. Mostramos los resultados en los cuadros de texto
            // "N2" es para formato de número con 2 decimales
            tboxsubtotal.Text = subtotalAcumulado.ToString("N2");
            tboxiva.Text = ivaCalculado.ToString("N2");
            tboxtotal.Text = totalFinal.ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //  Verificamos si hay una fila seleccionada y que no sea la fila vacía del final
                if (dlistadocompra.CurrentRow != null && !dlistadocompra.CurrentRow.IsNewRow)
                {
                    // Pedimos confirmación (opcional, pero profesional)
                    DialogResult opcion = MessageBox.Show("¿Desea quitar este producto de la lista?",
                                                        "DonRoberton", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (opcion == DialogResult.Yes)
                    {
                        // Eliminamos la fila seleccionada
                        dlistadocompra.Rows.RemoveAt(dlistadocompra.CurrentRow.Index);

                        //  Recalculamos el gran total
                        this.CalcularGranTotal();

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

        private void dlistadocompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        }



        private void btnrealizarventa_Click(object sender, EventArgs e)
        {
            // 1. DETERMINAR EL ID DEL CLIENTE
            int idClienteFinal;
            if (cbcliente.SelectedValue == null || cbcliente.SelectedIndex == -1)
            {
                idClienteFinal = 1; // ID 1 reservado para PÚBLICO GENERAL 
            }
            else
            {
                idClienteFinal = Convert.ToInt32(cbcliente.SelectedValue);
            }

            try
            {
                // VALIDACIONES DE SEGURIDAD 
                if (dlistadocompra.Rows.Count == 0 || (dlistadocompra.AllowUserToAddRows && dlistadocompra.Rows.Count == 1))
                {
                    MessageBox.Show("No hay productos en la venta.", "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(tboxtotal.Text))
                {
                    MessageBox.Show("El total no ha sido calculado. Verifique los productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cbmetodopago.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione un método de pago.", "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // PREPARAR LA LISTA DE DETALLES
                List<CDDetalleVenta> detalles = new List<CDDetalleVenta>();
                foreach (DataGridViewRow fila in dlistadocompra.Rows)
                {
                    // Evitamos procesar la fila vacía del final si existe
                    if (fila.Cells["idproducto"].Value != null)
                    {
                        CDDetalleVenta det = new CDDetalleVenta();
                        det.Idproducto = Convert.ToInt32(fila.Cells["idproducto"].Value);
                        det.Cantidad = Convert.ToInt32(fila.Cells["cantidad"].Value);
                        det.PrecioUnitario = Convert.ToDouble(fila.Cells["precio_unit"].Value);
                        det.TotalDetalle = det.Cantidad * det.PrecioUnitario;
                        detalles.Add(det);
                    }
                }

                // LLAMAR A LA CAPA DE NEGOCIO PARA GUARDAR
                string rpta = CNVenta.Insertar(
                    DateTime.Now,
                    Convert.ToDouble(tboxsubtotal.Text),
                    Convert.ToDouble(tboxiva.Text),
                    Convert.ToDouble(tboxtotal.Text),
                    idClienteFinal,
                    Sesion.IdUsuario,
                    Convert.ToInt32(cbmetodopago.SelectedValue),
                    detalles
                );

                // RESPUESTA FINAL
                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("¡Venta Realizada con éxito!\nEl stock se actualizó y los precios se ajustaron por demanda.",
                                    "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar todo para la siguiente venta
                    dlistadocompra.Rows.Clear();
                    tboxsubtotal.Clear();
                    tboxiva.Clear();
                    tboxtotal.Clear();
                    cbcliente.SelectedIndex = -1;
                    cbcliente.Text = "PÚBLICO GENERAL";
                }
                else
                {
                    MessageBox.Show("Error al guardar la venta: " + rpta, "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico: " + ex.Message, "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

