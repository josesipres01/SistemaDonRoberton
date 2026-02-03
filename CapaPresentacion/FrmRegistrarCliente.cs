using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;

namespace CapaPresentacion
{
    public partial class FrmRegistrarCliente : MaterialForm
    {
        public FrmRegistrarCliente()
        {
            InitializeComponent();

           
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; // O DARK
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE

            );
            
        }
        

        

        private void FrmRegistrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
