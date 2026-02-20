using CapaNegocio;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace CapaPresentacion
{
    public partial class FrmListadoCliente : MaterialForm
    {

        private readonly MaterialSkinManager materialSkinManager;
        string criterioBusqueda = "Nombre";

        public FrmListadoCliente()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue700, Primary.Blue900,
                Primary.Blue500, Accent.Red400,
                TextShade.WHITE);
        }

        private void FrmListadoCliente_Load(object sender, EventArgs e)
        {
            if (Sesion.Rol != "admin")
            {
                btnReporte.Visible = false; 
            }
            this.Top = 0;
            this.Left = 0;

            Mostrar();
            configurarTabla(); //Metodo para la tabla bonita
        }


        //Método para mostrar todos los registros
        public void Mostrar()
        {
            try
            {
                this.dlistado.DataSource = null;

                DataTable dt = CNCliente.Listar();
                this.dlistado.DataSource = dt;

                // Si la tabla sigue vacía, verifica si dt tiene filas
                if (dt == null || dt.Rows.Count == 0)
                {
                    Console.WriteLine("La consulta devolvió 0 registros.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        //configuracion de la tabla
        private void configurarTabla()
        {
            // Estética de filas y bordes
            dlistado.RowTemplate.Height = 45; // Altura para que respire el diseño
            dlistado.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Solo líneas horizontales
            dlistado.BackgroundColor = Color.White; // Fondo blanco para la tarjeta
            dlistado.GridColor = Color.FromArgb(240, 240, 240); // Líneas sutiles

            // Diseño de encabezados (Azul Profesional)
            dlistado.EnableHeadersVisualStyles = false;
            dlistado.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Azul Material
            dlistado.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dlistado.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10);
            dlistado.ColumnHeadersHeight = 40;
            dlistado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Comportamiento de datos y selección
            dlistado.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar fila completa
            dlistado.MultiSelect = false;
            dlistado.ReadOnly = true;
            dlistado.AllowUserToAddRows = false; // Quita la fila vacía extra
            dlistado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajusta columnas al ancho

            // Importante: Vincular con la base de datos
            dlistado.AutoGenerateColumns = false; // Desactivar para usar tus columnas manuales
        }

        //Eventos de busqueda
        // Búsqueda en tiempo real mientras escribes en el MaterialTextBox2
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (criterioBusqueda == "Nombre")
            {
                this.dlistado.DataSource = CNCliente.BuscarNombre(this.txtbuscar.Text);
            }
            else
            {
                this.dlistado.DataSource = CNCliente.BuscarRfc(this.txtbuscar.Text);
            }
        }

        public void BuscarNombre() => this.dlistado.DataSource = CNCliente.BuscarNombre(this.txtbuscar.Text);
        public void BuscarRfc() => this.dlistado.DataSource = CNCliente.BuscarRfc(this.txtbuscar.Text);


        //Acciones del sistema
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarCliente form = new FrmRegistrarCliente { Insert = true };
            form.Show();
            this.Hide();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dlistado.CurrentRow == null) return;

            FrmRegistrarCliente form = new FrmRegistrarCliente { Edit = true };

            // Mapeo seguro de datos
            form.txtidcliente.Text = dlistado.CurrentRow.Cells["idcliente"].Value.ToString();
            form.txtnombre.Text = dlistado.CurrentRow.Cells["nombre"].Value.ToString();
            form.txtapellidos.Text = dlistado.CurrentRow.Cells["apellidos"].Value.ToString();
            form.txtrfc.Text = dlistado.CurrentRow.Cells["rfc"].Value.ToString();
            form.txttelefono.Text = dlistado.CurrentRow.Cells["telefono"].Value.ToString();
            form.txtcorreo.Text = dlistado.CurrentRow.Cells["correo"].Value.ToString();

            form.ShowDialog();
            this.Mostrar();
        }

        

        //Bordes redondos en botones
        // Asocia este evento Paint a todos tus botones en el Diseñador
        private void RedondearControl_Paint(object sender, PaintEventArgs e)
        {
            Control control = (Control)sender;
            GraphicsPath path = new GraphicsPath();
            int radius = control.Height; // Crea el efecto píldora

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);

            control.Region = new Region(path);
        }

        private void FrmListadoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la sesión actual?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; 
            }
            else
            {
                try
                {
                    CapaNegocio.CNBitacora objCN = new CapaNegocio.CNBitacora();

                    objCN.LoginSalida(Sesion.IdAcceso);

                    Application.ExitThread();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al registrar salida: " + ex.Message);
                    Application.ExitThread();
                }
            }
        }

        private void bucarCliente_Click(object sender, EventArgs e)
        {

        }

        private void rbtnnombre_Click(object sender, EventArgs e)
        {
            criterioBusqueda = "Nombre";
            BuscarNombre();
        }

        private void rbtnrfc_Click(object sender, EventArgs e)
        {
            criterioBusqueda = "RFC";
            BuscarRfc();
        }

        private void dlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            
                new MenuReportes().ShowDialog();
           

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
                        string idcliente = dlistado.CurrentRow.Cells["idcliente"].Value.ToString();
                        CNCliente.Eliminar(Convert.ToInt32(idcliente));

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

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmListadoCategoria form = new FrmListadoCategoria();
            form.Show();
            this.Hide();

        }
    }
    
}

