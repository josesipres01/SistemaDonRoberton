using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmListadoCliente : Form
    {
        public FrmListadoCliente()
        {
            InitializeComponent();
        }

        private void FrmListadoCliente_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            Mostrar();
        }


        //Método para mostrar todos los registros
        public void Mostrar()
        {
            this.dlistado.DataSource = CNCliente.Listar();
        }

        //Método para buscar por nombre
        public void BuscarNombre()
        {
            this.dlistado.DataSource = CNCliente.BuscarNombre(this.txtbuscar.Text);
        }


        //Método para buscar por RFC
        public void BuscarRfc()
        {
            this.dlistado.DataSource = CNCliente.BuscarRfc(this.txtbuscar.Text);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnnombre.Checked)
            {
                BuscarNombre();
            }
            else if (rbtnrfc.Checked)
            {
                BuscarRfc();
            }
            else
            {
               MessageBox.Show("Seleccione un criterio de búsqueda", "Sistema DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarCliente form = new FrmRegistrarCliente();

            form.Insert = true;

            form.Show();
            this.Hide();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
             FrmRegistrarCliente form = new FrmRegistrarCliente();
    
            form.Edit = true;

            form.txtidcliente.Text = this.dlistado.CurrentRow.Cells["idcliente"].Value.ToString();
            form.txtnombre.Text = this.dlistado.CurrentRow.Cells["nombre"].Value.ToString();
            form.txtapellidos.Text = this.dlistado.CurrentRow.Cells["apellidos"].Value.ToString();
            form.txtrfc.Text = this.dlistado.CurrentRow.Cells["rfc"].Value.ToString();
            form.txttelefono.Text = this.dlistado.CurrentRow.Cells["telefono"].Value.ToString();
            form.txtcorreo.Text = this.dlistado.CurrentRow.Cells["correo"].Value.ToString();

            form.ShowDialog();
            this.Mostrar();


       

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

        private void button1_Click(object sender, EventArgs e)
        {
            LoginBitacora frmLogin = new LoginBitacora();

            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                MenuReportes frmReporte = new MenuReportes();
                frmReporte.ShowDialog();
            }


        }

        private void FrmListadoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea cerrar la sesión actual?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    CNBitacora objCN = new CNBitacora();

                    objCN.LoginSalida(Sesion.IdAcceso);

                    Application.ExitThread();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al registrar salida: " + ex.Message);
                }
            }

        }

    }
    
}

