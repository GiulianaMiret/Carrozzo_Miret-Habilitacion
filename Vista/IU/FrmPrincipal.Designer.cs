namespace Vista.IU
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnSocios = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnRubros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSocios
            // 
            this.btnSocios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSocios.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocios.Image = ((System.Drawing.Image)(resources.GetObject("btnSocios.Image")));
            this.btnSocios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSocios.Location = new System.Drawing.Point(660, 55);
            this.btnSocios.Name = "btnSocios";
            this.btnSocios.Size = new System.Drawing.Size(265, 70);
            this.btnSocios.TabIndex = 0;
            this.btnSocios.Text = "Gestión de Socios";
            this.btnSocios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSocios.UseVisualStyleBackColor = true;
            this.btnSocios.Click += new System.EventHandler(this.btnSocios_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPagos.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.Image = ((System.Drawing.Image)(resources.GetObject("btnPagos.Image")));
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Location = new System.Drawing.Point(660, 172);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(265, 70);
            this.btnPagos.TabIndex = 1;
            this.btnPagos.Text = "Gestión de Pagos";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnRubros
            // 
            this.btnRubros.Location = new System.Drawing.Point(380, 115);
            this.btnRubros.Name = "btnRubros";
            this.btnRubros.Size = new System.Drawing.Size(114, 23);
            this.btnRubros.TabIndex = 1;
            this.btnRubros.Text = "Rubros";
            this.btnRubros.UseVisualStyleBackColor = true;
            this.btnRubros.Click += new System.EventHandler(this.btnRubros_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 450);
            this.Controls.Add(this.btnPagos);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRubros);
            this.Controls.Add(this.btnSocios);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Bomberos Voluntarios - Arroyo Barú";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSocios;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnRubros;
    }
}