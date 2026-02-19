using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        string password;
        string usuario;
        public Login()
        {
            InitializeComponent();
        }

        public void btnLoginNow_Click(object sender, EventArgs e)
        {
            // 1. Obtener datos de los campos de texto
            usuario = txtusuario.Text.Trim();
            password = txtcontrasena.Text.Trim();

            // Validar que no estén vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            try
            {
                using (SqlConnection con = new SqlConnection(Conexión.Conn))
                {
                    con.Open();

                   string queryLogin = "SELECT COUNT(*) FROM usuarios WHERE usuario = @user AND contrasena = @pass";
                    SqlCommand cmdLogin = new SqlCommand(queryLogin, con);
                    cmdLogin.Parameters.AddWithValue("@user", usuario);
                    cmdLogin.Parameters.AddWithValue("@pass", password);

                    int existe = Convert.ToInt32(cmdLogin.ExecuteScalar());

                    if (existe > 0)
                    {
                        // --- LOG LOGIN EXITOSO ---

                        string queryBitacora = @"INSERT INTO bitacora_accesos (usuario, fecha_entrada) 
                                       VALUES (@user, GETDATE());
                                       SELECT SCOPE_IDENTITY();";

                        SqlCommand cmdBitacora = new SqlCommand(queryBitacora, con);
                        cmdBitacora.Parameters.AddWithValue("@user", usuario);

                        Sesion.Usuario = usuario;
                        Sesion.IdAcceso = Convert.ToInt32(cmdBitacora.ExecuteScalar());


                        Form principal = new FrmListadoCliente(); 
                        principal.Show();
                        this.Hide(); // Escondemos el login
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
