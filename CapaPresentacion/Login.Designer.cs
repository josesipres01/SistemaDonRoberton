namespace CapaPresentacion
{
    partial class Login
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
            this.btnLoginNow = new System.Windows.Forms.Button();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoginNow
            // 
            this.btnLoginNow.Location = new System.Drawing.Point(297, 383);
            this.btnLoginNow.Name = "btnLoginNow";
            this.btnLoginNow.Size = new System.Drawing.Size(117, 31);
            this.btnLoginNow.TabIndex = 11;
            this.btnLoginNow.Text = "Login Now";
            this.btnLoginNow.UseVisualStyleBackColor = true;
            this.btnLoginNow.Click += new System.EventHandler(this.btnLoginNow_Click);
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(180, 231);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(152, 22);
            this.txtcontrasena.TabIndex = 10;
            this.txtcontrasena.UseSystemPasswordChar = true;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(178, 131);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(154, 22);
            this.txtusuario.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Serif SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Serif SC Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Serif SC Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.btnLoginNow);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginNow;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}