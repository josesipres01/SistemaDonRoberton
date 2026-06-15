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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btngenerarrespaldo
            // 
            this.btngenerarrespaldo.Location = new System.Drawing.Point(84, 126);
            this.btngenerarrespaldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngenerarrespaldo.Name = "btngenerarrespaldo";
            this.btngenerarrespaldo.Size = new System.Drawing.Size(163, 60);
            this.btngenerarrespaldo.TabIndex = 2;
            this.btngenerarrespaldo.Text = "Generar Respaldo";
            this.btngenerarrespaldo.UseVisualStyleBackColor = true;
            this.btngenerarrespaldo.Click += new System.EventHandler(this.btngenerarrespaldo_Click);
            // 
            // btnrestaurarbd
            // 
            this.btnrestaurarbd.Location = new System.Drawing.Point(381, 126);
            this.btnrestaurarbd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrestaurarbd.Name = "btnrestaurarbd";
            this.btnrestaurarbd.Size = new System.Drawing.Size(163, 60);
            this.btnrestaurarbd.TabIndex = 3;
            this.btnrestaurarbd.Text = "Restaurar Base de Datos";
            this.btnrestaurarbd.UseVisualStyleBackColor = true;
            this.btnrestaurarbd.Click += new System.EventHandler(this.btnrestaurarbd_Click);
            // 
            // txtRutaGenerar
            // 
            this.txtRutaGenerar.Location = new System.Drawing.Point(87, 240);
            this.txtRutaGenerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRutaGenerar.Name = "txtRutaGenerar";
            this.txtRutaGenerar.Size = new System.Drawing.Size(160, 22);
            this.txtRutaGenerar.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(235, 321);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(133, 28);
            this.progressBar1.TabIndex = 5;
            // 
            // txtRutaCargar
            // 
            this.txtRutaCargar.Location = new System.Drawing.Point(372, 240);
            this.txtRutaCargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRutaCargar.Name = "txtRutaCargar";
            this.txtRutaCargar.Size = new System.Drawing.Size(172, 22);
            this.txtRutaCargar.TabIndex = 6;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(84, 214);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(166, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Ubicación del Respaldo";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(378, 214);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(166, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Ubicación del Respaldo";
            // 
            // FrmRespaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 554);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtRutaCargar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtRutaGenerar);
            this.Controls.Add(this.btnrestaurarbd);
            this.Controls.Add(this.btngenerarrespaldo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}