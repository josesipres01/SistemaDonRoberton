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
    public partial class FrmRespaldo : Form
    {
        public FrmRespaldo()
        {
            InitializeComponent();
        }

        private void FrmRespaldo_Load(object sender, EventArgs e)
        {

        }

        private void btngenerarrespaldo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Backup File (*.bak)|*.bak";
            saveFile.Title = "Guardar Respaldo"; // Título opcional para guiar al usuario
            saveFile.FileName = "Respaldo_" + DateTime.Now.ToString("ddMMyyyy_HHmm");

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                txtRutaGenerar.Text = saveFile.FileName;

                CNRespaldo negocio = new CNRespaldo();
                if (negocio.CrearCopia(saveFile.FileName))
                    MessageBox.Show("Respaldo creado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error al crear respaldo. Verifica permisos de carpeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnrestaurarbd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Backup File (*.bak)|*.bak";
            openFile.Title = "Seleccionar Respaldo";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtRutaCargar.Text = openFile.FileName;

                // Confirmación de seguridad
                if (MessageBox.Show("¿Está seguro de restaurar? Se sobrescribirán todos los datos.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    CNRespaldo negocio = new CNRespaldo();
                    if (negocio.CargarCopia(openFile.FileName))
                        MessageBox.Show("Base de datos restaurada exitosamente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error en la restauración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
