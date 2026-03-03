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
    public partial class FrmListadoCategoria : Form
    {

        public bool Insert = false;
        public bool Edit = false;

        public FrmListadoCategoria()
        {
            InitializeComponent();
        }

        private void FrmListadoCategoria_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.Mostrar();
        }
        public void Mostrar()
        {
            this.dlistado.DataSource = CNCategoria.Listar();
        }

        //Método para buscar por nombre
        public void Buscar()
        {
            this.dlistado.DataSource = CNCategoria.BuscarNombre(this.txtbuscar.Text);
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            PantallaInicio objetoPadre = (PantallaInicio)Application.OpenForms["PantallaInicio"];

            if (objetoPadre != null)
            {
                // 1. Creamos la instancia y activamos la bandera 'Insert'
                FrmRegistrarCategoria form = new FrmRegistrarCategoria { Insert = true };

                // 2. Lo abrimos en el panel principal
                objetoPadre.AbrirFormulario(form);

                // 3. Cerramos el listado
                this.Close();
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dlistado.CurrentCell == null) return;
                PantallaInicio objetoPadre = (PantallaInicio)Application.OpenForms["PantallaInicio"];
                if(objetoPadre != null)
                {
                    FrmRegistrarCategoria form = new FrmRegistrarCategoria { Edit = true };
                    form.Edit = true;
                    form.Insert = false;
                    form.txtidcategoria.Text = this.dlistado.CurrentRow.Cells["idcategoria"].Value.ToString();
                    form.txtdescripcion.Text = this.dlistado.CurrentRow.Cells["descripcion"].Value.ToString();
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
                    "Sistema de Ventas",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (dlistado.SelectedRows.Count > 0)
                {
                    if (opcion == DialogResult.OK)
                    {
                        string idcategoria = dlistado.CurrentRow.Cells["idcategoria"].Value.ToString();
                        CNCategoria.Eliminar(Convert.ToInt32(idcategoria));

                        MessageBox.Show("Registro(s) eliminado(s) correctamente",
                            "Sistema de Ventas",
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

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
