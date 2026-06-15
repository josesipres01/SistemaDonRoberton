namespace CapaPresentacion
{
    partial class FrmListadoPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrecibir = new MaterialSkin.Controls.MaterialButton();
            this.btnnuevo = new MaterialSkin.Controls.MaterialButton();
            this.rbtnproveedor = new MaterialSkin.Controls.MaterialButton();
            this.rbtnid = new MaterialSkin.Controls.MaterialButton();
            this.dlistado = new System.Windows.Forms.DataGridView();
            this.idpedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbuscar = new MaterialSkin.Controls.MaterialTextBox2();
            this.btneliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnverdetalle = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 69;
            this.label1.Text = "Pedidos";
            // 
            // btnrecibir
            // 
            this.btnrecibir.AutoSize = false;
            this.btnrecibir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnrecibir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnrecibir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnrecibir.Depth = 0;
            this.btnrecibir.HighEmphasis = true;
            this.btnrecibir.Icon = null;
            this.btnrecibir.Location = new System.Drawing.Point(193, 426);
            this.btnrecibir.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnrecibir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnrecibir.Name = "btnrecibir";
            this.btnrecibir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnrecibir.Size = new System.Drawing.Size(159, 41);
            this.btnrecibir.TabIndex = 67;
            this.btnrecibir.Text = "RECIBIR PEDIDO";
            this.btnrecibir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnrecibir.UseAccentColor = false;
            this.btnrecibir.UseVisualStyleBackColor = false;
            this.btnrecibir.Click += new System.EventHandler(this.btnrecibir_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.AutoSize = false;
            this.btnnuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnnuevo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnnuevo.Depth = 0;
            this.btnnuevo.HighEmphasis = true;
            this.btnnuevo.Icon = null;
            this.btnnuevo.Location = new System.Drawing.Point(29, 426);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnnuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnnuevo.Size = new System.Drawing.Size(154, 41);
            this.btnnuevo.TabIndex = 66;
            this.btnnuevo.Text = "NUEVO PEDIDO";
            this.btnnuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnnuevo.UseAccentColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // rbtnproveedor
            // 
            this.rbtnproveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rbtnproveedor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.rbtnproveedor.Depth = 0;
            this.rbtnproveedor.HighEmphasis = true;
            this.rbtnproveedor.Icon = null;
            this.rbtnproveedor.Location = new System.Drawing.Point(532, 99);
            this.rbtnproveedor.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.rbtnproveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnproveedor.Name = "rbtnproveedor";
            this.rbtnproveedor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.rbtnproveedor.Size = new System.Drawing.Size(105, 36);
            this.rbtnproveedor.TabIndex = 65;
            this.rbtnproveedor.Text = "Proveedor";
            this.rbtnproveedor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.rbtnproveedor.UseAccentColor = false;
            this.rbtnproveedor.UseVisualStyleBackColor = true;
            this.rbtnproveedor.Click += new System.EventHandler(this.rbtnproveedor_Click);
            // 
            // rbtnid
            // 
            this.rbtnid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rbtnid.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.rbtnid.Depth = 0;
            this.rbtnid.HighEmphasis = true;
            this.rbtnid.Icon = null;
            this.rbtnid.Location = new System.Drawing.Point(432, 99);
            this.rbtnid.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.rbtnid.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnid.Name = "rbtnid";
            this.rbtnid.NoAccentTextColor = System.Drawing.Color.Empty;
            this.rbtnid.Size = new System.Drawing.Size(64, 36);
            this.rbtnid.TabIndex = 64;
            this.rbtnid.Text = "ID";
            this.rbtnid.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.rbtnid.UseAccentColor = false;
            this.rbtnid.UseVisualStyleBackColor = true;
            this.rbtnid.Click += new System.EventHandler(this.rbtnid_Click);
            // 
            // dlistado
            // 
            this.dlistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dlistado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dlistado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dlistado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dlistado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dlistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpedido,
            this.fecha,
            this.Comprador,
            this.Proveedor,
            this.total,
            this.estado});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dlistado.DefaultCellStyle = dataGridViewCellStyle4;
            this.dlistado.Location = new System.Drawing.Point(29, 177);
            this.dlistado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dlistado.Name = "dlistado";
            this.dlistado.RowHeadersWidth = 51;
            this.dlistado.RowTemplate.Height = 45;
            this.dlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dlistado.Size = new System.Drawing.Size(760, 188);
            this.dlistado.TabIndex = 62;
            this.dlistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dlistado_CellContentClick);
            // 
            // idpedido
            // 
            this.idpedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idpedido.DataPropertyName = "ID";
            this.idpedido.HeaderText = "ID";
            this.idpedido.MinimumWidth = 6;
            this.idpedido.Name = "idpedido";
            this.idpedido.Width = 50;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.Width = 76;
            // 
            // Comprador
            // 
            this.Comprador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Comprador.DataPropertyName = "Comprador";
            this.Comprador.HeaderText = "Usuario";
            this.Comprador.MinimumWidth = 6;
            this.Comprador.Name = "Comprador";
            this.Comprador.Width = 86;
            // 
            // Proveedor
            // 
            this.Proveedor.DataPropertyName = "proveedor";
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.MinimumWidth = 6;
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Width = 103;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.total.DataPropertyName = "Total Compra";
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.Width = 69;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.Width = 81;
            // 
            // txtbuscar
            // 
            this.txtbuscar.AnimateReadOnly = false;
            this.txtbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtbuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbuscar.Depth = 0;
            this.txtbuscar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.HideSelection = true;
            this.txtbuscar.Hint = "Buscar pedidos realizados...";
            this.txtbuscar.LeadingIcon = null;
            this.txtbuscar.Location = new System.Drawing.Point(19, 87);
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
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // btneliminar
            // 
            this.btneliminar.AutoSize = false;
            this.btneliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btneliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btneliminar.Depth = 0;
            this.btneliminar.HighEmphasis = true;
            this.btneliminar.Icon = null;
            this.btneliminar.Location = new System.Drawing.Point(362, 426);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btneliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btneliminar.Size = new System.Drawing.Size(172, 41);
            this.btneliminar.TabIndex = 70;
            this.btneliminar.Text = "CANCELAR PEDIDO";
            this.btneliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btneliminar.UseAccentColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnverdetalle
            // 
            this.btnverdetalle.AutoSize = false;
            this.btnverdetalle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnverdetalle.BackColor = System.Drawing.Color.Transparent;
            this.btnverdetalle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnverdetalle.Depth = 0;
            this.btnverdetalle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnverdetalle.HighEmphasis = false;
            this.btnverdetalle.Icon = null;
            this.btnverdetalle.Location = new System.Drawing.Point(544, 426);
            this.btnverdetalle.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnverdetalle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnverdetalle.Name = "btnverdetalle";
            this.btnverdetalle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnverdetalle.Size = new System.Drawing.Size(154, 41);
            this.btnverdetalle.TabIndex = 71;
            this.btnverdetalle.Text = "VER DETALLE";
            this.btnverdetalle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnverdetalle.UseAccentColor = false;
            this.btnverdetalle.UseVisualStyleBackColor = false;
            this.btnverdetalle.Click += new System.EventHandler(this.btnverdetalle_Click);
            // 
            // FrmListadoPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 520);
            this.Controls.Add(this.btnverdetalle);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrecibir);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.rbtnproveedor);
            this.Controls.Add(this.rbtnid);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dlistado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoPedidos";
            this.Text = "FrmListadoPedidos";
            this.Load += new System.EventHandler(this.FrmListadoPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnrecibir;
        private MaterialSkin.Controls.MaterialButton btnnuevo;
        private MaterialSkin.Controls.MaterialButton rbtnproveedor;
        private MaterialSkin.Controls.MaterialButton rbtnid;
        private MaterialSkin.Controls.MaterialTextBox2 txtbuscar;
        private System.Windows.Forms.DataGridView dlistado;
        private MaterialSkin.Controls.MaterialButton btneliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private MaterialSkin.Controls.MaterialButton btnverdetalle;
    }
}