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
    public partial class LoginBitacora : Form
    {
        public LoginBitacora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioAdmin = "admin";
            string passAdmin = "12345";

            if (txtusuario.Text.Trim() == usuarioAdmin && txtcontrasena.Text.Trim() == passAdmin)
            {
                MessageBox.Show("Acceso concedido al historial.", "Sistema Don Roberton", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcontrasena.Clear();
                txtusuario.Focus();
            }
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBitacora_Load(object sender, EventArgs e)
        {

        }
    }
}
