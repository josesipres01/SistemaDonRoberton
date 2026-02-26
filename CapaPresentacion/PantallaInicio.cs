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

        private void AbrirFormulario(Form formularioHijo)
        {
            // 1. Limpieza total
            this.pnlContenedor.Controls.Clear();

            // 2. Configuración de seguridad
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;

            // 3. ¡ESTO ES LO MÁS IMPORTANTE!
            // Quitamos cualquier rastro de Dock o Anchor que traiga el diseño original
            formularioHijo.Dock = DockStyle.None;
            formularioHijo.Anchor = AnchorStyles.None;

            // 4. Lo agregamos al panel
            this.pnlContenedor.Controls.Add(formularioHijo);

            // 5. Forzamos el cálculo del centro
            // Usamos 'Width' y 'Height' pero aseguramos que el formulario ya sea parte del panel
            int posX = (pnlContenedor.Width - formularioHijo.Width) / 4;
            int posY = (pnlContenedor.Height - formularioHijo.Height) / 4;

            // 6. Aplicamos la ubicación manual
            formularioHijo.Location = new Point(posX, posY);

            // 7. Lo mostramos
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
