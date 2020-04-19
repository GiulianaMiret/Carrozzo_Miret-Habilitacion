namespace Vista.IU
{
    partial class FrmGestionPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionPagos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblGestionPagoTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCantidadSocios = new System.Windows.Forms.Label();
            this.lblCantidadText = new System.Windows.Forms.Label();
            this.dgvResultadoSocios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarSocios = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNroSocio = new System.Windows.Forms.Label();
            this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbNroSocio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.btnBuscarPagos = new System.Windows.Forms.Button();
            this.btnAgregarPagos = new System.Windows.Forms.Button();
            this.btnSociosDeudores = new System.Windows.Forms.Button();
            this.btnSociosAldia = new System.Windows.Forms.Button();
            this.NroSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCuotasAdeudadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimaCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoSocios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGestionPagoTitulo
            // 
            this.lblGestionPagoTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGestionPagoTitulo.AutoSize = true;
            this.lblGestionPagoTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblGestionPagoTitulo.Font = new System.Drawing.Font("Lucida Fax", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionPagoTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblGestionPagoTitulo.Location = new System.Drawing.Point(459, 31);
            this.lblGestionPagoTitulo.Name = "lblGestionPagoTitulo";
            this.lblGestionPagoTitulo.Size = new System.Drawing.Size(255, 32);
            this.lblGestionPagoTitulo.TabIndex = 3;
            this.lblGestionPagoTitulo.Text = "Gestión de Pagos";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblCantidadSocios);
            this.panel1.Controls.Add(this.lblCantidadText);
            this.panel1.Controls.Add(this.dgvResultadoSocios);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 561);
            this.panel1.TabIndex = 15;
            // 
            // lblCantidadSocios
            // 
            this.lblCantidadSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidadSocios.AutoSize = true;
            this.lblCantidadSocios.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidadSocios.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadSocios.ForeColor = System.Drawing.Color.Navy;
            this.lblCantidadSocios.Location = new System.Drawing.Point(732, 518);
            this.lblCantidadSocios.Name = "lblCantidadSocios";
            this.lblCantidadSocios.Size = new System.Drawing.Size(26, 26);
            this.lblCantidadSocios.TabIndex = 28;
            this.lblCantidadSocios.Text = "0";
            // 
            // lblCantidadText
            // 
            this.lblCantidadText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidadText.AutoSize = true;
            this.lblCantidadText.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidadText.Font = new System.Drawing.Font("Lucida Fax", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCantidadText.Location = new System.Drawing.Point(516, 518);
            this.lblCantidadText.Name = "lblCantidadText";
            this.lblCantidadText.Size = new System.Drawing.Size(208, 22);
            this.lblCantidadText.TabIndex = 28;
            this.lblCantidadText.Text = "Cantidad de Socios:";
            // 
            // dgvResultadoSocios
            // 
            this.dgvResultadoSocios.AllowUserToAddRows = false;
            this.dgvResultadoSocios.AllowUserToDeleteRows = false;
            this.dgvResultadoSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultadoSocios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultadoSocios.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
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
            this.CantidadCuotasAdeudadas,
            this.UltimaCuota});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultadoSocios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultadoSocios.EnableHeadersVisualStyles = false;
            this.dgvResultadoSocios.Location = new System.Drawing.Point(343, 5);
            this.dgvResultadoSocios.MultiSelect = false;
            this.dgvResultadoSocios.Name = "dgvResultadoSocios";
            this.dgvResultadoSocios.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultadoSocios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResultadoSocios.RowHeadersVisible = false;
            this.dgvResultadoSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultadoSocios.Size = new System.Drawing.Size(771, 390);
            this.dgvResultadoSocios.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnSociosAldia);
            this.groupBox1.Controls.Add(this.btnSociosDeudores);
            this.groupBox1.Controls.Add(this.btnBuscarSocios);
            this.groupBox1.Controls.Add(this.btnLimpiarFiltros);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNroSocio);
            this.groupBox1.Controls.Add(this.dtFechaDesde);
            this.groupBox1.Controls.Add(this.tbDni);
            this.groupBox1.Controls.Add(this.tbNroSocio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblDni);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 550);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Pagos";
            // 
            // btnBuscarSocios
            // 
            this.btnBuscarSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarSocios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBuscarSocios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarSocios.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnBuscarSocios.Image = global::Vista.Properties.Resources.lupa1;
            this.btnBuscarSocios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarSocios.Location = new System.Drawing.Point(40, 273);
            this.btnBuscarSocios.Name = "btnBuscarSocios";
            this.btnBuscarSocios.Size = new System.Drawing.Size(115, 44);
            this.btnBuscarSocios.TabIndex = 29;
            this.btnBuscarSocios.Text = "Buscar";
            this.btnBuscarSocios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarSocios.UseVisualStyleBackColor = false;
            this.btnBuscarSocios.Click += new System.EventHandler(this.btnBuscarSocios_Click);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.Silver;
            this.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltros.Image = global::Vista.Properties.Resources.limpiar;
            this.btnLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(172, 273);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(119, 44);
            this.btnLimpiarFiltros.TabIndex = 30;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(0, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(330, 22);
            this.label7.TabIndex = 26;
            this.label7.Text = "________________________________";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(117, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Socio :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(69, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Periodo de Pago :";
            // 
            // lblNroSocio
            // 
            this.lblNroSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNroSocio.AutoSize = true;
            this.lblNroSocio.BackColor = System.Drawing.Color.Transparent;
            this.lblNroSocio.Font = new System.Drawing.Font("Lucida Fax", 11F);
            this.lblNroSocio.Location = new System.Drawing.Point(10, 176);
            this.lblNroSocio.Name = "lblNroSocio";
            this.lblNroSocio.Size = new System.Drawing.Size(94, 17);
            this.lblNroSocio.TabIndex = 19;
            this.lblNroSocio.Text = "Nro. Socio :";
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.CustomFormat = "MM/yyyy";
            this.dtFechaDesde.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.dtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaDesde.Location = new System.Drawing.Point(98, 79);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(170, 30);
            this.dtFechaDesde.TabIndex = 22;
            this.dtFechaDesde.Value = new System.DateTime(2020, 4, 10, 0, 0, 0, 0);
            // 
            // tbDni
            // 
            this.tbDni.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.tbDni.Location = new System.Drawing.Point(108, 207);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(170, 30);
            this.tbDni.TabIndex = 23;
            this.tbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericFilter_KeyPress);
            // 
            // tbNroSocio
            // 
            this.tbNroSocio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbNroSocio.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.tbNroSocio.Location = new System.Drawing.Point(108, 171);
            this.tbNroSocio.Name = "tbNroSocio";
            this.tbNroSocio.Size = new System.Drawing.Size(93, 30);
            this.tbNroSocio.TabIndex = 15;
            this.tbNroSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericFilter_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Desde:";
            // 
            // lblDni
            // 
            this.lblDni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Lucida Fax", 11F);
            this.lblDni.Location = new System.Drawing.Point(56, 214);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(46, 17);
            this.lblDni.TabIndex = 20;
            this.lblDni.Text = "DNI :";
            // 
            // btnBuscarPagos
            // 
            this.btnBuscarPagos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBuscarPagos.BackColor = System.Drawing.Color.Gray;
            this.btnBuscarPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarPagos.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnBuscarPagos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscarPagos.Location = new System.Drawing.Point(99, 641);
            this.btnBuscarPagos.Name = "btnBuscarPagos";
            this.btnBuscarPagos.Size = new System.Drawing.Size(194, 71);
            this.btnBuscarPagos.TabIndex = 20;
            this.btnBuscarPagos.Text = "Buscar Pagos";
            this.btnBuscarPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPagos.UseVisualStyleBackColor = false;
            // 
            // btnAgregarPagos
            // 
            this.btnAgregarPagos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregarPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarPagos.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnAgregarPagos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregarPagos.Location = new System.Drawing.Point(329, 642);
            this.btnAgregarPagos.Name = "btnAgregarPagos";
            this.btnAgregarPagos.Size = new System.Drawing.Size(194, 71);
            this.btnAgregarPagos.TabIndex = 20;
            this.btnAgregarPagos.Text = "Agregar Pagos";
            this.btnAgregarPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarPagos.UseVisualStyleBackColor = false;
            // 
            // btnSociosDeudores
            // 
            this.btnSociosDeudores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSociosDeudores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSociosDeudores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSociosDeudores.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnSociosDeudores.Image = global::Vista.Properties.Resources.lupa1;
            this.btnSociosDeudores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSociosDeudores.Location = new System.Drawing.Point(41, 400);
            this.btnSociosDeudores.Name = "btnSociosDeudores";
            this.btnSociosDeudores.Size = new System.Drawing.Size(212, 44);
            this.btnSociosDeudores.TabIndex = 29;
            this.btnSociosDeudores.Text = "Socios Deudores";
            this.btnSociosDeudores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSociosDeudores.UseVisualStyleBackColor = false;
            this.btnSociosDeudores.Click += new System.EventHandler(this.btnSociosDeudores_Click);
            // 
            // btnSociosAldia
            // 
            this.btnSociosAldia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSociosAldia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSociosAldia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSociosAldia.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.btnSociosAldia.Image = global::Vista.Properties.Resources.lupa1;
            this.btnSociosAldia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSociosAldia.Location = new System.Drawing.Point(41, 464);
            this.btnSociosAldia.Name = "btnSociosAldia";
            this.btnSociosAldia.Size = new System.Drawing.Size(212, 44);
            this.btnSociosAldia.TabIndex = 29;
            this.btnSociosAldia.Text = "Socios Al Dia";
            this.btnSociosAldia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSociosAldia.UseVisualStyleBackColor = false;
            this.btnSociosAldia.Click += new System.EventHandler(this.btnSociosAldia_Click);
            // 
            // NroSocio
            // 
            this.NroSocio.DataPropertyName = "NroSocio";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // CantidadCuotasAdeudadas
            // 
            this.CantidadCuotasAdeudadas.DataPropertyName = "CuotasAdeudadas";
            this.CantidadCuotasAdeudadas.HeaderText = "Cantidad Cuotas Adeudadas";
            this.CantidadCuotasAdeudadas.Name = "CantidadCuotasAdeudadas";
            this.CantidadCuotasAdeudadas.ReadOnly = true;
            // 
            // UltimaCuota
            // 
            this.UltimaCuota.DataPropertyName = "UltimaCuotaPaga";
            this.UltimaCuota.HeaderText = "Ultima Cuota Paga";
            this.UltimaCuota.Name = "UltimaCuota";
            this.UltimaCuota.ReadOnly = true;
            // 
            // FrmGestionPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.fondo3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1149, 749);
            this.Controls.Add(this.btnAgregarPagos);
            this.Controls.Add(this.btnBuscarPagos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGestionPagoTitulo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestionPagos";
            this.Text = "Bomberos Voluntarios - Arroyo Barú";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGestionPagos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoSocios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionPagoTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtFechaDesde;
        private System.Windows.Forms.TextBox tbNroSocio;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNroSocio;
        private System.Windows.Forms.Button btnBuscarPagos;
        private System.Windows.Forms.Button btnAgregarPagos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.DataGridView dgvResultadoSocios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCantidadSocios;
        private System.Windows.Forms.Label lblCantidadText;
        private System.Windows.Forms.Button btnBuscarSocios;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Button btnSociosAldia;
        private System.Windows.Forms.Button btnSociosDeudores;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCuotasAdeudadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimaCuota;
    }
}