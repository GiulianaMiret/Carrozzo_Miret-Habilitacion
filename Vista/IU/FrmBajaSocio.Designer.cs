namespace Vista.IU
{
    partial class FrmBajaSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBajaSocio));
            this.lblBajaSocioTitulo = new System.Windows.Forms.Label();
            this.dtFechaRenuncia = new System.Windows.Forms.DateTimePicker();
            this.tbMotivoRenuncia = new System.Windows.Forms.TextBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNroSocio = new System.Windows.Forms.Label();
            this.lblFechaRenuncia = new System.Windows.Forms.Label();
            this.lblMotivoRenuncia = new System.Windows.Forms.Label();
            this.lblFechaIngresoValor = new System.Windows.Forms.Label();
            this.lblNacionalidadValor = new System.Windows.Forms.Label();
            this.lblDomicilioValor = new System.Windows.Forms.Label();
            this.lblNombreValor = new System.Windows.Forms.Label();
            this.lblApellidoValor = new System.Windows.Forms.Label();
            this.lblDniValor = new System.Windows.Forms.Label();
            this.lblNroSocioValor = new System.Windows.Forms.Label();
            this.groupBoxDatoSocio = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBoxDatoSocio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBajaSocioTitulo
            // 
            this.lblBajaSocioTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBajaSocioTitulo.AutoSize = true;
            this.lblBajaSocioTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblBajaSocioTitulo.Font = new System.Drawing.Font("Lucida Fax", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBajaSocioTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblBajaSocioTitulo.Location = new System.Drawing.Point(292, 29);
            this.lblBajaSocioTitulo.Name = "lblBajaSocioTitulo";
            this.lblBajaSocioTitulo.Size = new System.Drawing.Size(203, 32);
            this.lblBajaSocioTitulo.TabIndex = 12;
            this.lblBajaSocioTitulo.Text = "Baja de Socio";
            // 
            // dtFechaRenuncia
            // 
            this.dtFechaRenuncia.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.dtFechaRenuncia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaRenuncia.Location = new System.Drawing.Point(594, 104);
            this.dtFechaRenuncia.Name = "dtFechaRenuncia";
            this.dtFechaRenuncia.Size = new System.Drawing.Size(170, 30);
            this.dtFechaRenuncia.TabIndex = 0;
            this.dtFechaRenuncia.Value = new System.DateTime(2020, 4, 10, 0, 0, 0, 0);
            // 
            // tbMotivoRenuncia
            // 
            this.tbMotivoRenuncia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMotivoRenuncia.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMotivoRenuncia.Location = new System.Drawing.Point(443, 193);
            this.tbMotivoRenuncia.Multiline = true;
            this.tbMotivoRenuncia.Name = "tbMotivoRenuncia";
            this.tbMotivoRenuncia.Size = new System.Drawing.Size(332, 175);
            this.tbMotivoRenuncia.TabIndex = 1;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(6, 246);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(179, 22);
            this.lblFechaIngreso.TabIndex = 15;
            this.lblFechaIngreso.Text = "Fecha de Ingreso:";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.BackColor = System.Drawing.Color.Transparent;
            this.lblNacionalidad.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.Location = new System.Drawing.Point(9, 206);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(142, 22);
            this.lblNacionalidad.TabIndex = 16;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.BackColor = System.Drawing.Color.Transparent;
            this.lblDomicilio.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(9, 170);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(107, 22);
            this.lblDomicilio.TabIndex = 17;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(10, 132);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 22);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(10, 98);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(97, 22);
            this.lblApellido.TabIndex = 19;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            this.lblDni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.Black;
            this.lblDni.Location = new System.Drawing.Point(12, 66);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(53, 22);
            this.lblDni.TabIndex = 20;
            this.lblDni.Text = "DNI:";
            // 
            // lblNroSocio
            // 
            this.lblNroSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNroSocio.AutoSize = true;
            this.lblNroSocio.BackColor = System.Drawing.Color.Transparent;
            this.lblNroSocio.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroSocio.ForeColor = System.Drawing.Color.Black;
            this.lblNroSocio.Location = new System.Drawing.Point(14, 37);
            this.lblNroSocio.Name = "lblNroSocio";
            this.lblNroSocio.Size = new System.Drawing.Size(115, 22);
            this.lblNroSocio.TabIndex = 14;
            this.lblNroSocio.Text = "Nro. Socio:";
            // 
            // lblFechaRenuncia
            // 
            this.lblFechaRenuncia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaRenuncia.AutoSize = true;
            this.lblFechaRenuncia.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaRenuncia.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRenuncia.Location = new System.Drawing.Point(400, 110);
            this.lblFechaRenuncia.Name = "lblFechaRenuncia";
            this.lblFechaRenuncia.Size = new System.Drawing.Size(188, 22);
            this.lblFechaRenuncia.TabIndex = 27;
            this.lblFechaRenuncia.Text = "Fecha de Renuncia";
            // 
            // lblMotivoRenuncia
            // 
            this.lblMotivoRenuncia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMotivoRenuncia.AutoSize = true;
            this.lblMotivoRenuncia.BackColor = System.Drawing.Color.Transparent;
            this.lblMotivoRenuncia.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoRenuncia.Location = new System.Drawing.Point(508, 168);
            this.lblMotivoRenuncia.Name = "lblMotivoRenuncia";
            this.lblMotivoRenuncia.Size = new System.Drawing.Size(199, 22);
            this.lblMotivoRenuncia.TabIndex = 28;
            this.lblMotivoRenuncia.Text = "Motivo de Renuncia";
            // 
            // lblFechaIngresoValor
            // 
            this.lblFechaIngresoValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaIngresoValor.AutoSize = true;
            this.lblFechaIngresoValor.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaIngresoValor.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngresoValor.ForeColor = System.Drawing.Color.Navy;
            this.lblFechaIngresoValor.Location = new System.Drawing.Point(191, 246);
            this.lblFechaIngresoValor.Name = "lblFechaIngresoValor";
            this.lblFechaIngresoValor.Size = new System.Drawing.Size(173, 22);
            this.lblFechaIngresoValor.TabIndex = 30;
            this.lblFechaIngresoValor.Text = "Fecha de Ingreso";
            // 
            // lblNacionalidadValor
            // 
            this.lblNacionalidadValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNacionalidadValor.AutoSize = true;
            this.lblNacionalidadValor.BackColor = System.Drawing.Color.Transparent;
            this.lblNacionalidadValor.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidadValor.ForeColor = System.Drawing.Color.Navy;
            this.lblNacionalidadValor.Location = new System.Drawing.Point(157, 206);
            this.lblNacionalidadValor.Name = "lblNacionalidadValor";
            this.lblNacionalidadValor.Size = new System.Drawing.Size(136, 22);
            this.lblNacionalidadValor.TabIndex = 31;
            this.lblNacionalidadValor.Text = "Nacionalidad";
            // 
            // lblDomicilioValor
            // 
            this.lblDomicilioValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDomicilioValor.AutoSize = true;
            this.lblDomicilioValor.BackColor = System.Drawing.Color.Transparent;
            this.lblDomicilioValor.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilioValor.ForeColor = System.Drawing.Color.Navy;
            this.lblDomicilioValor.Location = new System.Drawing.Point(125, 170);
            this.lblDomicilioValor.Name = "lblDomicilioValor";
            this.lblDomicilioValor.Size = new System.Drawing.Size(101, 22);
            this.lblDomicilioValor.TabIndex = 32;
            this.lblDomicilioValor.Text = "Domicilio";
            // 
            // lblNombreValor
            // 
            this.lblNombreValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreValor.AutoSize = true;
            this.lblNombreValor.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreValor.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreValor.ForeColor = System.Drawing.Color.Navy;
            this.lblNombreValor.Location = new System.Drawing.Point(113, 132);
            this.lblNombreValor.Name = "lblNombreValor";
            this.lblNombreValor.Size = new System.Drawing.Size(87, 22);
            this.lblNombreValor.TabIndex = 33;
            this.lblNombreValor.Text = "Nombre";
            // 
            // lblApellidoValor
            // 
            this.lblApellidoValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellidoValor.AutoSize = true;
            this.lblApellidoValor.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoValor.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoValor.ForeColor = System.Drawing.Color.Navy;
            this.lblApellidoValor.Location = new System.Drawing.Point(109, 98);
            this.lblApellidoValor.Name = "lblApellidoValor";
            this.lblApellidoValor.Size = new System.Drawing.Size(91, 22);
            this.lblApellidoValor.TabIndex = 34;
            this.lblApellidoValor.Text = "Apellido";
            // 
            // lblDniValor
            // 
            this.lblDniValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDniValor.AutoSize = true;
            this.lblDniValor.BackColor = System.Drawing.Color.Transparent;
            this.lblDniValor.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniValor.ForeColor = System.Drawing.Color.Navy;
            this.lblDniValor.Location = new System.Drawing.Point(71, 66);
            this.lblDniValor.Name = "lblDniValor";
            this.lblDniValor.Size = new System.Drawing.Size(47, 22);
            this.lblDniValor.TabIndex = 35;
            this.lblDniValor.Text = "DNI";
            // 
            // lblNroSocioValor
            // 
            this.lblNroSocioValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNroSocioValor.AutoSize = true;
            this.lblNroSocioValor.BackColor = System.Drawing.Color.Transparent;
            this.lblNroSocioValor.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroSocioValor.ForeColor = System.Drawing.Color.Navy;
            this.lblNroSocioValor.Location = new System.Drawing.Point(133, 38);
            this.lblNroSocioValor.Name = "lblNroSocioValor";
            this.lblNroSocioValor.Size = new System.Drawing.Size(109, 22);
            this.lblNroSocioValor.TabIndex = 29;
            this.lblNroSocioValor.Text = "Nro. Socio";
            // 
            // groupBoxDatoSocio
            // 
            this.groupBoxDatoSocio.Controls.Add(this.lblFechaIngresoValor);
            this.groupBoxDatoSocio.Controls.Add(this.lblNroSocio);
            this.groupBoxDatoSocio.Controls.Add(this.lblNacionalidadValor);
            this.groupBoxDatoSocio.Controls.Add(this.lblNroSocioValor);
            this.groupBoxDatoSocio.Controls.Add(this.lblDomicilioValor);
            this.groupBoxDatoSocio.Controls.Add(this.lblDniValor);
            this.groupBoxDatoSocio.Controls.Add(this.lblFechaIngreso);
            this.groupBoxDatoSocio.Controls.Add(this.lblNombreValor);
            this.groupBoxDatoSocio.Controls.Add(this.lblDni);
            this.groupBoxDatoSocio.Controls.Add(this.lblApellidoValor);
            this.groupBoxDatoSocio.Controls.Add(this.lblNacionalidad);
            this.groupBoxDatoSocio.Controls.Add(this.lblApellido);
            this.groupBoxDatoSocio.Controls.Add(this.lblDomicilio);
            this.groupBoxDatoSocio.Controls.Add(this.lblNombre);
            this.groupBoxDatoSocio.Font = new System.Drawing.Font("Lucida Fax", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatoSocio.Location = new System.Drawing.Point(3, 84);
            this.groupBoxDatoSocio.Name = "groupBoxDatoSocio";
            this.groupBoxDatoSocio.Size = new System.Drawing.Size(382, 284);
            this.groupBoxDatoSocio.TabIndex = 36;
            this.groupBoxDatoSocio.TabStop = false;
            this.groupBoxDatoSocio.Text = "Datos del Socio";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(404, 405);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 33);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardar.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnGuardar.Location = new System.Drawing.Point(225, 405);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 33);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmBajaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblMotivoRenuncia);
            this.Controls.Add(this.lblFechaRenuncia);
            this.Controls.Add(this.dtFechaRenuncia);
            this.Controls.Add(this.tbMotivoRenuncia);
            this.Controls.Add(this.lblBajaSocioTitulo);
            this.Controls.Add(this.groupBoxDatoSocio);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBajaSocio";
            this.Text = "Bomberos Voluntarios - Arroyo Barú";
            this.Load += new System.EventHandler(this.FrmBajaSocio_Load);
            this.groupBoxDatoSocio.ResumeLayout(false);
            this.groupBoxDatoSocio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBajaSocioTitulo;
        private System.Windows.Forms.DateTimePicker dtFechaRenuncia;
        private System.Windows.Forms.TextBox tbMotivoRenuncia;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNroSocio;
        private System.Windows.Forms.Label lblFechaRenuncia;
        private System.Windows.Forms.Label lblMotivoRenuncia;
        private System.Windows.Forms.Label lblFechaIngresoValor;
        private System.Windows.Forms.Label lblNacionalidadValor;
        private System.Windows.Forms.Label lblDomicilioValor;
        private System.Windows.Forms.Label lblNombreValor;
        private System.Windows.Forms.Label lblApellidoValor;
        private System.Windows.Forms.Label lblDniValor;
        private System.Windows.Forms.Label lblNroSocioValor;
        private System.Windows.Forms.GroupBox groupBoxDatoSocio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}