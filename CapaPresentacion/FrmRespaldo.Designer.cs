namespace CapaPresentacion
{
    partial class FrmRespaldo
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
            this.btngenerarrespaldo = new System.Windows.Forms.Button();
            this.btnrestaurarbd = new System.Windows.Forms.Button();
            this.txtRutaGenerar = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtRutaCargar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btngenerarrespaldo
            // 
            this.btngenerarrespaldo.Location = new System.Drawing.Point(63, 102);
            this.btngenerarrespaldo.Name = "btngenerarrespaldo";
            this.btngenerarrespaldo.Size = new System.Drawing.Size(122, 49);
            this.btngenerarrespaldo.TabIndex = 2;
            this.btngenerarrespaldo.Text = "Generar Respaldo";
            this.btngenerarrespaldo.UseVisualStyleBackColor = true;
            this.btngenerarrespaldo.Click += new System.EventHandler(this.btngenerarrespaldo_Click);
            // 
            // btnrestaurarbd
            // 
            this.btnrestaurarbd.Location = new System.Drawing.Point(287, 104);
            this.btnrestaurarbd.Name = "btnrestaurarbd";
            this.btnrestaurarbd.Size = new System.Drawing.Size(122, 49);
            this.btnrestaurarbd.TabIndex = 3;
            this.btnrestaurarbd.Text = "Restaurar Base de Datos";
            this.btnrestaurarbd.UseVisualStyleBackColor = true;
            this.btnrestaurarbd.Click += new System.EventHandler(this.btnrestaurarbd_Click);
            // 
            // txtRutaGenerar
            // 
            this.txtRutaGenerar.Location = new System.Drawing.Point(63, 195);
            this.txtRutaGenerar.Name = "txtRutaGenerar";
            this.txtRutaGenerar.Size = new System.Drawing.Size(100, 20);
            this.txtRutaGenerar.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(176, 261);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // txtRutaCargar
            // 
            this.txtRutaCargar.Location = new System.Drawing.Point(309, 195);
            this.txtRutaCargar.Name = "txtRutaCargar";
            this.txtRutaCargar.Size = new System.Drawing.Size(100, 20);
            this.txtRutaCargar.TabIndex = 6;
            // 
            // FrmRespaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.txtRutaCargar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtRutaGenerar);
            this.Controls.Add(this.btnrestaurarbd);
            this.Controls.Add(this.btngenerarrespaldo);
            this.Name = "FrmRespaldo";
            this.Text = "FrmRespaldo";
            this.Load += new System.EventHandler(this.FrmRespaldo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngenerarrespaldo;
        private System.Windows.Forms.Button btnrestaurarbd;
        private System.Windows.Forms.TextBox txtRutaGenerar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtRutaCargar;
    }
}