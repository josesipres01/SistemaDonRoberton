namespace CapaPresentacion
{
    partial class FrmRegistrarPedido
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
            this.tboxiva = new System.Windows.Forms.TextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.tboxsubtotal = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tboxtotal = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnagregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnrealizarventa = new System.Windows.Forms.Button();
            this.grplistado = new System.Windows.Forms.GroupBox();
            this.dlistadocompra = new System.Windows.Forms.DataGridView();
            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbusuario = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtimefecha = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbproveedor = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.grplistado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlistadocompra)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxiva
            // 
            this.tboxiva.Location = new System.Drawing.Point(127, 440);
            this.tboxiva.Name = "tboxiva";
            this.tboxiva.ReadOnly = true;
            this.tboxiva.Size = new System.Drawing.Size(140, 22);
            this.tboxiva.TabIndex = 113;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(29, 436);
            this.materialLabel7.MinimumSize = new System.Drawing.Size(10, 20);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(74, 19);
            this.materialLabel7.TabIndex = 112;
            this.materialLabel7.Text = "IVA (16%):";
            // 
            // tboxsubtotal
            // 
            this.tboxsubtotal.Location = new System.Drawing.Point(127, 399);
            this.tboxsubtotal.Name = "tboxsubtotal";
            this.tboxsubtotal.ReadOnly = true;
            this.tboxsubtotal.Size = new System.Drawing.Size(140, 22);
            this.tboxsubtotal.TabIndex = 111;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(31, 402);
            this.materialLabel6.MinimumSize = new System.Drawing.Size(10, 20);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(65, 19);
            this.materialLabel6.TabIndex = 110;
            this.materialLabel6.Text = "Subtotal:";
            // 
            // tboxtotal
            // 
            this.tboxtotal.Location = new System.Drawing.Point(127, 481);
            this.tboxtotal.Name = "tboxtotal";
            this.tboxtotal.ReadOnly = true;
            this.tboxtotal.Size = new System.Drawing.Size(140, 22);
            this.tboxtotal.TabIndex = 109;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(61, 481);
            this.materialLabel5.MinimumSize = new System.Drawing.Size(10, 20);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(42, 19);
            this.materialLabel5.TabIndex = 108;
            this.materialLabel5.Text = "Total:";
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(527, 153);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(90, 33);
            this.btnagregar.TabIndex = 107;
            this.btnagregar.Text = "&Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(660, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 33);
            this.button2.TabIndex = 106;
            this.button2.Text = "&Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnrealizarventa
            // 
            this.btnrealizarventa.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrealizarventa.Location = new System.Drawing.Point(602, 473);
            this.btnrealizarventa.Name = "btnrealizarventa";
            this.btnrealizarventa.Size = new System.Drawing.Size(132, 33);
            this.btnrealizarventa.TabIndex = 105;
            this.btnrealizarventa.Text = "&Realizar Pedido";
            this.btnrealizarventa.UseVisualStyleBackColor = true;
            this.btnrealizarventa.Click += new System.EventHandler(this.btnrealizarventa_Click);
            // 
            // grplistado
            // 
            this.grplistado.Controls.Add(this.dlistadocompra);
            this.grplistado.Location = new System.Drawing.Point(32, 192);
            this.grplistado.Name = "grplistado";
            this.grplistado.Size = new System.Drawing.Size(726, 193);
            this.grplistado.TabIndex = 102;
            this.grplistado.TabStop = false;
            this.grplistado.Text = "Listado de Compra";
            // 
            // dlistadocompra
            // 
            this.dlistadocompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dlistadocompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproducto,
            this.nombre,
            this.cantidad,
            this.precio_unit,
            this.Proveedor});
            this.dlistadocompra.Location = new System.Drawing.Point(6, 21);
            this.dlistadocompra.Name = "dlistadocompra";
            this.dlistadocompra.RowHeadersWidth = 51;
            this.dlistadocompra.RowTemplate.Height = 24;
            this.dlistadocompra.Size = new System.Drawing.Size(712, 156);
            this.dlistadocompra.TabIndex = 4;
            // 
            // idproducto
            // 
            this.idproducto.DataPropertyName = "idproducto";
            this.idproducto.HeaderText = "ID";
            this.idproducto.MinimumWidth = 6;
            this.idproducto.Name = "idproducto";
            this.idproducto.Visible = false;
            this.idproducto.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Producto";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 125;
            // 
            // precio_unit
            // 
            this.precio_unit.DataPropertyName = "precio_unit";
            this.precio_unit.HeaderText = "Precio Unit";
            this.precio_unit.MinimumWidth = 6;
            this.precio_unit.Name = "precio_unit";
            this.precio_unit.ReadOnly = true;
            this.precio_unit.Width = 125;
            // 
            // Proveedor
            // 
            this.Proveedor.DataPropertyName = "proveedor";
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.MinimumWidth = 6;
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Width = 125;
            // 
            // cbusuario
            // 
            this.cbusuario.FormattingEnabled = true;
            this.cbusuario.Location = new System.Drawing.Point(357, 86);
            this.cbusuario.MinimumSize = new System.Drawing.Size(10, 0);
            this.cbusuario.Name = "cbusuario";
            this.cbusuario.Size = new System.Drawing.Size(191, 24);
            this.cbusuario.TabIndex = 99;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(296, 86);
            this.materialLabel1.MinimumSize = new System.Drawing.Size(10, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(59, 19);
            this.materialLabel1.TabIndex = 98;
            this.materialLabel1.Text = "Usuario:";
            // 
            // dtimefecha
            // 
            this.dtimefecha.Enabled = false;
            this.dtimefecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimefecha.Location = new System.Drawing.Point(108, 86);
            this.dtimefecha.MinimumSize = new System.Drawing.Size(10, 20);
            this.dtimefecha.Name = "dtimefecha";
            this.dtimefecha.Size = new System.Drawing.Size(115, 22);
            this.dtimefecha.TabIndex = 97;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(27, 89);
            this.materialLabel2.MinimumSize = new System.Drawing.Size(10, 20);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(48, 19);
            this.materialLabel2.TabIndex = 96;
            this.materialLabel2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 37);
            this.label1.TabIndex = 95;
            this.label1.Text = "Pedido";
            // 
            // cbproveedor
            // 
            this.cbproveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbproveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbproveedor.FormattingEnabled = true;
            this.cbproveedor.Location = new System.Drawing.Point(144, 137);
            this.cbproveedor.MinimumSize = new System.Drawing.Size(10, 0);
            this.cbproveedor.Name = "cbproveedor";
            this.cbproveedor.Size = new System.Drawing.Size(191, 24);
            this.cbproveedor.TabIndex = 115;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(29, 141);
            this.materialLabel3.MinimumSize = new System.Drawing.Size(10, 20);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(76, 20);
            this.materialLabel3.TabIndex = 114;
            this.materialLabel3.Text = "Proveedor:";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmRegistrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 568);
            this.Controls.Add(this.cbproveedor);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.tboxiva);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.tboxsubtotal);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.tboxtotal);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnrealizarventa);
            this.Controls.Add(this.grplistado);
            this.Controls.Add(this.cbusuario);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dtimefecha);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarPedido";
            this.Text = "FrmListadoPedido";
            this.Load += new System.EventHandler(this.FrmListadoPedido_Load);
            this.grplistado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dlistadocompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxiva;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.TextBox tboxsubtotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox tboxtotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnrealizarventa;
        private System.Windows.Forms.GroupBox grplistado;
        private System.Windows.Forms.DataGridView dlistadocompra;
        private System.Windows.Forms.ComboBox cbusuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtimefecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.ComboBox cbproveedor;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}