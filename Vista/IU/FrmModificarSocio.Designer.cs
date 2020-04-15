namespace Vista.IU
{
    partial class FrmModificarSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarSocio));
            this.cbNacionalidad = new System.Windows.Forms.ComboBox();
            this.dtFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.tbDomicilio = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbNroSocio = new System.Windows.Forms.TextBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblModificarSocioTitulo = new System.Windows.Forms.Label();
            this.lblNroSocio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbNacionalidad
            // 
            this.cbNacionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNacionalidad.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.cbNacionalidad.FormattingEnabled = true;
            this.cbNacionalidad.Items.AddRange(new object[] {
            "Argentina",
            "Boliviana",
            "Brasilera",
            "Chilena",
            "Colombiana",
            "Paraguaya",
            "Peruana",
            "Uruguaya",
            "Venezolana"});
            this.cbNacionalidad.Location = new System.Drawing.Point(297, 307);
            this.cbNacionalidad.Name = "cbNacionalidad";
            this.cbNacionalidad.Size = new System.Drawing.Size(332, 30);
            this.cbNacionalidad.TabIndex = 21;
            // 
            // dtFechaIngreso
            // 
            this.dtFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFechaIngreso.Enabled = false;
            this.dtFechaIngreso.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.dtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIngreso.Location = new System.Drawing.Point(297, 352);
            this.dtFechaIngreso.Name = "dtFechaIngreso";
            this.dtFechaIngreso.Size = new System.Drawing.Size(170, 30);
            this.dtFechaIngreso.TabIndex = 22;
            this.dtFechaIngreso.Value = new System.DateTime(2020, 4, 10, 0, 0, 0, 0);
            // 
            // tbDomicilio
            // 
            this.tbDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDomicilio.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.tbDomicilio.Location = new System.Drawing.Point(297, 261);
            this.tbDomicilio.Name = "tbDomicilio";
            this.tbDomicilio.Size = new System.Drawing.Size(332, 30);
            this.tbDomicilio.TabIndex = 20;
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.tbNombre.Location = new System.Drawing.Point(297, 217);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(332, 30);
            this.tbNombre.TabIndex = 19;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterFilter_KeyPress);
            // 
            // tbApellido
            // 
            this.tbApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApellido.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.tbApellido.Location = new System.Drawing.Point(297, 172);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(332, 30);
            this.tbApellido.TabIndex = 18;
            this.tbApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterFilter_KeyPress);
            // 
            // tbDni
            // 
            this.tbDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDni.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.tbDni.Location = new System.Drawing.Point(297, 126);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(170, 30);
            this.tbDni.TabIndex = 17;
            this.tbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericFilter_KeyPress);
            // 
            // tbNroSocio
            // 
            this.tbNroSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNroSocio.Enabled = false;
            this.tbNroSocio.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.tbNroSocio.Location = new System.Drawing.Point(297, 79);
            this.tbNroSocio.Name = "tbNroSocio";
            this.tbNroSocio.Size = new System.Drawing.Size(93, 30);
            this.tbNroSocio.TabIndex = 8;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(116, 358);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(173, 22);
            this.lblFechaIngreso.TabIndex = 11;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.BackColor = System.Drawing.Color.Transparent;
            this.lblNacionalidad.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.Location = new System.Drawing.Point(153, 310);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(136, 22);
            this.lblNacionalidad.TabIndex = 12;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.BackColor = System.Drawing.Color.Transparent;
            this.lblDomicilio.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(184, 264);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(101, 22);
            this.lblDomicilio.TabIndex = 13;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(198, 220);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 22);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(194, 175);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(91, 22);
            this.lblApellido.TabIndex = 15;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(234, 129);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(47, 22);
            this.lblDni.TabIndex = 16;
            this.lblDni.Text = "DNI";
            // 
            // lblModificarSocioTitulo
            // 
            this.lblModificarSocioTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblModificarSocioTitulo.AutoSize = true;
            this.lblModificarSocioTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblModificarSocioTitulo.Font = new System.Drawing.Font("Lucida Fax", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarSocioTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblModificarSocioTitulo.Location = new System.Drawing.Point(277, 24);
            this.lblModificarSocioTitulo.Name = "lblModificarSocioTitulo";
            this.lblModificarSocioTitulo.Size = new System.Drawing.Size(234, 32);
            this.lblModificarSocioTitulo.TabIndex = 9;
            this.lblModificarSocioTitulo.Text = "Modificar Socio";
            // 
            // lblNroSocio
            // 
            this.lblNroSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNroSocio.AutoSize = true;
            this.lblNroSocio.BackColor = System.Drawing.Color.Transparent;
            this.lblNroSocio.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroSocio.Location = new System.Drawing.Point(176, 82);
            this.lblNroSocio.Name = "lblNroSocio";
            this.lblNroSocio.Size = new System.Drawing.Size(109, 22);
            this.lblNroSocio.TabIndex = 10;
            this.lblNroSocio.Text = "Nro. Socio";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Image = global::Vista.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(414, 405);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(149, 63);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardar.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnGuardar.Image = global::Vista.Properties.Resources.okIcon;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(238, 407);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(149, 63);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmModificarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.fondo3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbNacionalidad);
            this.Controls.Add(this.dtFechaIngreso);
            this.Controls.Add(this.tbDomicilio);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.tbNroSocio);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblModificarSocioTitulo);
            this.Controls.Add(this.lblNroSocio);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmModificarSocio";
            this.Text = "Bomberos Voluntarios - Arroyo Barú";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmModificarSocio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNacionalidad;
        private System.Windows.Forms.DateTimePicker dtFechaIngreso;
        private System.Windows.Forms.TextBox tbDomicilio;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.TextBox tbNroSocio;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblModificarSocioTitulo;
        private System.Windows.Forms.Label lblNroSocio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}