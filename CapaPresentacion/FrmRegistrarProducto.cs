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
    public partial class FrmRegistrarProducto : Form
    {


        public bool Insert = false;
        public bool Edit = false;
        public FrmRegistrarProducto()
        {
            InitializeComponent();
        }

        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {
            LlenarComboCategorias();
            LlenarComboProveedores();

        }
        private void LlenarComboCategorias()
        {
            cbcategoria.DataSource = CNCategoria.Listar();
            cbcategoria.DisplayMember = "descripcion";
            cbcategoria.ValueMember = "idcategoria";
        }

        private void LlenarComboProveedores()
        {
            cbProveedor.DataSource = CNProveedor.Listar();
            cbProveedor.DisplayMember = "nombre";
            cbProveedor.ValueMember = "idproveedor";
        }

        private void LimpiarControles()
        {
            txtnombre.Clear();
            txtdescripcion.Clear();
            txtpreciocompra.Clear();
            txtprecioventa.Clear();
            txtstock.Clear();
            cbcategoria.SelectedIndex = 0;
            dtimeingreso.Value = DateTime.Now;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validación de campos obligatorios
                if (string.IsNullOrWhiteSpace(txtnombre.Text) ||
                    string.IsNullOrWhiteSpace(txtpreciocompra.Text) ||
                    string.IsNullOrWhiteSpace(txtprecioventa.Text) ||
                    string.IsNullOrWhiteSpace(txtstock.Text) ||
                    string.IsNullOrWhiteSpace(txtcodigo.Text)) 
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string rpta = "";

                // --- LA LÓGICA QUE TE FALTABA: ¿Insertar o Editar? ---
                if (this.Insert) // Si la bandera Insert es true
                {
                    rpta = CNProducto.Guardar(
                        txtnombre.Text.Trim(),
                        txtdescripcion.Text.Trim(),
                        dtimeingreso.Value,
                        Convert.ToDouble(txtpreciocompra.Text),
                        Convert.ToDouble(txtprecioventa.Text),
                        Convert.ToInt32(txtstock.Text),
                        Convert.ToInt32(cbcategoria.SelectedValue),
                        Convert.ToInt32(cbProveedor.SelectedValue),
                        txtcodigo.Text.Trim()
                    );
                }
                else if (this.Edit) // Si la bandera Edit es true
                {
                    rpta = CNProducto.Editar(
                    Convert.ToInt32(txtidproducto.Text), 
                    txtnombre.Text.Trim(),              
                    txtdescripcion.Text.Trim(),          
                    dtimeingreso.Value,                 
                    Convert.ToDouble(txtpreciocompra.Text), 
                    Convert.ToDouble(txtprecioventa.Text),  
                    Convert.ToInt32(txtstock.Text),         
                    Convert.ToInt32(cbcategoria.SelectedValue), 
                    Convert.ToInt32(cbProveedor.SelectedValue), 
                    txtcodigo.Text.Trim()                      
                        );
                    }

                if (rpta.Equals("OK"))
                {
                    if (this.Insert) MessageBox.Show("¡Producto guardado exitosamente!", "DonRoberton");
                    else MessageBox.Show("¡Producto actualizado exitosamente!", "DonRoberton");

                    // Volver al listado
                    PantallaInicio objetoPadre = (PantallaInicio)Application.OpenForms["PantallaInicio"];
                    objetoPadre.AbrirFormulario(new FrmListadoProducto());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al procesar: " + rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancerlar_Click(object sender, EventArgs e)
        {
            PantallaInicio objetoPadre = (PantallaInicio)Application.OpenForms["PantallaInicio"];

            objetoPadre.AbrirFormulario(new FrmListadoProducto());

            this.Close();
        }
    }
}
