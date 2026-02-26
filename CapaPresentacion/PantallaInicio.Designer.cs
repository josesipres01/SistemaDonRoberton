namespace CapaPresentacion
{
    partial class PantallaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnProducti = new MaterialSkin.Controls.MaterialButton();
            this.btnCerrarSesion1 = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCategorias = new MaterialSkin.Controls.MaterialButton();
            this.btnClientes = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnReportes = new MaterialSkin.Controls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.AutoScroll = true;
            this.pnlContenedor.Location = new System.Drawing.Point(214, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(977, 669);
            this.pnlContenedor.TabIndex = 11;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSidebar.Controls.Add(this.btnProducti);
            this.pnlSidebar.Controls.Add(this.btnCerrarSesion1);
            this.pnlSidebar.Controls.Add(this.label1);
            this.pnlSidebar.Controls.Add(this.btnCategorias);
            this.pnlSidebar.Controls.Add(this.btnClientes);
            this.pnlSidebar.Controls.Add(this.materialLabel1);
            this.pnlSidebar.Controls.Add(this.btnReportes);
            this.pnlSidebar.Controls.Add(this.label2);
            this.pnlSidebar.Controls.Add(this.label3);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(214, 590);
            this.pnlSidebar.TabIndex = 11;
            this.pnlSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSidebar_Paint);
            // 
            // btnProducti
            // 
            this.btnProducti.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProducti.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProducti.Depth = 0;
            this.btnProducti.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProducti.FlatAppearance.BorderSize = 0;
            this.btnProducti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducti.HighEmphasis = false;
            this.btnProducti.Icon = ((System.Drawing.Image)(resources.GetObject("btnProducti.Icon")));
            this.btnProducti.Location = new System.Drawing.Point(20, 120);
            this.btnProducti.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProducti.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProducti.Name = "btnProducti";
            this.btnProducti.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProducti.Size = new System.Drawing.Size(135, 36);
            this.btnProducti.TabIndex = 4;
            this.btnProducti.Text = "Productos";
            this.btnProducti.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnProducti.UseAccentColor = false;
            this.btnProducti.UseVisualStyleBackColor = false;
            this.btnProducti.Click += new System.EventHandler(this.btnProducti_Click);
            // 
            // btnCerrarSesion1
            // 
            this.btnCerrarSesion1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarSesion1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCerrarSesion1.Depth = 0;
            this.btnCerrarSesion1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarSesion1.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion1.HighEmphasis = false;
            this.btnCerrarSesion1.Icon = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion1.Icon")));
            this.btnCerrarSesion1.Location = new System.Drawing.Point(13, 512);
            this.btnCerrarSesion1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrarSesion1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSesion1.Name = "btnCerrarSesion1";
            this.btnCerrarSesion1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrarSesion1.Size = new System.Drawing.Size(159, 36);
            this.btnCerrarSesion1.TabIndex = 10;
            this.btnCerrarSesion1.Text = "Cerrar Sesion";
            this.btnCerrarSesion1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnCerrarSesion1.UseAccentColor = false;
            this.btnCerrarSesion1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "DonRoberton";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCategorias
            // 
            this.btnCategorias.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCategorias.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCategorias.Depth = 0;
            this.btnCategorias.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.HighEmphasis = false;
            this.btnCategorias.Icon = ((System.Drawing.Image)(resources.GetObject("btnCategorias.Icon")));
            this.btnCategorias.Location = new System.Drawing.Point(23, 238);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCategorias.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCategorias.Size = new System.Drawing.Size(138, 36);
            this.btnCategorias.TabIndex = 6;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnCategorias.UseAccentColor = false;
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClientes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClientes.Depth = 0;
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.HighEmphasis = false;
            this.btnClientes.Icon = ((System.Drawing.Image)(resources.GetObject("btnClientes.Icon")));
            this.btnClientes.Location = new System.Drawing.Point(20, 178);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClientes.Size = new System.Drawing.Size(116, 36);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClientes.UseAccentColor = false;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Image = ((System.Drawing.Image)(resources.GetObject("materialLabel1.Image")));
            this.materialLabel1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.materialLabel1.Location = new System.Drawing.Point(53, 58);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(1, 0);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReportes
            // 
            this.btnReportes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReportes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReportes.Depth = 0;
            this.btnReportes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.HighEmphasis = false;
            this.btnReportes.Icon = ((System.Drawing.Image)(resources.GetObject("btnReportes.Icon")));
            this.btnReportes.Location = new System.Drawing.Point(25, 298);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReportes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReportes.Size = new System.Drawing.Size(122, 36);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnReportes.UseAccentColor = false;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "General";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.Location = new System.Drawing.Point(138, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 8;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 590);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PantallaInicio";
            this.Text = "PantallaInicio";
            this.Load += new System.EventHandler(this.PantallaInicio_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlSidebar;
        private MaterialSkin.Controls.MaterialButton btnProducti;
        private MaterialSkin.Controls.MaterialButton btnCerrarSesion1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnCategorias;
        private MaterialSkin.Controls.MaterialButton btnClientes;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnReportes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}