using System;

namespace CapaPresentacion
{
    partial class FrmListadoCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dlistado = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new MaterialSkin.Controls.MaterialTextBox2();
            this.rbtnnombre = new MaterialSkin.Controls.MaterialButton();
            this.rbtnrfc = new MaterialSkin.Controls.MaterialButton();
            this.btnnuevo = new MaterialSkin.Controls.MaterialButton();
            this.btneditar = new MaterialSkin.Controls.MaterialButton();
            this.btneliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnReporte = new MaterialSkin.Controls.MaterialButton();
            this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).BeginInit();
            this.SuspendLayout();
            // 
            // dlistado
            // 
            this.dlistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dlistado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dlistado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dlistado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dlistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcliente,
            this.nombre,
            this.apellidos,
            this.telefono,
            this.correo,
            this.rfc});
            this.dlistado.Location = new System.Drawing.Point(100, 258);
            this.dlistado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dlistado.Name = "dlistado";
            this.dlistado.RowHeadersWidth = 51;
            this.dlistado.RowTemplate.Height = 45;
            this.dlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dlistado.Size = new System.Drawing.Size(880, 188);
            this.dlistado.TabIndex = 8;
            this.dlistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dlistado_CellContentClick);
            // 
            // txtbuscar
            // 
            this.txtbuscar.AnimateReadOnly = false;
            this.txtbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtbuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbuscar.Depth = 0;
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbuscar.HideSelection = true;
            this.txtbuscar.Hint = "Buscar cliente...";
            this.txtbuscar.LeadingIcon = global::CapaPresentacion.Properties.Resources.lupa;
            this.txtbuscar.Location = new System.Drawing.Point(120, 176);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtbuscar.TabIndex = 12;
            this.txtbuscar.TabStop = false;
            this.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbuscar.TrailingIcon = null;
            this.txtbuscar.UseSystemPasswordChar = false;
            this.txtbuscar.Click += new System.EventHandler(this.bucarCliente_Click);
            this.txtbuscar.Paint += new System.Windows.Forms.PaintEventHandler(this.RedondearControl_Paint);
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // rbtnnombre
            // 
            this.rbtnnombre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rbtnnombre.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.rbtnnombre.Depth = 0;
            this.rbtnnombre.HighEmphasis = true;
            this.rbtnnombre.Icon = null;
            this.rbtnnombre.Location = new System.Drawing.Point(524, 188);
            this.rbtnnombre.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.rbtnnombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnnombre.Name = "rbtnnombre";
            this.rbtnnombre.NoAccentTextColor = System.Drawing.Color.Empty;
            this.rbtnnombre.Size = new System.Drawing.Size(82, 36);
            this.rbtnnombre.TabIndex = 13;
            this.rbtnnombre.Text = "Nombre";
            this.rbtnnombre.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.rbtnnombre.UseAccentColor = false;
            this.rbtnnombre.UseVisualStyleBackColor = true;
            this.rbtnnombre.Click += new System.EventHandler(this.rbtnnombre_Click);
            this.rbtnnombre.Paint += new System.Windows.Forms.PaintEventHandler(this.RedondearControl_Paint);
            // 
            // rbtnrfc
            // 
            this.rbtnrfc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rbtnrfc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.rbtnrfc.Depth = 0;
            this.rbtnrfc.HighEmphasis = true;
            this.rbtnrfc.Icon = null;
            this.rbtnrfc.Location = new System.Drawing.Point(659, 188);
            this.rbtnrfc.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.rbtnrfc.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnrfc.Name = "rbtnrfc";
            this.rbtnrfc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.rbtnrfc.Size = new System.Drawing.Size(64, 36);
            this.rbtnrfc.TabIndex = 14;
            this.rbtnrfc.Text = "RFC";
            this.rbtnrfc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.rbtnrfc.UseAccentColor = false;
            this.rbtnrfc.UseVisualStyleBackColor = true;
            this.rbtnrfc.Click += new System.EventHandler(this.rbtnrfc_Click);
            this.rbtnrfc.Paint += new System.Windows.Forms.PaintEventHandler(this.RedondearControl_Paint);
            // 
            // btnnuevo
            // 
            this.btnnuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnnuevo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnnuevo.Depth = 0;
            this.btnnuevo.HighEmphasis = true;
            this.btnnuevo.Icon = null;
            this.btnnuevo.Location = new System.Drawing.Point(100, 472);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnnuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnnuevo.Size = new System.Drawing.Size(70, 36);
            this.btnnuevo.TabIndex = 15;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnnuevo.UseAccentColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            this.btnnuevo.Paint += new System.Windows.Forms.PaintEventHandler(this.RedondearControl_Paint);
            // 
            // btneditar
            // 
            this.btneditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btneditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btneditar.Depth = 0;
            this.btneditar.HighEmphasis = true;
            this.btneditar.Icon = null;
            this.btneditar.Location = new System.Drawing.Point(214, 472);
            this.btneditar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btneditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneditar.Name = "btneditar";
            this.btneditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btneditar.Size = new System.Drawing.Size(71, 36);
            this.btneditar.TabIndex = 16;
            this.btneditar.Text = "Editar";
            this.btneditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btneditar.UseAccentColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            this.btneditar.Paint += new System.Windows.Forms.PaintEventHandler(this.RedondearControl_Paint);
            // 
            // btneliminar
            // 
            this.btneliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btneliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btneliminar.Depth = 0;
            this.btneliminar.HighEmphasis = true;
            this.btneliminar.Icon = null;
            this.btneliminar.Location = new System.Drawing.Point(326, 472);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btneliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btneliminar.Size = new System.Drawing.Size(88, 36);
            this.btneliminar.TabIndex = 17;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btneliminar.UseAccentColor = true;
            this.btneliminar.Paint += new System.Windows.Forms.PaintEventHandler(this.RedondearControl_Paint);
            // 
            // btnReporte
            // 
            this.btnReporte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReporte.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReporte.Depth = 0;
            this.btnReporte.HighEmphasis = true;
            this.btnReporte.Icon = null;
            this.btnReporte.Location = new System.Drawing.Point(886, 141);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnReporte.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReporte.Size = new System.Drawing.Size(94, 36);
            this.btnReporte.TabIndex = 19;
            this.btnReporte.Text = "REPORTES";
            this.btnReporte.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnReporte.UseAccentColor = false;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // idcliente
            // 
            this.idcliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idcliente.DataPropertyName = "idcliente";
            this.idcliente.HeaderText = "idcliente";
            this.idcliente.MinimumWidth = 6;
            this.idcliente.Name = "idcliente";
            this.idcliente.Width = 89;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 87;
            // 
            // apellidos
            // 
            this.apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.apellidos.DataPropertyName = "apellidos";
            this.apellidos.HeaderText = "Apellidos";
            this.apellidos.MinimumWidth = 6;
            this.apellidos.Name = "apellidos";
            this.apellidos.Width = 94;
            // 
            // telefono
            // 
            this.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.Width = 93;
            // 
            // correo
            // 
            this.correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "Correo";
            this.correo.MinimumWidth = 6;
            this.correo.Name = "correo";
            this.correo.Width = 80;
            // 
            // rfc
            // 
            this.rfc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rfc.DataPropertyName = "rfc";
            this.rfc.HeaderText = "RFC";
            this.rfc.MinimumWidth = 6;
            this.rfc.Name = "rfc";
            this.rfc.Width = 64;
            // 
            // FrmListadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 661);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.rbtnrfc);
            this.Controls.Add(this.rbtnnombre);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dlistado);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmListadoCliente";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "Listado de Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListadoCliente_FormClosing);
            this.Load += new System.EventHandler(this.FrmListadoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void rbtnrfc_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.DataGridView dlistado;
        private MaterialSkin.Controls.MaterialTextBox2 txtbuscar;
        private MaterialSkin.Controls.MaterialButton rbtnnombre;
        private MaterialSkin.Controls.MaterialButton rbtnrfc;
        private MaterialSkin.Controls.MaterialButton btnnuevo;
        private MaterialSkin.Controls.MaterialButton btneditar;
        private MaterialSkin.Controls.MaterialButton btneliminar;
        private MaterialSkin.Controls.MaterialButton btnReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfc;
    }
}