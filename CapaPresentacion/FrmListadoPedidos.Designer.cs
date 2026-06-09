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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrecibir = new MaterialSkin.Controls.MaterialButton();
            this.btnnuevo = new MaterialSkin.Controls.MaterialButton();
            this.rbtndni = new MaterialSkin.Controls.MaterialButton();
            this.rbtnnombre = new MaterialSkin.Controls.MaterialButton();
            this.dlistado = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new MaterialSkin.Controls.MaterialTextBox2();
            this.btneliminar = new MaterialSkin.Controls.MaterialButton();
            this.idpedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnrecibir.Click += new System.EventHandler(this.btneditar_Click);
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
            // rbtndni
            // 
            this.rbtndni.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rbtndni.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.rbtndni.Depth = 0;
            this.rbtndni.HighEmphasis = true;
            this.rbtndni.Icon = null;
            this.rbtndni.Location = new System.Drawing.Point(558, 99);
            this.rbtndni.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.rbtndni.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtndni.Name = "rbtndni";
            this.rbtndni.NoAccentTextColor = System.Drawing.Color.Empty;
            this.rbtndni.Size = new System.Drawing.Size(64, 36);
            this.rbtndni.TabIndex = 65;
            this.rbtndni.Text = "DNI";
            this.rbtndni.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.rbtndni.UseAccentColor = false;
            this.rbtndni.UseVisualStyleBackColor = true;
            // 
            // rbtnnombre
            // 
            this.rbtnnombre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rbtnnombre.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.rbtnnombre.Depth = 0;
            this.rbtnnombre.HighEmphasis = true;
            this.rbtnnombre.Icon = null;
            this.rbtnnombre.Location = new System.Drawing.Point(432, 99);
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
            this.idpedido,
            this.fecha,
            this.Comprador,
            this.Proveedor,
            this.total,
            this.estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dlistado.DefaultCellStyle = dataGridViewCellStyle2;
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
            // FrmListadoPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 520);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrecibir);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.rbtndni);
            this.Controls.Add(this.rbtnnombre);
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
        private MaterialSkin.Controls.MaterialButton rbtndni;
        private MaterialSkin.Controls.MaterialButton rbtnnombre;
        private MaterialSkin.Controls.MaterialTextBox2 txtbuscar;
        private System.Windows.Forms.DataGridView dlistado;
        private MaterialSkin.Controls.MaterialButton btneliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}