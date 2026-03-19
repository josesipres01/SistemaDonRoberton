using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class FrmListadoProveedor
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
            this.dlistado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btneliminar = new MaterialSkin.Controls.MaterialButton();
            this.btneditar = new MaterialSkin.Controls.MaterialButton();
            this.btnnuevo = new MaterialSkin.Controls.MaterialButton();
            this.rbtndni = new MaterialSkin.Controls.MaterialButton();
            this.rbtnnombre = new MaterialSkin.Controls.MaterialButton();
            this.txtbuscar = new MaterialSkin.Controls.MaterialTextBox2();
            this.idproveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).BeginInit();
            this.SuspendLayout();
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
            this.idproveedor,
            this.nombre,
            this.telefono,
            this.correo,
            this.dni,
            this.rfc,
            this.direccion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dlistado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dlistado.Location = new System.Drawing.Point(34, 177);
            this.dlistado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dlistado.Name = "dlistado";
            this.dlistado.RowHeadersWidth = 51;
            this.dlistado.RowTemplate.Height = 45;
            this.dlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dlistado.Size = new System.Drawing.Size(760, 188);
            this.dlistado.TabIndex = 8;
            this.dlistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dlistado_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 37);
            this.label1.TabIndex = 61;
            this.label1.Text = "Proveedores";
            // 
            // btneliminar
            // 
            this.btneliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btneliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btneliminar.Depth = 0;
            this.btneliminar.HighEmphasis = true;
            this.btneliminar.Icon = null;
            this.btneliminar.Location = new System.Drawing.Point(233, 383);
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
            this.btneditar.Location = new System.Drawing.Point(129, 383);
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
            this.btnnuevo.Location = new System.Drawing.Point(24, 383);
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
            // rbtndni
            // 
            this.rbtndni.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rbtndni.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.rbtndni.Depth = 0;
            this.rbtndni.HighEmphasis = true;
            this.rbtndni.Icon = null;
            this.rbtndni.Location = new System.Drawing.Point(563, 99);
            this.rbtndni.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.rbtndni.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtndni.Name = "rbtndni";
            this.rbtndni.NoAccentTextColor = System.Drawing.Color.Empty;
            this.rbtndni.Size = new System.Drawing.Size(64, 36);
            this.rbtndni.TabIndex = 57;
            this.rbtndni.Text = "DNI";
            this.rbtndni.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.rbtndni.UseAccentColor = false;
            this.rbtndni.UseVisualStyleBackColor = true;
            this.rbtndni.Click += new System.EventHandler(this.rbtndni_Click);
            // 
            // rbtnnombre
            // 
            this.rbtnnombre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rbtnnombre.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.rbtnnombre.Depth = 0;
            this.rbtnnombre.HighEmphasis = true;
            this.rbtnnombre.Icon = null;
            this.rbtnnombre.Location = new System.Drawing.Point(437, 99);
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
            // txtbuscar
            // 
            this.txtbuscar.AnimateReadOnly = false;
            this.txtbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtbuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbuscar.Depth = 0;
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbuscar.HideSelection = true;
            this.txtbuscar.Hint = "Buscar proveedores...";
            this.txtbuscar.LeadingIcon = global::CapaPresentacion.Properties.Resources.lupa;
            this.txtbuscar.Location = new System.Drawing.Point(24, 87);
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
            this.txtbuscar.Click += new System.EventHandler(this.txtbuscar_Click_1);
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // idproveedor
            // 
            this.idproveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idproveedor.DataPropertyName = "idproveedor";
            this.idproveedor.HeaderText = "idproveedor";
            this.idproveedor.MinimumWidth = 6;
            this.idproveedor.Name = "idproveedor";
            this.idproveedor.Visible = false;
            this.idproveedor.Width = 113;
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
            // dni
            // 
            this.dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "DNI";
            this.dni.MinimumWidth = 6;
            this.dni.Name = "dni";
            this.dni.Width = 60;
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
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Dirección";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.Width = 96;
            // 
            // FrmListadoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.rbtndni);
            this.Controls.Add(this.rbtnnombre);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dlistado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoProveedor";
            this.Text = "FrmListadoProveedor";
            this.Load += new System.EventHandler(this.FrmListadoProveedor_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btneliminar;
        private MaterialSkin.Controls.MaterialButton btneditar;
        private MaterialSkin.Controls.MaterialButton btnnuevo;
        private MaterialSkin.Controls.MaterialButton rbtndni;
        private MaterialSkin.Controls.MaterialButton rbtnnombre;
        private MaterialSkin.Controls.MaterialTextBox2 txtbuscar;
        private System.Windows.Forms.DataGridView dlistado;
        private DataGridViewTextBoxColumn idproveedor;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn rfc;
        private DataGridViewTextBoxColumn direccion;
    }
}