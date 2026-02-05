using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using CapaNegocio;  

namespace CapaPresentacion
{
    public partial class FrmRegistrarCliente : MaterialForm
    {
        public bool Insert = false;
        public bool Edit = false;
        public FrmRegistrarCliente()
        {
            InitializeComponent();

           
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; 
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE

            );
            
        }

        private void FrmRegistrarCliente_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
