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
    public partial class FrmSeleccionarProductoPedido : Form
    {
        public int IdProveedorSeleccionado { get; set; }
        public DataTable ProductosSeleccionados = new DataTable();

        public bool Insert = false;
        public bool Edit = false;
        string criterioBusqueda;

        public FrmSeleccionarProductoPedido()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            // 1. Inicializamos la estructura de la tabla de resultados
            ProductosSeleccionados = new DataTable();
            ProductosSeleccionados.Columns.Add("idproducto", typeof(int));
            ProductosSeleccionados.Columns.Add("nombre", typeof(string));
            ProductosSeleccionados.Columns.Add("precio_compra", typeof(double));
            ProductosSeleccionados.Columns.Add("cantidad", typeof(int));

            bool haySeleccion = false;

            foreach (DataGridViewRow fila in dseleccionar.Rows)
            {
                // 2. Revisamos el Checkbox (asegúrate que la columna se llame 'chkSeleccionar')
                bool isChecked = Convert.ToBoolean(fila.Cells["chkSeleccionar"].Value);

                if (isChecked)
                {
                    haySeleccion = true;

                    // 3. Captura y validación de cantidad
                    int stockActual = Convert.ToInt32(fila.Cells["stock"].Value);
                    var valorCelda = fila.Cells["cantidad_venta"].Value;
                    int cantidadPedida = (valorCelda == null || string.IsNullOrWhiteSpace(valorCelda.ToString()))
                                         ? 1 : Convert.ToInt32(valorCelda);

                    if (cantidadPedida <= 0)
                    {
                        MessageBox.Show("La cantidad debe ser mayor a 0 en: " + fila.Cells["nombre"].Value);
                        return;
                    }

                    // 4. Agregamos a la tabla que viajará al carrito
                    // NOTA: Usa los nombres exactos de tus columnas del DataGridView
                    ProductosSeleccionados.Rows.Add(
                        Convert.ToInt32(fila.Cells["idproducto"].Value),
                        Convert.ToString(fila.Cells["nombre"].Value),
                        Convert.ToDouble(fila.Cells["precio_compra"].Value),
                        cantidadPedida
                    );
                }
            }

            if (haySeleccion)
            {
                this.DialogResult = DialogResult.OK; // Le avisa al Carrito que todo salió bien
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione al menos un producto con la palomita.");
            }
        }

        private void FrmSeleccionarProductoPedido_Load(object sender, EventArgs e)
        {
            dseleccionar.AutoGenerateColumns = false;

            this.dseleccionar.DataSource = CNProducto.ListarPorProveedor(this.IdProveedorSeleccionado);

        }

        //Método para buscar por nombre
        public void BuscarNombre()
        {
            this.dseleccionar.DataSource = CNProducto.BuscarNombre(this.txtbuscar.Text);
        }


        //Método para buscar por código
        public void BuscarCódigo()
        {
            this.dseleccionar.DataSource = CNProducto.BuscarCodigo(this.txtbuscar.Text);
        }

        private void rbtnnombre_Click(object sender, EventArgs e)
        {
            criterioBusqueda = "Nombre";
            BuscarNombre();

        }


        private void rbtncodigo_Click(object sender, EventArgs e)
        {

            criterioBusqueda = "Código";
            BuscarCódigo();
        }
    }
}
