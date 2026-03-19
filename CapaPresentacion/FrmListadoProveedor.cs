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
    public partial class FrmListadoProveedor : Form
    {
        string criterioBusqueda;

        public FrmListadoProveedor()
        {
            InitializeComponent();
        }

       

        private void FrmListadoProveedor_Load_1(object sender, EventArgs e)
        {

            Mostrar();
        }
        public void BuscarNombre() => this.dlistado.DataSource = CNProveedor.BuscarNombre(this.txtbuscar.Text);
        public void BuscarDni() => this.dlistado.DataSource = CNProveedor.BuscarDni(this.txtbuscar.Text);


        public void Mostrar()
        {
            try
            {
                this.dlistado.DataSource = null;

                DataTable dt = CNProveedor.Listar();
                this.dlistado.DataSource = dt;

             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

 

        private void txtbuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (criterioBusqueda == "Nombre")
            {
                this.dlistado.DataSource = CNProveedor.BuscarNombre(this.txtbuscar.Text);
            }
            else
            {
                this.dlistado.DataSource = CNProveedor.BuscarDni(this.txtbuscar.Text);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            PantallaInicio objetoPadre = (PantallaInicio)Application.OpenForms["PantallaInicio"];

            if (objetoPadre != null)
            {
                // 1. Creamos la instancia y activamos la bandera 'Insert'
                FrmRegistrarProveedor form = new FrmRegistrarProveedor { Insert = true };

                // 2. Lo abrimos en el panel principal
                objetoPadre.AbrirFormulario(form);

                // 3. Cerramos el listado
                this.Close();
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            // 1. Validar que haya una fila seleccionada
            if (dlistado.CurrentRow == null) return;

            PantallaInicio objetoPadre = (PantallaInicio)Application.OpenForms["PantallaInicio"];

            if (objetoPadre != null)
            {
                FrmRegistrarProveedor form = new FrmRegistrarProveedor { Edit = true };

                form.txtidproveedor.Text = Convert.ToString(dlistado.CurrentRow.Cells["idproveedor"].Value);
                form.txtnombre.Text = Convert.ToString(dlistado.CurrentRow.Cells["nombre"].Value);
                form.txtdni.Text = Convert.ToString(dlistado.CurrentRow.Cells["dni"].Value);
                form.txtrfc.Text = Convert.ToString(dlistado.CurrentRow.Cells["rfc"].Value);
                form.txttelefono.Text = Convert.ToString(dlistado.CurrentRow.Cells["telefono"].Value);
                form.txtcorreo.Text = Convert.ToString(dlistado.CurrentRow.Cells["correo"].Value);
                form.txtdireccion.Text = Convert.ToString(dlistado.CurrentRow.Cells["direccion"].Value);

                objetoPadre.AbrirFormulario(form);

                this.Close();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Realmente desea eliminar el(los) registro(s)?",
                    "SistemaDonRoberton",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (dlistado.SelectedRows.Count > 0)
                {
                    if (opcion == DialogResult.OK)
                    {
                        string idcliente = dlistado.CurrentRow.Cells["idproveedor"].Value.ToString();
                        CNProveedor.Eliminar(Convert.ToInt32(idcliente));

                        MessageBox.Show("Registro(s) eliminado(s) correctamente",
                            "SistemaDonRoberton",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        Mostrar();
                    }
                }
                Mostrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

      

        private void rbtnnombre_Click(object sender, EventArgs e)
        {
            criterioBusqueda = "Nombre";
            BuscarNombre(); 
        }

        private void rbtndni_Click(object sender, EventArgs e)
        {
            criterioBusqueda = "Dni";
            BuscarDni();
        }

        private void txtbuscar_Click_1(object sender, EventArgs e)
        {

        }

        private void dlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }
    }
}
