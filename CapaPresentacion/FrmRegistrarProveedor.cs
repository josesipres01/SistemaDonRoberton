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
    public partial class FrmRegistrarProveedor : Form
    {
        public bool Insert = false;
        public bool Edit = false;
        public FrmRegistrarProveedor()
        {
            InitializeComponent();
        }

        private void FrmRegistrarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try {
                if (this.txtnombre.Text == "" || this.txtdni.Text == "")
                {
                    MessageBox.Show("Ingrese un nombre y DNI",
                        "Sistema de ventas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    if (this.Insert)
                    {
                        CNProveedor.Guardar(this.txtnombre.Text, this.txttelefono.Text, this.txtcorreo.Text, this.txtdni.Text, this.txtrfc.Text, this.txtdireccion.Text, "ACTIVO");
                        MessageBox.Show("Proveedor Registrado",
                            "Sistema de ventas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }


                    else if (this.Edit)
                    {
                        CNProveedor.Editar(Convert.ToInt32(this.txtidproveedor.Text), this.txtnombre.Text, this.txttelefono.Text, this.txtcorreo.Text, this.txtdni.Text, this.txtrfc.Text, this.txtdireccion.Text, "ACTIVO");
                        MessageBox.Show("Proveedor Editado",
                            "Sistema de ventas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    this.Insert = false;
                    this.Edit = false;


                    PantallaInicio objetoPadre = (PantallaInicio)Application.OpenForms["PantallaInicio"];

                    objetoPadre.AbrirFormulario(new FrmListadoProveedor());

                    this.Close();
                }


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + Ex.StackTrace);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {

            PantallaInicio objetoPadre = (PantallaInicio)Application.OpenForms["PantallaInicio"];

            objetoPadre.AbrirFormulario(new FrmListadoProveedor());

            this.Close();
        }
    }
}
