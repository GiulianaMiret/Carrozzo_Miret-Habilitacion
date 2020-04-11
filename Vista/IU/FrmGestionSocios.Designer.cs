namespace Vista.IU
{
    partial class FrmGestionSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionSocios));
            this.btnAgregarSocio = new System.Windows.Forms.Button();
            this.lblAgregarSocioTitulo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarSocio
            // 
            this.btnAgregarSocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarSocio.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnAgregarSocio.Location = new System.Drawing.Point(241, 93);
            this.btnAgregarSocio.Name = "btnAgregarSocio";
            this.btnAgregarSocio.Size = new System.Drawing.Size(255, 39);
            this.btnAgregarSocio.TabIndex = 0;
            this.btnAgregarSocio.Text = "Agregar Nuevo Socio";
            this.btnAgregarSocio.UseVisualStyleBackColor = true;
            this.btnAgregarSocio.Click += new System.EventHandler(this.btnAgregarSocio_Click);
            // 
            // lblAgregarSocioTitulo
            // 
            this.lblAgregarSocioTitulo.AutoSize = true;
            this.lblAgregarSocioTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarSocioTitulo.Font = new System.Drawing.Font("Lucida Fax", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarSocioTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblAgregarSocioTitulo.Location = new System.Drawing.Point(235, 25);
            this.lblAgregarSocioTitulo.Name = "lblAgregarSocioTitulo";
            this.lblAgregarSocioTitulo.Size = new System.Drawing.Size(258, 32);
            this.lblAgregarSocioTitulo.TabIndex = 1;
            this.lblAgregarSocioTitulo.Text = "Gestión de Socios";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardar.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnGuardar.Location = new System.Drawing.Point(32, 405);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(185, 33);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Volver Atrás";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // FrmGestionSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblAgregarSocioTitulo);
            this.Controls.Add(this.btnAgregarSocio);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestionSocios";
            this.Text = "Bomberos Voluntarios Arroyo Barú - GESTIÓN DE SOCIOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarSocio;
        private System.Windows.Forms.Label lblAgregarSocioTitulo;
        private System.Windows.Forms.Button btnGuardar;
    }
}