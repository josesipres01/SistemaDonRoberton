namespace CapaPresentacion
{
    partial class FrmSeleccionarProductoVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnrfc = new MaterialSkin.Controls.MaterialButton();
            this.rbtnnombre = new MaterialSkin.Controls.MaterialButton();
            this.txtbuscar = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 37);
            this.label1.TabIndex = 69;
            this.label1.Text = "Productos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbtnrfc
            // 
            this.rbtnrfc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rbtnrfc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.rbtnrfc.Depth = 0;
            this.rbtnrfc.HighEmphasis = true;
            this.rbtnrfc.Icon = null;
            this.rbtnrfc.Location = new System.Drawing.Point(592, 111);
            this.rbtnrfc.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.rbtnrfc.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnrfc.Name = "rbtnrfc";
            this.rbtnrfc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.rbtnrfc.Size = new System.Drawing.Size(75, 36);
            this.rbtnrfc.TabIndex = 65;
            this.rbtnrfc.Text = "CÓDIGO";
            this.rbtnrfc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.rbtnrfc.UseAccentColor = false;
            this.rbtnrfc.UseVisualStyleBackColor = true;
            this.rbtnrfc.Click += new System.EventHandler(this.rbtnrfc_Click);
            // 
            // rbtnnombre
            // 
            this.rbtnnombre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rbtnnombre.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.rbtnnombre.Depth = 0;
            this.rbtnnombre.HighEmphasis = true;
            this.rbtnnombre.Icon = null;
            this.rbtnnombre.Location = new System.Drawing.Point(473, 111);
            this.rbtnnombre.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.rbtnnombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnnombre.Name = "rbtnnombre";
            this.rbtnnombre.NoAccentTextColor = System.Drawing.Color.Empty;
            this.rbtnnombre.Size = new System.Drawing.Size(82, 36);
            this.rbtnnombre.TabIndex = 64;
            this.rbtnnombre.Text = "Nombre";
            this.rbtnnombre.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.rbtnnombre.UseAccentColor = false;
            this.rbtnnombre.UseVisualStyleBackColor = true;
            this.rbtnnombre.Click += new System.EventHandler(this.rbtnnombre_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.AnimateReadOnly = false;
            this.txtbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtbuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbuscar.Depth = 0;
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbuscar.HideSelection = true;
            this.txtbuscar.Hint = "Buscar producto...";
            this.txtbuscar.LeadingIcon = global::CapaPresentacion.Properties.Resources.lupa;
            this.txtbuscar.Location = new System.Drawing.Point(60, 99);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtbuscar.MaxLength = 32767;
            this.txtbuscar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.PasswordChar = '\0';
            this.txtbuscar.PrefixSuffixText = null;
            this.txtbuscar.ReadOnly = false;
            this.txtbuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbuscar.SelectedText = "";
            this.txtbuscar.SelectionLength = 0;
            this.txtbuscar.SelectionStart = 0;
            this.txtbuscar.ShortcutsEnabled = true;
            this.txtbuscar.Size = new System.Drawing.Size(386, 48);
            this.txtbuscar.TabIndex = 63;
            this.txtbuscar.TabStop = false;
            this.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbuscar.TrailingIcon = null;
            this.txtbuscar.UseSystemPasswordChar = false;
            this.txtbuscar.Click += new System.EventHandler(this.txtbuscar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrar.Depth = 0;
            this.btnRegistrar.HighEmphasis = true;
            this.btnRegistrar.Icon = null;
            this.btnRegistrar.Location = new System.Drawing.Point(779, 452);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Size = new System.Drawing.Size(99, 36);
            this.btnRegistrar.TabIndex = 80;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrar.UseAccentColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Location = new System.Drawing.Point(58, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 279);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(789, 152);
            this.dataGridView1.TabIndex = 4;
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(7, 50);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(216, 24);
            this.cbCategoria.TabIndex = 1;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(6, 27);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(184, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Seleccione una Categoría:";
            // 
            // FrmSeleccionarProductoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 537);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnrfc);
            this.Controls.Add(this.rbtnnombre);
            this.Controls.Add(this.txtbuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSeleccionarProductoVenta";
            this.Text = "FrmSeleccionarProductoVenta";
            this.Load += new System.EventHandler(this.FrmSeleccionarProductoVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton rbtnrfc;
        private MaterialSkin.Controls.MaterialButton rbtnnombre;
        private MaterialSkin.Controls.MaterialTextBox2 txtbuscar;
        private MaterialSkin.Controls.MaterialButton btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbCategoria;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}