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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBajaSocio = new System.Windows.Forms.Button();
            this.lblEstadoSocio = new System.Windows.Forms.Label();
            this.cbEstadoSocio = new System.Windows.Forms.ComboBox();
            this.btnAgregarSocio = new System.Windows.Forms.Button();
            this.btnReactivar = new System.Windows.Forms.Button();
            this.NroSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRenuncia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotivoRenuncia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgregarSocioTitulo
            // 
            this.lblAgregarSocioTitulo.AutoSize = true;
            this.lblAgregarSocioTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarSocioTitulo.Font = new System.Drawing.Font("Lucida Fax", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarSocioTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblAgregarSocioTitulo.Location = new System.Drawing.Point(330, 9);
            this.lblAgregarSocioTitulo.Name = "lblAgregarSocioTitulo";
            this.lblAgregarSocioTitulo.Size = new System.Drawing.Size(102, 32);
            this.lblAgregarSocioTitulo.TabIndex = 2;
            this.lblAgregarSocioTitulo.Text = "Socios";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.tbNombre.Location = new System.Drawing.Point(124, 138);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(490, 30);
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
            this.tbApellido.Size = new System.Drawing.Size(490, 30);
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
            this.tbDni.Size = new System.Drawing.Size(328, 30);
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
            this.dgvResultadoSocios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultadoSocios.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultadoSocios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultadoSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroSocio,
            this.Dni,
            this.Nombre,
            this.Apellido,
            this.Domicilio,
            this.FechaIngreso,
            this.Estado,
            this.FechaRenuncia,
            this.MotivoRenuncia});
            this.dgvResultadoSocios.EnableHeadersVisualStyles = false;
            this.dgvResultadoSocios.Location = new System.Drawing.Point(12, 187);
            this.dgvResultadoSocios.MultiSelect = false;
            this.dgvResultadoSocios.Name = "dgvResultadoSocios";
            this.dgvResultadoSocios.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultadoSocios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultadoSocios.RowHeadersVisible = false;
            this.dgvResultadoSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultadoSocios.Size = new System.Drawing.Size(854, 210);
            this.dgvResultadoSocios.TabIndex = 13;
            // 
            // btnBuscarSocios
            // 
            this.btnBuscarSocios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBuscarSocios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarSocios.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnBuscarSocios.Location = new System.Drawing.Point(632, 124);
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
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(766, 124);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(119, 44);
            this.btnLimpiarFiltros.TabIndex = 5;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Navy;
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(695, 417);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 33);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnModificar.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnModificar.Location = new System.Drawing.Point(308, 417);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 33);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificarSocio_Click);
            // 
            // btnBajaSocio
            // 
            this.btnBajaSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBajaSocio.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnBajaSocio.Location = new System.Drawing.Point(23, 417);
            this.btnBajaSocio.Name = "btnBajaSocio";
            this.btnBajaSocio.Size = new System.Drawing.Size(136, 33);
            this.btnBajaSocio.TabIndex = 16;
            this.btnBajaSocio.Text = "Dar de Baja";
            this.btnBajaSocio.UseVisualStyleBackColor = false;
            this.btnBajaSocio.Click += new System.EventHandler(this.btnBajaSocio_Click);
            // 
            // lblEstadoSocio
            // 
            this.lblEstadoSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoSocio.AutoSize = true;
            this.lblEstadoSocio.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoSocio.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoSocio.Location = new System.Drawing.Point(658, 69);
            this.lblEstadoSocio.Name = "lblEstadoSocio";
            this.lblEstadoSocio.Size = new System.Drawing.Size(75, 22);
            this.lblEstadoSocio.TabIndex = 17;
            this.lblEstadoSocio.Text = "Estado";
            // 
            // cbEstadoSocio
            // 
            this.cbEstadoSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEstadoSocio.BackColor = System.Drawing.SystemColors.Menu;
            this.cbEstadoSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoSocio.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoSocio.FormattingEnabled = true;
            this.cbEstadoSocio.Items.AddRange(new object[] {
            "ACTIVOS",
            "DADOS DE BAJA",
            "TODOS"});
            this.cbEstadoSocio.Location = new System.Drawing.Point(735, 67);
            this.cbEstadoSocio.Name = "cbEstadoSocio";
            this.cbEstadoSocio.Size = new System.Drawing.Size(155, 25);
            this.cbEstadoSocio.TabIndex = 18;
            // 
            // btnAgregarSocio
            // 
            this.btnAgregarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregarSocio.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnAgregarSocio.Location = new System.Drawing.Point(450, 417);
            this.btnAgregarSocio.Name = "btnAgregarSocio";
            this.btnAgregarSocio.Size = new System.Drawing.Size(149, 33);
            this.btnAgregarSocio.TabIndex = 19;
            this.btnAgregarSocio.Text = "Nuevo Socio";
            this.btnAgregarSocio.UseVisualStyleBackColor = false;
            this.btnAgregarSocio.Click += new System.EventHandler(this.btnAgregarSocio_Click);
            // 
            // btnReactivar
            // 
            this.btnReactivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReactivar.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnReactivar.Location = new System.Drawing.Point(165, 417);
            this.btnReactivar.Name = "btnReactivar";
            this.btnReactivar.Size = new System.Drawing.Size(136, 33);
            this.btnReactivar.TabIndex = 20;
            this.btnReactivar.Text = "Reactivar";
            this.btnReactivar.UseVisualStyleBackColor = false;
            this.btnReactivar.Click += new System.EventHandler(this.btnReactivar_Click);
            // 
            // NroSocio
            // 
            this.NroSocio.DataPropertyName = "NroSocio";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NroSocio.DefaultCellStyle = dataGridViewCellStyle2;
            this.NroSocio.HeaderText = "Nro. Socio";
            this.NroSocio.Name = "NroSocio";
            this.NroSocio.ReadOnly = true;
            // 
            // Dni
            // 
            this.Dni.DataPropertyName = "DNI";
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
            // FechaIngreso
            // 
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.HeaderText = "Fecha de Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
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
            // FrmFiltroSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.fondo3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 462);
            this.Controls.Add(this.btnReactivar);
            this.Controls.Add(this.btnAgregarSocio);
            this.Controls.Add(this.cbEstadoSocio);
            this.Controls.Add(this.lblEstadoSocio);
            this.Controls.Add(this.btnBajaSocio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBajaSocio;
        private System.Windows.Forms.Label lblEstadoSocio;
        private System.Windows.Forms.ComboBox cbEstadoSocio;
        private System.Windows.Forms.Button btnAgregarSocio;
        private System.Windows.Forms.Button btnReactivar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRenuncia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotivoRenuncia;
    }
}