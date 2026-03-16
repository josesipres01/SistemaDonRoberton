namespace CapaPresentacion
{
    partial class FrmListadoProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btneliminar = new MaterialSkin.Controls.MaterialButton();
            this.btneditar = new MaterialSkin.Controls.MaterialButton();
            this.btnnuevo = new MaterialSkin.Controls.MaterialButton();
            this.rbtnrfc = new MaterialSkin.Controls.MaterialButton();
            this.rbtnnombre = new MaterialSkin.Controls.MaterialButton();
            this.dlistado = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new MaterialSkin.Controls.MaterialTextBox2();
            this.colBarras = new System.Windows.Forms.DataGridViewImageColumn();
            this.idcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 37);
            this.label1.TabIndex = 61;
            this.label1.Text = "Productos";
            // 
            // btneliminar
            // 
            this.btneliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btneliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btneliminar.Depth = 0;
            this.btneliminar.HighEmphasis = true;
            this.btneliminar.Icon = null;
            this.btneliminar.Location = new System.Drawing.Point(250, 394);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btneliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btneliminar.Size = new System.Drawing.Size(88, 36);
            this.btneliminar.TabIndex = 60;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btneliminar.UseAccentColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btneditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btneditar.Depth = 0;
            this.btneditar.HighEmphasis = true;
            this.btneditar.Icon = null;
            this.btneditar.Location = new System.Drawing.Point(146, 394);
            this.btneditar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btneditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneditar.Name = "btneditar";
            this.btneditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btneditar.Size = new System.Drawing.Size(71, 36);
            this.btneditar.TabIndex = 59;
            this.btneditar.Text = "Editar";
            this.btneditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btneditar.UseAccentColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnnuevo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnnuevo.Depth = 0;
            this.btnnuevo.HighEmphasis = true;
            this.btnnuevo.Icon = null;
            this.btnnuevo.Location = new System.Drawing.Point(41, 394);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnnuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnnuevo.Size = new System.Drawing.Size(70, 36);
            this.btnnuevo.TabIndex = 58;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnnuevo.UseAccentColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // rbtnrfc
            // 
            this.rbtnrfc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rbtnrfc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.rbtnrfc.Depth = 0;
            this.rbtnrfc.HighEmphasis = true;
            this.rbtnrfc.Icon = null;
            this.rbtnrfc.Location = new System.Drawing.Point(573, 110);
            this.rbtnrfc.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.rbtnrfc.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnrfc.Name = "rbtnrfc";
            this.rbtnrfc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.rbtnrfc.Size = new System.Drawing.Size(75, 36);
            this.rbtnrfc.TabIndex = 57;
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
            this.rbtnnombre.Location = new System.Drawing.Point(454, 110);
            this.rbtnnombre.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.rbtnnombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnnombre.Name = "rbtnnombre";
            this.rbtnnombre.NoAccentTextColor = System.Drawing.Color.Empty;
            this.rbtnnombre.Size = new System.Drawing.Size(82, 36);
            this.rbtnnombre.TabIndex = 56;
            this.rbtnnombre.Text = "Nombre";
            this.rbtnnombre.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.rbtnnombre.UseAccentColor = false;
            this.rbtnnombre.UseVisualStyleBackColor = true;
            this.rbtnnombre.Click += new System.EventHandler(this.rbtnnombre_Click);
            // 
            // dlistado
            // 
            this.dlistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dlistado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dlistado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dlistado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dlistado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dlistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproducto,
            this.codigo,
            this.nombre,
            this.descripcion,
            this.fecha_ingreso,
            this.precio_compra,
            this.precio_venta,
            this.stock,
            this.idcategoria,
            this.colBarras});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dlistado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dlistado.Location = new System.Drawing.Point(41, 180);
            this.dlistado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dlistado.Name = "dlistado";
            this.dlistado.ReadOnly = true;
            this.dlistado.RowHeadersWidth = 51;
            this.dlistado.RowTemplate.Height = 45;
            this.dlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dlistado.Size = new System.Drawing.Size(760, 188);
            this.dlistado.TabIndex = 54;
            this.dlistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dlistado_CellContentClick);
            this.dlistado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dlistado_CellFormatting);
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
            this.txtbuscar.Location = new System.Drawing.Point(41, 98);
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
            this.txtbuscar.TabIndex = 55;
            this.txtbuscar.TabStop = false;
            this.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbuscar.TrailingIcon = null;
            this.txtbuscar.UseSystemPasswordChar = false;
            this.txtbuscar.Click += new System.EventHandler(this.txtbuscar_Click);
            // 
            // colBarras
            // 
            this.colBarras.HeaderText = "Código Barras";
            this.colBarras.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colBarras.MinimumWidth = 6;
            this.colBarras.Name = "colBarras";
            this.colBarras.ReadOnly = true;
            this.colBarras.Width = 104;
            // 
            // idcategoria
            // 
            this.idcategoria.DataPropertyName = "idcategoria";
            this.idcategoria.HeaderText = "Categoria";
            this.idcategoria.MinimumWidth = 6;
            this.idcategoria.Name = "idcategoria";
            this.idcategoria.ReadOnly = true;
            this.idcategoria.Width = 98;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 72;
            // 
            // precio_venta
            // 
            this.precio_venta.DataPropertyName = "precio_venta";
            this.precio_venta.HeaderText = "Precio Venta";
            this.precio_venta.MinimumWidth = 6;
            this.precio_venta.Name = "precio_venta";
            this.precio_venta.ReadOnly = true;
            this.precio_venta.Width = 118;
            // 
            // precio_compra
            // 
            this.precio_compra.DataPropertyName = "precio_compra";
            this.precio_compra.HeaderText = "Precio Compra";
            this.precio_compra.MinimumWidth = 6;
            this.precio_compra.Name = "precio_compra";
            this.precio_compra.ReadOnly = true;
            this.precio_compra.Width = 130;
            // 
            // fecha_ingreso
            // 
            this.fecha_ingreso.DataPropertyName = "fecha_ingreso";
            this.fecha_ingreso.HeaderText = "Fecha Ingreso";
            this.fecha_ingreso.MinimumWidth = 6;
            this.fecha_ingreso.Name = "fecha_ingreso";
            this.fecha_ingreso.ReadOnly = true;
            this.fecha_ingreso.Width = 127;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 111;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 87;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 81;
            // 
            // idproducto
            // 
            this.idproducto.DataPropertyName = "idproducto";
            this.idproducto.HeaderText = "ID";
            this.idproducto.MinimumWidth = 6;
            this.idproducto.Name = "idproducto";
            this.idproducto.ReadOnly = true;
            this.idproducto.Width = 50;
            // 
            // FrmListadoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 537);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.rbtnrfc);
            this.Controls.Add(this.rbtnnombre);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dlistado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoProducto";
            this.Text = "FrmListadoProducto";
            this.Load += new System.EventHandler(this.FrmListadoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btneliminar;
        private MaterialSkin.Controls.MaterialButton btneditar;
        private MaterialSkin.Controls.MaterialButton btnnuevo;
        private MaterialSkin.Controls.MaterialButton rbtnrfc;
        private MaterialSkin.Controls.MaterialButton rbtnnombre;
        private MaterialSkin.Controls.MaterialTextBox2 txtbuscar;
        private System.Windows.Forms.DataGridView dlistado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcategoria;
        private System.Windows.Forms.DataGridViewImageColumn colBarras;
    }
}