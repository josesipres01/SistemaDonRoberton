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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_antiguo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos_antiguo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfc_antiguo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfc_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo_antiguo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Serif SC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Registros actualizados";
            // 
            // dlistado
            // 
            this.dlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dlistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idcliente,
            this.nombre_antiguo,
            this.nombre_actual,
            this.apellidos_antiguo,
            this.apellidos_actual,
            this.rfc_antiguo,
            this.rfc_actual,
            this.correo_antiguo,
            this.correo_actual,
            this.operacion,
            this.fecha_operacion,
            this.usuario});
            this.dlistado.Location = new System.Drawing.Point(43, 110);
            this.dlistado.Name = "dlistado";
            this.dlistado.RowHeadersWidth = 51;
            this.dlistado.RowTemplate.Height = 24;
            this.dlistado.Size = new System.Drawing.Size(1670, 251);
            this.dlistado.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Serif SC Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Reporte Clientes";
            // 
            // id
            // 
            this.id.DataPropertyName = "id_bit";
            this.id.HeaderText = "id_bit";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // idcliente
            // 
            this.idcliente.DataPropertyName = "idcliente";
            this.idcliente.HeaderText = "id_cliente";
            this.idcliente.MinimumWidth = 6;
            this.idcliente.Name = "idcliente";
            this.idcliente.Width = 125;
            // 
            // nombre_antiguo
            // 
            this.nombre_antiguo.DataPropertyName = "nombre_antiguo";
            this.nombre_antiguo.HeaderText = "nombre_antiguo";
            this.nombre_antiguo.MinimumWidth = 6;
            this.nombre_antiguo.Name = "nombre_antiguo";
            this.nombre_antiguo.Width = 125;
            // 
            // nombre_actual
            // 
            this.nombre_actual.DataPropertyName = "nombre_actual";
            this.nombre_actual.HeaderText = "nombre_actual";
            this.nombre_actual.MinimumWidth = 6;
            this.nombre_actual.Name = "nombre_actual";
            this.nombre_actual.Width = 125;
            // 
            // apellidos_antiguo
            // 
            this.apellidos_antiguo.DataPropertyName = "apellidos_antiguo";
            this.apellidos_antiguo.HeaderText = "apellidos_antiguo";
            this.apellidos_antiguo.MinimumWidth = 6;
            this.apellidos_antiguo.Name = "apellidos_antiguo";
            this.apellidos_antiguo.Width = 125;
            // 
            // apellidos_actual
            // 
            this.apellidos_actual.DataPropertyName = "apellidos_actual";
            this.apellidos_actual.HeaderText = "apellidos_actual";
            this.apellidos_actual.MinimumWidth = 6;
            this.apellidos_actual.Name = "apellidos_actual";
            this.apellidos_actual.Width = 125;
            // 
            // rfc_antiguo
            // 
            this.rfc_antiguo.DataPropertyName = "rfc_antiguo";
            this.rfc_antiguo.HeaderText = "rfc_antiguo";
            this.rfc_antiguo.MinimumWidth = 6;
            this.rfc_antiguo.Name = "rfc_antiguo";
            this.rfc_antiguo.Width = 125;
            // 
            // rfc_actual
            // 
            this.rfc_actual.DataPropertyName = "rfc_actual";
            this.rfc_actual.HeaderText = "rfc_actual";
            this.rfc_actual.MinimumWidth = 6;
            this.rfc_actual.Name = "rfc_actual";
            this.rfc_actual.Width = 125;
            // 
            // correo_antiguo
            // 
            this.correo_antiguo.DataPropertyName = "correo_antiguo";
            this.correo_antiguo.HeaderText = "correo_antiguo";
            this.correo_antiguo.MinimumWidth = 6;
            this.correo_antiguo.Name = "correo_antiguo";
            this.correo_antiguo.Width = 125;
            // 
            // correo_actual
            // 
            this.correo_actual.DataPropertyName = "correo_actual";
            this.correo_actual.HeaderText = "correo_actual";
            this.correo_actual.MinimumWidth = 6;
            this.correo_actual.Name = "correo_actual";
            this.correo_actual.Width = 125;
            // 
            // operacion
            // 
            this.operacion.DataPropertyName = "operacion";
            this.operacion.HeaderText = "operacion";
            this.operacion.MinimumWidth = 6;
            this.operacion.Name = "operacion";
            this.operacion.Width = 125;
            // 
            // fecha_operacion
            // 
            this.fecha_operacion.DataPropertyName = "fecha_operacion";
            this.fecha_operacion.HeaderText = "fecha_operacion";
            this.fecha_operacion.MinimumWidth = 6;
            this.fecha_operacion.Name = "fecha_operacion";
            this.fecha_operacion.Width = 125;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "usuario";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.Width = 125;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(1565, 618);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(90, 36);
            this.btneliminar.TabIndex = 23;
            this.btneliminar.Text = "&Cancelar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // FrmReporteClienteUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1794, 717);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_antiguo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos_antiguo;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfc_antiguo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfc_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo_antiguo;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo_actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn operacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_operacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.Button btneliminar;
    }
}