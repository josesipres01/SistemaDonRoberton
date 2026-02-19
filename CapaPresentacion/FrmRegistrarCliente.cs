using CapaNegocio;  
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmRegistrarCliente : MaterialForm
    {
        public bool Insert = false;
        public bool Edit = false;
        public FrmRegistrarCliente()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // CAMBIA ESTO: De DARK a LIGHT
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Ajusta los colores para que coincidan con el listado
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue700, Primary.Blue900,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void FrmRegistrarCliente_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.txtnombre.Text == string.Empty || this.txtapellidos.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese los datos del cliente", "Sistema DonRoberton",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (this.Insert == true)
                    {
                        CNCliente.Guardar(  this.txtnombre.Text,
                                          this.txtapellidos.Text,
                                          this.txtrfc.Text,
                                          this.txttelefono.Text,
                                          this.txtcorreo.Text);
                        MessageBox.Show("Cliente registrado correctamente", "Sistema DonRoberton",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if (this.Edit == true)
                    {
                        CNCliente.Editar(
                                        Convert.ToInt32(this.txtidcliente.Text),
                                        this.txtnombre.Text,
                                        this.txtapellidos.Text,
                                        this.txtrfc.Text,
                                        this.txttelefono.Text,
                                        this.txtcorreo.Text);
                        MessageBox.Show("Cliente editado correctamente", "Sistema DonRoberton",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Insert = false;
                    this.Edit = false;

                    FrmListadoCliente form = new FrmListadoCliente();
                    form.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FrmListadoCliente form = new FrmListadoCliente();
            form.Show();
            this.Hide();
        }
    }
}
