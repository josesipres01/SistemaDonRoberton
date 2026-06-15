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
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnrealizarventa = new System.Windows.Forms.Button();
            this.grplistado = new System.Windows.Forms.GroupBox();
            this.dlistadocompra = new System.Windows.Forms.DataGridView();
            this.cbusuario = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtimefecha = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbproveedor = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_original = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grplistado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlistadocompra)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxiva
            // 
            this.tboxiva.Location = new System.Drawing.Point(127, 441);
            this.tboxiva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.materialLabel7.MinimumSize = new System.Drawing.Size(11, 20);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(74, 19);
            this.materialLabel7.TabIndex = 112;
            this.materialLabel7.Text = "IVA (16%):";
            // 
            // tboxsubtotal
            // 
            this.tboxsubtotal.Location = new System.Drawing.Point(127, 399);
            this.tboxsubtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.materialLabel6.MinimumSize = new System.Drawing.Size(11, 20);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(65, 19);
            this.materialLabel6.TabIndex = 110;
            this.materialLabel6.Text = "Subtotal:";
            // 
            // tboxtotal
            // 
            this.tboxtotal.Location = new System.Drawing.Point(127, 481);
            this.tboxtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.materialLabel5.MinimumSize = new System.Drawing.Size(11, 20);
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
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(91, 33);
            this.btnagregar.TabIndex = 107;
            this.btnagregar.Text = "&Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(660, 153);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(91, 33);
            this.btneliminar.TabIndex = 106;
            this.btneliminar.Text = "&Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnrealizarventa
            // 
            this.btnrealizarventa.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrealizarventa.Location = new System.Drawing.Point(463, 481);
            this.btnrealizarventa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnrealizarventa.Name = "btnrealizarventa";
            this.btnrealizarventa.Size = new System.Drawing.Size(155, 33);
            this.btnrealizarventa.TabIndex = 105;
            this.btnrealizarventa.Text = "&Realizar Pedido";
            this.btnrealizarventa.UseVisualStyleBackColor = true;
            this.btnrealizarventa.Click += new System.EventHandler(this.btnrealizarventa_Click);
            // 
            // grplistado
            // 
            this.grplistado.Controls.Add(this.dlistadocompra);
            this.grplistado.Location = new System.Drawing.Point(32, 192);
            this.grplistado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grplistado.Name = "grplistado";
            this.grplistado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grplistado.Size = new System.Drawing.Size(725, 193);
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
            this.cant_original,
            this.cantidad,
            this.precio_unit,
            this.subtotal,
            this.Proveedor});
            this.dlistadocompra.Location = new System.Drawing.Point(5, 21);
            this.dlistadocompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dlistadocompra.Name = "dlistadocompra";
            this.dlistadocompra.RowHeadersWidth = 51;
            this.dlistadocompra.RowTemplate.Height = 24;
            this.dlistadocompra.Size = new System.Drawing.Size(712, 156);
            this.dlistadocompra.TabIndex = 4;
            this.dlistadocompra.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dlistadocompra_CellEndEdit);
            // 
            // cbusuario
            // 
            this.cbusuario.FormattingEnabled = true;
            this.cbusuario.Location = new System.Drawing.Point(387, 86);
            this.cbusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbusuario.MinimumSize = new System.Drawing.Size(9, 0);
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
            this.materialLabel1.MinimumSize = new System.Drawing.Size(11, 20);
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
            this.dtimefecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtimefecha.MinimumSize = new System.Drawing.Size(9, 20);
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
            this.materialLabel2.MinimumSize = new System.Drawing.Size(11, 20);
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
            this.label1.Location = new System.Drawing.Point(15, 14);
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
            this.cbproveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbproveedor.MinimumSize = new System.Drawing.Size(9, 0);
            this.cbproveedor.Name = "cbproveedor";
            this.cbproveedor.Size = new System.Drawing.Size(191, 24);
            this.cbproveedor.TabIndex = 115;
            this.cbproveedor.SelectedIndexChanged += new System.EventHandler(this.cbproveedor_SelectedIndexChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(29, 142);
            this.materialLabel3.MinimumSize = new System.Drawing.Size(11, 20);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(76, 19);
            this.materialLabel3.TabIndex = 114;
            this.materialLabel3.Text = "Proveedor:";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(642, 481);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 33);
            this.btnCancelar.TabIndex = 116;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Producto";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // cant_original
            // 
            this.cant_original.HeaderText = "Cantidad Original";
            this.cant_original.MinimumWidth = 6;
            this.cant_original.Name = "cant_original";
            this.cant_original.Visible = false;
            this.cant_original.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cantidad.Width = 125;
            // 
            // precio_unit
            // 
            this.precio_unit.HeaderText = "Precio Unit";
            this.precio_unit.MinimumWidth = 6;
            this.precio_unit.Name = "precio_unit";
            this.precio_unit.ReadOnly = true;
            this.precio_unit.Width = 125;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "subtotal";
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.Width = 125;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.MinimumWidth = 6;
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Visible = false;
            this.Proveedor.Width = 125;
            // 
            // FrmRegistrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 569);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbproveedor);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.tboxiva);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.tboxsubtotal);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.tboxtotal);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnrealizarventa);
            this.Controls.Add(this.grplistado);
            this.Controls.Add(this.cbusuario);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dtimefecha);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRegistrarPedido";
            this.Text = "FrmRegistrarPedido";
            this.Load += new System.EventHandler(this.FrmRegistrarPedido_Load);
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
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnrealizarventa;
        private System.Windows.Forms.GroupBox grplistado;
        private System.Windows.Forms.DataGridView dlistadocompra;
        private System.Windows.Forms.ComboBox cbusuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtimefecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.ComboBox cbproveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_original;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
    }
}