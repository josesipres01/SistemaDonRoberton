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
        public int IdPedidoCargado = 0;
        public bool ModoVista = false;
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

            if (ModoVista)
            {
                // 1. Traemos los datos de la Capa de Negocio
                DataTable dtDetalles = CNPedido.ObtenerDetalles(this.IdPedidoCargado);

                // 2. Limpiamos la tabla por si acaso
                dlistadocompra.Rows.Clear();

                // 3. Recorremos y asignamos manualmente
                foreach (DataRow fila in dtDetalles.Rows)
                {
                    // El orden debe coincidir con tu diseño: ID, Producto, Cantidad, Precio, Subtotal
                    dlistadocompra.Rows.Add(
                        fila["idproducto"],
                        fila["nombre"],
                        fila["cantidad"],
                        fila["precio_unit"],
                        fila["subtotal"]
                    );
                }

                // 4. Actualizamos los totales de abajo
                this.CalcularGranTotal();
                // Bloqueamos los Combobox
                cbproveedor.Enabled = false;
                cbusuario.Enabled = false; // O el nombre que tenga tu combobox/textbox de usuario

                // Cambiamos el texto del botón para que el usuario sepa que va a actualizar
                btnrealizarventa.Text = "Actualizar Pedido";
            }
        }

        private void btnrealizarventa_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. VALIDACIONES BÁSICAS
                if (dlistadocompra.Rows.Count == 0 || (dlistadocompra.AllowUserToAddRows && dlistadocompra.Rows.Count == 1))
                {
                    MessageBox.Show("No hay productos en el pedido.", "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cbproveedor.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un proveedor.", "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. PREPARAR LOS DETALLES (Esto sirve para ambos casos)
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

                string rpta = "";

                // 3. DECIDIR SI ES INSERTAR O ACTUALIZAR
                if (this.ModoVista == true) // --- CASO ACTUALIZAR ---
                {
                    // Llamamos a un nuevo método Editar que crearemos en las capas
                    rpta = CNPedido.Editar(
                        this.IdPedidoCargado,
                        Convert.ToDouble(tboxtotal.Text),
                        detalles
                    );

                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("¡Pedido ACTUALIZADO correctamente!", "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else // --- CASO REGISTRAR NUEVO ---
                {
                    rpta = CNPedido.Insertar(
                        DateTime.Now,
                        Convert.ToInt32(cbproveedor.SelectedValue),
                        Sesion.IdUsuario,
                        Convert.ToDouble(tboxtotal.Text),
                        "PENDIENTE",
                        detalles
                    );

                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("¡Pedido registrado como PENDIENTE!", "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // 4. REGRESAR AL LISTADO (Si todo salió bien)
                if (rpta.Equals("OK"))
                {
                    // Reutilizamos la lógica de regresar
                    this.btnCancelar_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Error: " + rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Buscamos el formulario padre (Dashboard)
            PantallaInicio objetoPadre = (PantallaInicio)Application.OpenForms["PantallaInicio"];

            // Regresamos al listado de pedidos
            objetoPadre.AbrirFormulario(new FrmListadoPedidos());

            // Cerramos la ventana actual
            this.Close();
        }
    }
}   
