namespace CapaPresentacion
{
    partial class FrmReporteClienteUpdate
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
            this.label2 = new System.Windows.Forms.Label();
            this.dlistado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_antiguo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos_antiguo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfc_antiguo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfc_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo_antiguo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Serif SC", 12F);
            this.label2.Location = new System.Drawing.Point(38, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Registros actualizados";
            // 
            // dlistado
            // 
            this.dlistado.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.dlistado.AllowUserToAddRows = false;
            this.dlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dlistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcliente,
            this.nombre_antiguo,
            this.nombre_actual,
            this.apellidos_antiguo,
            this.apellidos_actual,
            this.rfc_antiguo,
            this.rfc_actual,
            this.correo_antiguo,
            this.correo_actual,
            this.fecha_operacion,
            this.usuario});
            this.dlistado.Location = new System.Drawing.Point(43, 142);
            this.dlistado.Name = "dlistado";
            this.dlistado.ReadOnly = true;
            this.dlistado.RowHeadersWidth = 51;
            this.dlistado.RowTemplate.Height = 24;
            this.dlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dlistado.Size = new System.Drawing.Size(1287, 251);
            this.dlistado.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Serif SC Black", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Reporte Clientes";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(1240, 477);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(90, 36);
            this.btneliminar.TabIndex = 23;
            this.btneliminar.Text = "&Cancelar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // idcliente
            // 
            this.idcliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idcliente.DataPropertyName = "idcliente";
            this.idcliente.HeaderText = "Num Cliente";
            this.idcliente.MinimumWidth = 6;
            this.idcliente.Name = "idcliente";
            this.idcliente.ReadOnly = true;
            this.idcliente.Width = 108;
            // 
            // nombre_antiguo
            // 
            this.nombre_antiguo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre_antiguo.DataPropertyName = "nombre_antiguo";
            this.nombre_antiguo.HeaderText = "Nombre Antiguo";
            this.nombre_antiguo.MinimumWidth = 6;
            this.nombre_antiguo.Name = "nombre_antiguo";
            this.nombre_antiguo.ReadOnly = true;
            this.nombre_antiguo.Width = 122;
            // 
            // nombre_actual
            // 
            this.nombre_actual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre_actual.DataPropertyName = "nombre_actual";
            this.nombre_actual.HeaderText = "Nombre Actual";
            this.nombre_actual.MinimumWidth = 6;
            this.nombre_actual.Name = "nombre_actual";
            this.nombre_actual.ReadOnly = true;
            this.nombre_actual.Width = 115;
            // 
            // apellidos_antiguo
            // 
            this.apellidos_antiguo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.apellidos_antiguo.DataPropertyName = "apellidos_antiguo";
            this.apellidos_antiguo.HeaderText = "Apellido Antiguo";
            this.apellidos_antiguo.MinimumWidth = 6;
            this.apellidos_antiguo.Name = "apellidos_antiguo";
            this.apellidos_antiguo.ReadOnly = true;
            this.apellidos_antiguo.Width = 123;
            // 
            // apellidos_actual
            // 
            this.apellidos_actual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.apellidos_actual.DataPropertyName = "apellidos_actual";
            this.apellidos_actual.HeaderText = "Apellido Actual";
            this.apellidos_actual.MinimumWidth = 6;
            this.apellidos_actual.Name = "apellidos_actual";
            this.apellidos_actual.ReadOnly = true;
            this.apellidos_actual.Width = 116;
            // 
            // rfc_antiguo
            // 
            this.rfc_antiguo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rfc_antiguo.DataPropertyName = "rfc_antiguo";
            this.rfc_antiguo.HeaderText = "RFC Antiguo";
            this.rfc_antiguo.MinimumWidth = 6;
            this.rfc_antiguo.Name = "rfc_antiguo";
            this.rfc_antiguo.ReadOnly = true;
            this.rfc_antiguo.Width = 102;
            // 
            // rfc_actual
            // 
            this.rfc_actual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rfc_actual.DataPropertyName = "rfc_actual";
            this.rfc_actual.HeaderText = "RFC Actual";
            this.rfc_actual.MinimumWidth = 6;
            this.rfc_actual.Name = "rfc_actual";
            this.rfc_actual.ReadOnly = true;
            this.rfc_actual.Width = 95;
            // 
            // correo_antiguo
            // 
            this.correo_antiguo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.correo_antiguo.DataPropertyName = "correo_antiguo";
            this.correo_antiguo.HeaderText = "Correo Antiguo";
            this.correo_antiguo.MinimumWidth = 6;
            this.correo_antiguo.Name = "correo_antiguo";
            this.correo_antiguo.ReadOnly = true;
            this.correo_antiguo.Width = 115;
            // 
            // correo_actual
            // 
            this.correo_actual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.correo_actual.DataPropertyName = "correo_actual";
            this.correo_actual.HeaderText = "Correo Actual";
            this.correo_actual.MinimumWidth = 6;
            this.correo_actual.Name = "correo_actual";
            this.correo_actual.ReadOnly = true;
            this.correo_actual.Width = 108;
            // 
            // fecha_operacion
            // 
            this.fecha_operacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecha_operacion.DataPropertyName = "fecha_operacion";
            this.fecha_operacion.HeaderText = "Fecha de Operación";
            this.fecha_operacion.MinimumWidth = 6;
            this.fecha_operacion.Name = "fecha_operacion";
            this.fecha_operacion.ReadOnly = true;
            this.fecha_operacion.Width = 146;
            // 
            // usuario
            // 
            this.usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "Usuario ";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 86;
            // 
            // FrmReporteClienteUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 658);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dlistado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteClienteUpdate";
            this.Text = "FrmReporteClienteUpdate";
            this.Load += new System.EventHandler(this.FrmReporteClienteUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dlistado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_antiguo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos_antiguo;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfc_antiguo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfc_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo_antiguo;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_operacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
    }
}