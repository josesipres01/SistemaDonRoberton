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
        public bool ModoRecepcion = false;
        public string EstadoRecibido = "";

        public FrmRegistrarPedido()
        {
            InitializeComponent();
           
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            // Validamos que haya un proveedor seleccionado
            if (cbproveedor.SelectedValue == null || cbproveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un proveedor primero.");
                return;
            }

            FrmSeleccionarProductoPedido buscador = new FrmSeleccionarProductoPedido();
            buscador.IdProveedorSeleccionado = Convert.ToInt32(cbproveedor.SelectedValue);

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                foreach (DataRow fila in buscador.ProductosSeleccionados.Rows)
                {
                    // 1. Agregamos una fila vacía
                    int n = dlistadocompra.Rows.Add();

                    // 2. Asignamos CADA DATO por el NOMBRE de la columna del DataGridView
                    // Asegúrate de que en el Diseñador los (Name) sean idproducto, nombre, etc.
                    dlistadocompra.Rows[n].Cells["idproducto"].Value = fila["idproducto"];
                    dlistadocompra.Rows[n].Cells["nombre"].Value = fila["nombre"];
                    dlistadocompra.Rows[n].Cells["cantidad"].Value = fila["cantidad"];
                    dlistadocompra.Rows[n].Cells["precio_unit"].Value = fila["precio_compra"];

                    // 3. Calculamos el subtotal de esa fila de una vez
                    double precio = Convert.ToDouble(fila["precio_compra"]);
                    int cant = Convert.ToInt32(fila["cantidad"]);
                    dlistadocompra.Rows[n].Cells["subtotal"].Value = (precio * cant).ToString("N2");

                    // 4. Importante para que no te dé error el "2" y el "12"
                    dlistadocompra.Rows[n].Cells["cant_original"].Value = fila["cantidad"];
                }

                // 5. Actualizamos los labels de abajo
                this.CalcularGranTotal();

                // Bloqueamos el proveedor para no mezclar
                cbproveedor.Enabled = false;
            }
        }
        private void CalcularGranTotal()
        {
            double sumaSubtotal = 0;

            foreach (DataGridViewRow fila in dlistadocompra.Rows)
            {
                // Solo sumamos si la fila es válida (idproducto no es nulo)
                if (fila.Cells["idproducto"].Value != null)
                {
                    // Sumamos lo que hay en la columna "subtotal"
                    sumaSubtotal += Convert.ToDouble(fila.Cells["subtotal"].Value);
                }
            }

            double valorIva = sumaSubtotal * 0.16;
            double valorTotal = sumaSubtotal + valorIva;

            // Mostramos en los TextBoxes
            tboxsubtotal.Text = sumaSubtotal.ToString("N2");
            tboxiva.Text = valorIva.ToString("N2");
            tboxtotal.Text = valorTotal.ToString("N2");
        }
        private void FrmRegistrarPedido_Load(object sender, EventArgs e)
        {
            // 1. Cargamos proveedores y usuario siempre
            cbproveedor.DataSource = CNProveedor.Listar();
            cbproveedor.DisplayMember = "nombre";
            cbproveedor.ValueMember = "idproveedor";
            cbproveedor.SelectedIndex = -1;
            cbusuario.Text = Sesion.Usuario;

            // 2. ¿Es una consulta o recepción de un pedido viejo?
            if (this.ModoVista || this.ModoRecepcion)
            {
                DataTable dtDetalles = CNPedido.ObtenerDetalles(this.IdPedidoCargado);
                dlistadocompra.Rows.Clear();

                foreach (DataRow fila in dtDetalles.Rows)
                {
                    int n = dlistadocompra.Rows.Add();
                    // MAPEAMOS POR NOMBRE DE CELDA (Esto evita que los datos se muevan)
                    dlistadocompra.Rows[n].Cells["idproducto"].Value = fila["idproducto"];
                    dlistadocompra.Rows[n].Cells["nombre"].Value = fila["nombre"];
                    dlistadocompra.Rows[n].Cells["cantidad"].Value = fila["cantidad"];
                    dlistadocompra.Rows[n].Cells["precio_unit"].Value = fila["precio_unit"];
                    dlistadocompra.Rows[n].Cells["subtotal"].Value = fila["subtotal"];
                    dlistadocompra.Rows[n].Cells["cant_original"].Value = fila["cantidad"];
                }

                cbproveedor.Enabled = false;
                cbusuario.Enabled = false;

                // --- LÓGICA DE BLOQUEO POR ESTADO (RECIBIDO vs PENDIENTE) ---
                if (this.EstadoRecibido == "RECIBIDO")
                {
                    // Bloqueo total: Solo lectura
                    btnrealizarventa.Visible = false; // Escondemos el botón de Guardar/Actualizar
                    btnagregar.Visible = false;       // Escondemos el botón Agregar
                    btneliminar.Visible = false;      // Escondemos el botón Eliminar
                    dlistadocompra.ReadOnly = true;   // La tabla no se puede tocar

                    // Opcional: Cambiar título si tienes un Label de encabezado
                    // labelTitulo.Text = "Consulta de Pedido (FINALIZADO)";
                }
                else if (this.ModoRecepcion)
                {
                    // Modo para confirmar llegada de mercancía
                    btnrealizarventa.Text = "Recibir Pedido";
                    btnrealizarventa.Visible = true;
                    dlistadocompra.ReadOnly = false;
                    foreach (DataGridViewColumn col in dlistadocompra.Columns)
                    {
                        if (col.Name != "cantidad") col.ReadOnly = true;
                    }
                    btnagregar.Visible = false;
                    btneliminar.Visible = false;
                }
                else if (this.ModoVista)
                {
                    // Modo edición de pedido PENDIENTE
                    btnrealizarventa.Text = "Actualizar Pedido";
                    btnrealizarventa.Visible = true;
                    btnagregar.Visible = true;
                    btneliminar.Visible = true;
                    dlistadocompra.ReadOnly = false;
                }

                this.CalcularGranTotal();
            }
            else // --- ES UN PEDIDO NUEVO ---
            {
                dlistadocompra.Rows.Clear();
                cbproveedor.Enabled = true;
                cbusuario.Enabled = false;
                btnrealizarventa.Text = "Realizar Pedido";
                btnrealizarventa.Visible = true;
                btnagregar.Visible = true;
                btneliminar.Visible = true;

                // Limpiamos los totales
                tboxsubtotal.Text = "0.00";
                tboxiva.Text = "0.00";
                tboxtotal.Text = "0.00";
            }
        }
        private void btnrealizarventa_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. VALIDACIONES BÁSICAS (Aplica para todos los casos)
                if (dlistadocompra.Rows.Count == 0 || (dlistadocompra.AllowUserToAddRows && dlistadocompra.Rows.Count == 1))
                {
                    MessageBox.Show("No hay productos en el pedido.", "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // --- SOLUCIÓN AL ERROR DE PROVEEDOR ---
                // Solo validamos que el combo tenga selección si es un pedido NUEVO.
                // Si es Vista o Recepción, el proveedor ya existe en la base de datos.
                if (!ModoRecepcion && !ModoVista)
                {
                    if (cbproveedor.SelectedValue == null || cbproveedor.SelectedIndex == -1)
                    {
                        MessageBox.Show("Seleccione un proveedor.", "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string rpta = "";

                //  (Recibir, Editar o Insertar)

                if (this.ModoRecepcion == true) // --- CASO A: RECIBIR PEDIDO (Suma Stock) ---
                {
                    foreach (DataGridViewRow fila in dlistadocompra.Rows)
                    {
                        if (fila.Cells["idproducto"].Value != null)
                        {
                            int idp = Convert.ToInt32(fila.Cells["idproducto"].Value);
                            int cant = Convert.ToInt32(fila.Cells["cantidad"].Value);

                            // Esta función actualiza la cantidad real y SUMA al stock en SQL
                            rpta = CNPedido.FinalizarRecepcionItem(this.IdPedidoCargado, idp, cant);
                        }
                    }

                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("¡Pedido RECIBIDO con éxito! El stock ha sido actualizado.", "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (this.ModoVista == true) // --- CASO B: ACTUALIZAR PEDIDO (Solo cambios de lista) ---
                {
                    List<CDDetallePedido> detalles = ObtenerDetallesDeTabla();
                    rpta = CNPedido.Editar(this.IdPedidoCargado, Convert.ToDouble(tboxtotal.Text), detalles);

                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("¡Pedido ACTUALIZADO correctamente!", "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else // --- CASO C: REGISTRAR NUEVO PEDIDO (Crea como Pendiente) ---
                {
                    List<CDDetallePedido> detalles = ObtenerDetallesDeTabla();
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

                // 3. FINALIZAR Y REGRESAR (Si la respuesta de SQL fue "OK")
                if (rpta.Equals("OK"))
                {
                    // Reutilizamos tu método Cancelar para volver al listado de pedidos
                    this.btnCancelar_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Error al procesar: " + rpta, "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico: " + ex.Message, "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<CDDetallePedido> ObtenerDetallesDeTabla()
        {
            List<CDDetallePedido> lista = new List<CDDetallePedido>();
            foreach (DataGridViewRow fila in dlistadocompra.Rows)
            {
                if (fila.Cells["idproducto"].Value != null)
                {
                    CDDetallePedido det = new CDDetallePedido();
                    det.Idproducto = Convert.ToInt32(fila.Cells["idproducto"].Value);
                    det.Cantidad = Convert.ToInt32(fila.Cells["cantidad"].Value);
                    det.PrecioCompra = Convert.ToDouble(fila.Cells["precio_unit"].Value);
                    det.Subtotal = Convert.ToDouble(fila.Cells["subtotal"].Value);
                    lista.Add(det);
                }
            }
            return lista;
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

        private void dlistadocompra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Verificamos que la columna editada sea la de "cantidad"
            if (dlistadocompra.Columns[e.ColumnIndex].Name == "cantidad")
            {
                // 2. Obtenemos los valores básicos de la fila
                int cantEscrita = 0;
                double precio = 0;

                // Usamos TryParse para evitar errores si la celda está vacía
                int.TryParse(Convert.ToString(dlistadocompra.Rows[e.RowIndex].Cells["cantidad"].Value), out cantEscrita);
                double.TryParse(Convert.ToString(dlistadocompra.Rows[e.RowIndex].Cells["precio_unit"].Value), out precio);

                // 3. VALIDACIÓN DE LÍMITE (Solo aplica si estamos RECIBIENDO mercancía vieja)
                if (this.ModoRecepcion)
                {
                    int limiteMaximo = 0;
                    int.TryParse(Convert.ToString(dlistadocompra.Rows[e.RowIndex].Cells["cant_original"].Value), out limiteMaximo);

                    if (cantEscrita > limiteMaximo)
                    {
                        MessageBox.Show("No puedes recibir más de lo solicitado (" + limiteMaximo + ")", "DonRoberton");
                        dlistadocompra.Rows[e.RowIndex].Cells["cantidad"].Value = limiteMaximo;
                        cantEscrita = limiteMaximo;
                    }
                }

                // 4. RECALCULAR LA FILA (Esto se ejecuta SIEMPRE, en cualquier modo)
                double nuevoSubtotal = cantEscrita * precio;
                dlistadocompra.Rows[e.RowIndex].Cells["subtotal"].Value = nuevoSubtotal.ToString("N2");

                // 5. ACTUALIZAR LOS LABELS DE ABAJO
                this.CalcularGranTotal();
            }

        }

        private void cbproveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}   
