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



    }
}

