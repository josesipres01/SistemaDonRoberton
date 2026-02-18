namespace CapaPresentacion
{
    partial class MenuReportes
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnelimaciones = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnmodificaciones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReporteSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(330, 325);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 33;
            this.btnsalir.Text = "&Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.UseWaitCursor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnelimaciones
            // 
            this.btnelimaciones.Location = new System.Drawing.Point(233, 110);
            this.btnelimaciones.Name = "btnelimaciones";
            this.btnelimaciones.Size = new System.Drawing.Size(117, 66);
            this.btnelimaciones.TabIndex = 32;
            this.btnelimaciones.Text = "Eliminaciones de  Clientes";
            this.btnelimaciones.UseVisualStyleBackColor = true;
            this.btnelimaciones.Click += new System.EventHandler(this.btnelimaciones_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Serif SC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Seleccione el tipo de reporte que desea ver";
            // 
            // btnmodificaciones
            // 
            this.btnmodificaciones.Location = new System.Drawing.Point(43, 110);
            this.btnmodificaciones.Name = "btnmodificaciones";
            this.btnmodificaciones.Size = new System.Drawing.Size(117, 66);
            this.btnmodificaciones.TabIndex = 30;
            this.btnmodificaciones.Text = "Modificaciones de Clientes";
            this.btnmodificaciones.UseVisualStyleBackColor = true;
            this.btnmodificaciones.Click += new System.EventHandler(this.btnmodificaciones_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Serif SC Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Reportes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnReporteSesion
            // 
            this.btnReporteSesion.Location = new System.Drawing.Point(43, 199);
            this.btnReporteSesion.Name = "btnReporteSesion";
            this.btnReporteSesion.Size = new System.Drawing.Size(117, 54);
            this.btnReporteSesion.TabIndex = 34;
            this.btnReporteSesion.Text = "Registro de Sesiones";
            this.btnReporteSesion.UseVisualStyleBackColor = true;
            this.btnReporteSesion.Click += new System.EventHandler(this.btnReporteSesion_Click);
            // 
            // MenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.btnReporteSesion);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnelimaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnmodificaciones);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MenuReportes";
            this.Text = "Menu Reportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnelimaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnmodificaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReporteSesion;
    }
}