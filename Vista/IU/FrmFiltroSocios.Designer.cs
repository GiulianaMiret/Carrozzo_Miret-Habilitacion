namespace Vista.IU
{
    partial class FrmFiltroSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiltroSocios));
            this.lblAgregarSocioTitulo = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbNroSocio = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNroSocio = new System.Windows.Forms.Label();
            this.dgvResultadoSocios = new System.Windows.Forms.DataGridView();
            this.btnBuscarSocios = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRenuncia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotivoRenuncia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditarBaja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgregarSocioTitulo
            // 
            this.lblAgregarSocioTitulo.AutoSize = true;
            this.lblAgregarSocioTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarSocioTitulo.Font = new System.Drawing.Font("Lucida Fax", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarSocioTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblAgregarSocioTitulo.Location = new System.Drawing.Point(263, 19);
            this.lblAgregarSocioTitulo.Name = "lblAgregarSocioTitulo";
            this.lblAgregarSocioTitulo.Size = new System.Drawing.Size(193, 32);
            this.lblAgregarSocioTitulo.TabIndex = 2;
            this.lblAgregarSocioTitulo.Text = "Buscar Socio";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.tbNombre.Location = new System.Drawing.Point(124, 138);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(332, 30);
            this.tbNombre.TabIndex = 3;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterFilter_KeyPress);
            // 
            // tbApellido
            // 
            this.tbApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApellido.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.tbApellido.Location = new System.Drawing.Point(124, 102);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(332, 30);
            this.tbApellido.TabIndex = 2;
            this.tbApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letterFilter_KeyPress);
            // 
            // tbDni
            // 
            this.tbDni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDni.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.tbDni.Location = new System.Drawing.Point(286, 66);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(170, 30);
            this.tbDni.TabIndex = 1;
            this.tbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericFilter_KeyPress);
            // 
            // tbNroSocio
            // 
            this.tbNroSocio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbNroSocio.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.tbNroSocio.Location = new System.Drawing.Point(124, 66);
            this.tbNroSocio.Name = "tbNroSocio";
            this.tbNroSocio.Size = new System.Drawing.Size(93, 30);
            this.tbNroSocio.TabIndex = 0;
            this.tbNroSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericFilter_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(35, 141);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 22);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(31, 105);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(91, 22);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(233, 69);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(47, 22);
            this.lblDni.TabIndex = 9;
            this.lblDni.Text = "DNI";
            // 
            // lblNroSocio
            // 
            this.lblNroSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNroSocio.AutoSize = true;
            this.lblNroSocio.BackColor = System.Drawing.Color.Transparent;
            this.lblNroSocio.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroSocio.Location = new System.Drawing.Point(19, 69);
            this.lblNroSocio.Name = "lblNroSocio";
            this.lblNroSocio.Size = new System.Drawing.Size(109, 22);
            this.lblNroSocio.TabIndex = 6;
            this.lblNroSocio.Text = "Nro. Socio";
            // 
            // dgvResultadoSocios
            // 
            this.dgvResultadoSocios.AllowUserToAddRows = false;
            this.dgvResultadoSocios.AllowUserToDeleteRows = false;
            this.dgvResultadoSocios.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvResultadoSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Pagos,
            this.NroSocio,
            this.Dni,
            this.Nombre,
            this.Apellido,
            this.Domicilio,
            this.Nacionalidad,
            this.FechaIngreso,
            this.FechaRenuncia,
            this.MotivoRenuncia});
            this.dgvResultadoSocios.Location = new System.Drawing.Point(58, 187);
            this.dgvResultadoSocios.MultiSelect = false;
            this.dgvResultadoSocios.Name = "dgvResultadoSocios";
            this.dgvResultadoSocios.ReadOnly = true;
            this.dgvResultadoSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultadoSocios.Size = new System.Drawing.Size(643, 210);
            this.dgvResultadoSocios.TabIndex = 13;
            // 
            // btnBuscarSocios
            // 
            this.btnBuscarSocios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBuscarSocios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarSocios.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnBuscarSocios.Location = new System.Drawing.Point(509, 66);
            this.btnBuscarSocios.Name = "btnBuscarSocios";
            this.btnBuscarSocios.Size = new System.Drawing.Size(119, 44);
            this.btnBuscarSocios.TabIndex = 4;
            this.btnBuscarSocios.Text = "Buscar";
            this.btnBuscarSocios.UseVisualStyleBackColor = false;
            this.btnBuscarSocios.Click += new System.EventHandler(this.btnBuscarSocios_Click);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.Silver;
            this.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(509, 124);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(119, 44);
            this.btnLimpiarFiltros.TabIndex = 5;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Pagos
            // 
            this.Pagos.DataPropertyName = "Pagos";
            this.Pagos.HeaderText = "Pagos";
            this.Pagos.Name = "Pagos";
            this.Pagos.ReadOnly = true;
            this.Pagos.Visible = false;
            // 
            // NroSocio
            // 
            this.NroSocio.DataPropertyName = "NroSocio";
            this.NroSocio.HeaderText = "Nro. Socio";
            this.NroSocio.Name = "NroSocio";
            this.NroSocio.ReadOnly = true;
            // 
            // Dni
            // 
            this.Dni.DataPropertyName = "Dni";
            this.Dni.HeaderText = "DNI";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Domicilio
            // 
            this.Domicilio.DataPropertyName = "Domicilio";
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.DataPropertyName = "Nacionalidad";
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.ReadOnly = true;
            this.Nacionalidad.Visible = false;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.HeaderText = "Fecha de Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            // 
            // FechaRenuncia
            // 
            this.FechaRenuncia.DataPropertyName = "FechaRenuncia";
            this.FechaRenuncia.HeaderText = "Fecha de Renuncia";
            this.FechaRenuncia.Name = "FechaRenuncia";
            this.FechaRenuncia.ReadOnly = true;
            this.FechaRenuncia.Visible = false;
            // 
            // MotivoRenuncia
            // 
            this.MotivoRenuncia.DataPropertyName = "MotivoRenuncia";
            this.MotivoRenuncia.HeaderText = "Motivo de Renuncia";
            this.MotivoRenuncia.Name = "MotivoRenuncia";
            this.MotivoRenuncia.ReadOnly = true;
            this.MotivoRenuncia.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(410, 408);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 33);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditarBaja
            // 
            this.btnEditarBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditarBaja.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnEditarBaja.Location = new System.Drawing.Point(231, 408);
            this.btnEditarBaja.Name = "btnEditarBaja";
            this.btnEditarBaja.Size = new System.Drawing.Size(136, 33);
            this.btnEditarBaja.TabIndex = 14;
            this.btnEditarBaja.Text = "Modificar";
            this.btnEditarBaja.UseVisualStyleBackColor = false;
            this.btnEditarBaja.Click += new System.EventHandler(this.btnEditarBaja_Click);
            // 
            // FrmFiltroSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.fondo3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditarBaja);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.btnBuscarSocios);
            this.Controls.Add(this.dgvResultadoSocios);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.tbNroSocio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNroSocio);
            this.Controls.Add(this.lblAgregarSocioTitulo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFiltroSocios";
            this.Text = "Socios";
            this.Load += new System.EventHandler(this.FrmFiltroSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoSocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarSocioTitulo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.TextBox tbNroSocio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNroSocio;
        private System.Windows.Forms.DataGridView dgvResultadoSocios;
        private System.Windows.Forms.Button btnBuscarSocios;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRenuncia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotivoRenuncia;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditarBaja;
    }
}