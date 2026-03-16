using BarcodeStandard;
using CapaDatos;
using CapaNegocio;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;

namespace CapaPresentacion  
{
    public partial class FrmListadoProducto : Form
    {
        string criterioBusqueda = "Nombre";

        public FrmListadoProducto()
        {
            InitializeComponent();
        }

        private void dlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            PantallaInicio objetoPadre = (PantallaInicio)Application.OpenForms["PantallaInicio"];

            if (objetoPadre != null)
            {
                FrmRegistrarProducto form = new FrmRegistrarProducto { Insert = true };

                objetoPadre.AbrirFormulario(form);

                this.Close();
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            if (dlistado.CurrentRow == null) return;

            PantallaInicio objetoPadre = (PantallaInicio)Application.OpenForms["PantallaInicio"];

            if (objetoPadre != null)
            {

                FrmRegistrarProducto form = new FrmRegistrarProducto();
                form.Edit = true;
                form.Insert = false;

                form.txtidproducto.Text = this.dlistado.CurrentRow.Cells["idproducto"].Value.ToString();
                form.txtcodigo.Text = this.dlistado.CurrentRow.Cells["codigo"].Value.ToString();
                form.txtnombre.Text = this.dlistado.CurrentRow.Cells["nombre"].Value.ToString();
                form.txtdescripcion.Text = this.dlistado.CurrentRow.Cells["descripcion"].Value.ToString();
                form.txtpreciocompra.Text = this.dlistado.CurrentRow.Cells["precio_compra"].Value.ToString();
                form.txtprecioventa.Text = this.dlistado.CurrentRow.Cells["precio_venta"].Value.ToString();
                form.dtimeingreso.Value = Convert.ToDateTime(this.dlistado.CurrentRow.Cells["fecha_ingreso"].Value);
                form.txtstock.Text = this.dlistado.CurrentRow.Cells["stock"].Value.ToString();
                form.cbcategoria.SelectedValue = this.dlistado.CurrentRow.Cells["idcategoria"].Value;
                    


                objetoPadre.AbrirFormulario(form);

                 this.Close();
                }

         }



        

        public void Mostrar()
        {
            this.dlistado.AutoGenerateColumns = false;

            this.dlistado.DataSource = CNProducto.Listar();




        }

        //Método para buscar por nombre
        public void BuscarNombre()
        {
            this.dlistado.DataSource = CNProducto.BuscarNombre(this.txtbuscar.Text);
        }


        //Método para buscar por código
        public void BuscarCódigo()
        {
            this.dlistado.DataSource = CNProducto.BuscarCodigo(this.txtbuscar.Text);
        }

        private void FrmListadoProducto_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Realmente desea eliminar el(los) producto?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlistado.SelectedRows.Count > 0)
                {
                    if (opcion == DialogResult.OK)
                    {
                        string idproducto = dlistado.CurrentRow.Cells["idproducto"].Value.ToString();
                        CNProducto.Eliminar(Convert.ToInt32(idproducto));
                        MessageBox.Show("Registro eliminado", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void rbtnnombre_Click(object sender, EventArgs e)
        {
            criterioBusqueda = "Nombre";
            BuscarNombre();
        }

        private void rbtnrfc_Click(object sender, EventArgs e)
        {

            criterioBusqueda = "Código";
            BuscarCódigo();
        }

        private void dlistado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dlistado.Columns[e.ColumnIndex].Name == "colBarras")
            {
                try
                {
                    string valorCodigo = Convert.ToString(dlistado.Rows[e.RowIndex].Cells["codigo"].Value);

                    if (!string.IsNullOrEmpty(valorCodigo))
                    {
                        Barcode barcode = new Barcode();
                        barcode.IncludeLabel = false;

                        Image img = barcode.Encode(TYPE.CODE128, valorCodigo, Color.Black, Color.White, 150, 40);

                        e.Value = img;
                    }
                }
                catch (Exception)
                {
                    e.Value = null;
                }
            }
        }

        private void txtbuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
