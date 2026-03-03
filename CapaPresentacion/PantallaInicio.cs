using System;
using System.Drawing;
using System.Windows.Forms;

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
            AbrirFormulario(new FrmRegistrarProducto());

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoCategoria());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(new FrmMenu());
        }
    }
}
