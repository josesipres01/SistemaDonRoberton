namespace CapaPresentacion
{
    partial class FrmReporteSesiones
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
            this.btneliminar = new System.Windows.Forms.Button();
            this.dlistado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_antiguo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos_antiguo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfc_antiguo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Serif SC", 12F);
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tiempo de Sesiones";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(521, 390);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(90, 36);
            this.btneliminar.TabIndex = 21;
            this.btneliminar.Text = "&Cancelar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // dlistado
            // 
            this.dlistado.AllowUserToAddRows = false;
            this.dlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dlistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.nombre_antiguo,
            this.apellidos_antiguo,
            this.rfc_antiguo});
            this.dlistado.Location = new System.Drawing.Point(19, 108);
            this.dlistado.Name = "dlistado";
            this.dlistado.RowHeadersWidth = 51;
            this.dlistado.RowTemplate.Height = 24;
            this.dlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dlistado.Size = new System.Drawing.Size(592, 251);
            this.dlistado.TabIndex = 20;
            this.dlistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dlistado_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Serif SC Black", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Reporte de Sesiones";
            // 
            // id_cliente
            // 
            this.id_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id_cliente.DataPropertyName = "usuario";
            this.id_cliente.HeaderText = "Usuario";
            this.id_cliente.MinimumWidth = 6;
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.Width = 83;
            // 
            // nombre_antiguo
            // 
            this.nombre_antiguo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre_antiguo.DataPropertyName = "fecha_entrada";
            this.nombre_antiguo.HeaderText = "Fecha de Inicio ";
            this.nombre_antiguo.MinimumWidth = 6;
            this.nombre_antiguo.Name = "nombre_antiguo";
            this.nombre_antiguo.Width = 89;
            // 
            // apellidos_antiguo
            // 
            this.apellidos_antiguo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.apellidos_antiguo.DataPropertyName = "fecha_salida";
            this.apellidos_antiguo.HeaderText = "Fecha Salida";
            this.apellidos_antiguo.MinimumWidth = 6;
            this.apellidos_antiguo.Name = "apellidos_antiguo";
            this.apellidos_antiguo.Width = 107;
            // 
            // rfc_antiguo
            // 
            this.rfc_antiguo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rfc_antiguo.DataPropertyName = "duracion_segundos";
            this.rfc_antiguo.HeaderText = "Tiempo de Sesion";
            this.rfc_antiguo.MinimumWidth = 6;
            this.rfc_antiguo.Name = "rfc_antiguo";
            this.rfc_antiguo.Width = 97;
            // 
            // FrmReporteSesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 509);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.dlistado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReporteSesiones";
            this.Text = "Reporte de Sesiones";
            this.Load += new System.EventHandler(this.FrmReporteSesiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridView dlistado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_antiguo;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos_antiguo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfc_antiguo;
    }
}