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
    public partial class LoginBitacora : Form
    {
        CNUsuario objetoCN = new CNUsuario();
        public LoginBitacora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtusuario.Text.Trim();
            string pass = txtcontrasena.Text.Trim();

            // Llamamos a la Capa de Negocio para verificar si es ADMIN en la BD
            if (objetoCN.LoginAdministrador(user, pass))
            {
                MessageBox.Show("Acceso concedido al historial.", "Sistema Don Roberton", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerramos este login con OK para que el menú de reportes sepa que puede mostrarse
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // El mensaje ahora es más específico: o los datos están mal, o no es administrador
                MessageBox.Show("Credenciales incorrectas o no tiene permisos de Administrador.", "Error de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
