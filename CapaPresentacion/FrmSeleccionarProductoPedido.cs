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
            // 1. Inicializamos la estructura de la tabla (usando nombres de tu SQL)
            ProductosSeleccionados = new DataTable();
            ProductosSeleccionados.Columns.Add("idproducto", typeof(int));
            ProductosSeleccionados.Columns.Add("nombre", typeof(string));
            ProductosSeleccionados.Columns.Add("precio_compra", typeof(double));
            ProductosSeleccionados.Columns.Add("cantidad", typeof(int));

            bool haySeleccion = false;

            foreach (DataGridViewRow fila in dseleccionar.Rows)
            {
                // 2. Usamos 'chkSeleccionar' (como sale en tu esquema)
                bool isChecked = Convert.ToBoolean(fila.Cells["chkSeleccionar"].Value);

                if (isChecked)
                {
                    haySeleccion = true;

                    // --- CAPTURA DE DATOS USANDO TUS NOMBRES DEL ESQUEMA ---
                    int id = Convert.ToInt32(fila.Cells["idproducto"].Value);
                    string nom = Convert.ToString(fila.Cells["nombre"].Value);
                    double precio = Convert.ToDouble(fila.Cells["precio_compra"].Value);

                    var valorCelda = fila.Cells["cantidad"].Value;
                    int cantPedida = (valorCelda == null || string.IsNullOrWhiteSpace(valorCelda.ToString()))
                                     ? 1 : Convert.ToInt32(valorCelda);

                    // 3. Agregamos a la tabla que viajará al carrito
                    ProductosSeleccionados.Rows.Add(id, nom, precio, cantPedida);
                }
            }

            if (haySeleccion)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione al menos un producto.");
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

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
