using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;
using CapaDatos;
namespace CapaPresentacion
{
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }


        private void PantallaInicio_Load(object sender, EventArgs e)
        {

        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AbrirFormulario(Form formularioHijo)
        {
            this.pnlContenedor.Controls.Clear();
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;

            // IMPORTANTE: Para tablas, usamos Fill para que sea lo más grande posible
            formularioHijo.Dock = DockStyle.Fill;

            this.pnlContenedor.Controls.Add(formularioHijo);
            formularioHijo.Show();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoCliente());

        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProducti_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoProducto());

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoCategoria());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new MenuReportes());
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmVenta());
        }


        private void btnproveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoProveedor());

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoPedidos());


        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmRespaldo());
        }

        private void btnCerrarSesion1_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Desea cerrar la sesión actual?", "DonRoberton",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                try
                {
                    // 2. Registramos la salida usando tu Capa de Negocio
                    // Usamos el ID del acceso que guardamos cuando el usuario hizo Login
                    CNBitacora.LoginSalida(Sesion.IdAcceso);

                    // 3. Limpiamos las variables de sesión para que no queden datos en memoria
                    Sesion.IdUsuario = 0;
                    Sesion.Usuario = "";
                    Sesion.IdAcceso = 0;

                    // 4. Regresamos al Login
                    Login frm = new Login();
                    frm.Show();

                    // 5. Cerramos el Dashboard
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cerrar sesión: " + ex.Message);
                }
            }
        }

        private void PantallaInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
    
        }

        private void PantallaInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 1. Preguntamos al usuario
            DialogResult opcion = MessageBox.Show("¿Está seguro que desea cerrar la sesión y salir del sistema?",
                                                 "DonRoberton",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                // 2. Registramos la salida en la Bitácora
                try
                {
                    CNBitacora.LoginSalida(Sesion.IdAcceso);
                }
                catch { }

                Environment.Exit(0);
            }
            else
            {
                // 4. SI ELIGE "NO": Cancelamos el cierre de la ventana
                e.Cancel = true;
            }
        }
    }
}
