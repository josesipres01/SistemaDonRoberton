namespace CapaPresentacion
{
    partial class FrmVenta
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dtimefecha = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbcajero = new System.Windows.Forms.ComboBox();
            this.cbcliente = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.grplistado = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btncancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnrealizar = new MaterialSkin.Controls.MaterialButton();
            this.grplistado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 69;
            this.label1.Text = "Ventas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(34, 119);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(48, 19);
            this.materialLabel2.TabIndex = 71;
            this.materialLabel2.Text = "Fecha:";
            // 
            // dtimefecha
            // 
            this.dtimefecha.Enabled = false;
            this.dtimefecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimefecha.Location = new System.Drawing.Point(115, 116);
            this.dtimefecha.Name = "dtimefecha";
            this.dtimefecha.Size = new System.Drawing.Size(128, 22);
            this.dtimefecha.TabIndex = 72;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(347, 119);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 73;
            this.materialLabel1.Text = "Cajero:";
            // 
            // cbcajero
            // 
            this.cbcajero.FormattingEnabled = true;
            this.cbcajero.Location = new System.Drawing.Point(424, 119);
            this.cbcajero.Name = "cbcajero";
            this.cbcajero.Size = new System.Drawing.Size(204, 24);
            this.cbcajero.TabIndex = 74;
            // 
            // cbcliente
            // 
            this.cbcliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbcliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbcliente.FormattingEnabled = true;
            this.cbcliente.Location = new System.Drawing.Point(115, 179);
            this.cbcliente.Name = "cbcliente";
            this.cbcliente.Size = new System.Drawing.Size(204, 24);
            this.cbcliente.TabIndex = 76;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(34, 179);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(53, 19);
            this.materialLabel3.TabIndex = 75;
            this.materialLabel3.Text = "Cliente:";
            // 
            // grplistado
            // 
            this.grplistado.Controls.Add(this.dataGridView2);
            this.grplistado.Location = new System.Drawing.Point(35, 322);
            this.grplistado.Name = "grplistado";
            this.grplistado.Size = new System.Drawing.Size(820, 279);
            this.grplistado.TabIndex = 78;
            this.grplistado.TabStop = false;
            this.grplistado.Text = "Listado de Compra";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(808, 252);
            this.dataGridView2.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(650, 277);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(88, 36);
            this.btnAgregar.TabIndex = 79;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(767, 277);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(88, 36);
            this.btnEliminar.TabIndex = 80;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(39, 275);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(216, 24);
            this.cbCategoria.TabIndex = 82;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(38, 252);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(222, 19);
            this.materialLabel4.TabIndex = 81;
            this.materialLabel4.Text = "Seleccione un método de pago:";
            // 
            // btncancelar
            // 
            this.btncancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btncancelar.Depth = 0;
            this.btncancelar.HighEmphasis = true;
            this.btncancelar.Icon = null;
            this.btncancelar.Location = new System.Drawing.Point(537, 629);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btncancelar.Size = new System.Drawing.Size(147, 36);
            this.btncancelar.TabIndex = 83;
            this.btncancelar.Text = "Cancelar Venta";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btncancelar.UseAccentColor = false;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnrealizar
            // 
            this.btnrealizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnrealizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnrealizar.Depth = 0;
            this.btnrealizar.HighEmphasis = true;
            this.btnrealizar.Icon = null;
            this.btnrealizar.Location = new System.Drawing.Point(716, 629);
            this.btnrealizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnrealizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnrealizar.Name = "btnrealizar";
            this.btnrealizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnrealizar.Size = new System.Drawing.Size(139, 36);
            this.btnrealizar.TabIndex = 84;
            this.btnrealizar.Text = "Realizar Venta";
            this.btnrealizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnrealizar.UseAccentColor = false;
            this.btnrealizar.UseVisualStyleBackColor = true;
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 693);
            this.Controls.Add(this.btnrealizar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grplistado);
            this.Controls.Add(this.cbcliente);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.cbcajero);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dtimefecha);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.grplistado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker dtimefecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox cbcajero;
        private System.Windows.Forms.ComboBox cbcliente;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.GroupBox grplistado;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private System.Windows.Forms.ComboBox cbCategoria;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btncancelar;
        private MaterialSkin.Controls.MaterialButton btnrealizar;
    }
}