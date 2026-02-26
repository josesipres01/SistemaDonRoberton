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


        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (
                    string.IsNullOrWhiteSpace(txtnombre.Text) ||
                    string.IsNullOrWhiteSpace(txtpreciocompra.Text) ||
                    string.IsNullOrWhiteSpace(txtprecioventa.Text) ||
                    string.IsNullOrWhiteSpace(txtstock.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios (Nombre, Precios y Stock).",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Detiene el proceso si falta algo
                }

                // --- PREPARACIÓN DE DATOS ---
                string rpta = "";


                // --- LLAMADA A LA CAPA DE NEGOCIO (CNProducto) ---
                rpta = CNProducto.Guardar(
                    txtnombre.Text.Trim(),
                    txtdescripcion.Text.Trim(),
                    dtimeingreso.Value,
                    Convert.ToDouble(txtpreciocompra.Text),
                    Convert.ToDouble(txtprecioventa.Text),
                    Convert.ToInt32(txtstock.Text),
                    Convert.ToInt32(cbcategoria.SelectedValue),
                    Convert.ToInt32(cbProveedor)
                );

                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("¡Producto guardado exitosamente!", "Sistema de Ventas",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpiarControles();
                }
                else
                {
                    MessageBox.Show("Error al guardar: " + rpta, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Asegúrese de que los precios y el stock tengan solamente numeros.",
                                "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message,
                                "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (string.IsNullOrWhiteSpace(txtnombre.Text) ||
                                  string.IsNullOrWhiteSpace(txtpreciocompra.Text) ||
                                  string.IsNullOrWhiteSpace(txtprecioventa.Text) ||
                                  string.IsNullOrWhiteSpace(txtstock.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios (Código, Nombre, Precios y Stock).",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Detiene el proceso si falta algo
                }

                // --- PREPARACIÓN DE DATOS ---
                string rpta = "";


                // --- LLAMADA A LA CAPA DE NEGOCIO (CNProducto) ---
                rpta = CNProducto.Guardar(
                    txtnombre.Text.Trim(),
                    txtdescripcion.Text.Trim(),
                    dtimeingreso.Value,
                    Convert.ToDouble(txtpreciocompra.Text),
                    Convert.ToDouble(txtprecioventa.Text),
                    Convert.ToInt32(txtstock.Text),
                    Convert.ToInt32(cbcategoria.SelectedValue),
                    Convert.ToInt32(cbProveedor.SelectedValue)
                );

                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("¡Producto guardado exitosamente!", "Sistema de Ventas",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpiarControles();
                }
                else
                {
                    MessageBox.Show("Error al guardar: " + rpta, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ;
            }
            catch (FormatException)
            {
                MessageBox.Show("Asegúrese de que los precios y el stock tengan solamente numeros.",
                                "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message,
                                "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btncancerlar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
    }
}
