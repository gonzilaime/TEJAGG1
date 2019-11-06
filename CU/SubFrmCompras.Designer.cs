namespace CU
{
    partial class SubFrmCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMinimizar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.LblArticulo = new System.Windows.Forms.Label();
            this.lblBon = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtBonificacion = new System.Windows.Forms.TextBox();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.listaArticulos = new System.Windows.Forms.DataGridView();
            this.IdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtArticulos = new System.Windows.Forms.TextBox();
            this.txtCodProv = new System.Windows.Forms.TextBox();
            this.lblCodProv = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaArticulos)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(145)))));
            this.panel1.Controls.Add(this.buttonMinimizar);
            this.panel1.Controls.Add(this.buttonCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 31);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(145)))));
            this.buttonMinimizar.BackgroundImage = global::CU.Properties.Resources.minimizar16;
            this.buttonMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMinimizar.FlatAppearance.BorderSize = 0;
            this.buttonMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizar.Location = new System.Drawing.Point(951, 0);
            this.buttonMinimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(35, 32);
            this.buttonMinimizar.TabIndex = 87;
            this.buttonMinimizar.UseVisualStyleBackColor = false;
            this.buttonMinimizar.Click += new System.EventHandler(this.buttonMinimizar_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(145)))));
            this.buttonCerrar.BackgroundImage = global::CU.Properties.Resources.cancel_16;
            this.buttonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Location = new System.Drawing.Point(987, 0);
            this.buttonCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(35, 32);
            this.buttonCerrar.TabIndex = 86;
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(613, 254);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(87, 23);
            this.lblCantidad.TabIndex = 89;
            this.lblCantidad.Text = "Cantidad";
            // 
            // LblArticulo
            // 
            this.LblArticulo.AutoSize = true;
            this.LblArticulo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArticulo.Location = new System.Drawing.Point(613, 174);
            this.LblArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblArticulo.Name = "LblArticulo";
            this.LblArticulo.Size = new System.Drawing.Size(79, 23);
            this.LblArticulo.TabIndex = 90;
            this.LblArticulo.Text = "Artículo";
            // 
            // lblBon
            // 
            this.lblBon.AutoSize = true;
            this.lblBon.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBon.Location = new System.Drawing.Point(613, 334);
            this.lblBon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBon.Name = "lblBon";
            this.lblBon.Size = new System.Drawing.Size(118, 23);
            this.lblBon.TabIndex = 91;
            this.lblBon.Text = "Bonificación";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Location = new System.Drawing.Point(715, 252);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(290, 22);
            this.txtCantidad.TabIndex = 92;
            // 
            // txtBonificacion
            // 
            this.txtBonificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtBonificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBonificacion.Location = new System.Drawing.Point(747, 332);
            this.txtBonificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBonificacion.Name = "txtBonificacion";
            this.txtBonificacion.Size = new System.Drawing.Size(219, 22);
            this.txtBonificacion.TabIndex = 93;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.Location = new System.Drawing.Point(975, 332);
            this.lblPorcentaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(28, 23);
            this.lblPorcentaje.TabIndex = 94;
            this.lblPorcentaje.Text = "%";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(687, 460);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 36);
            this.btnAgregar.TabIndex = 95;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(911, 460);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 36);
            this.btnCancelar.TabIndex = 96;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelBuscar
            // 
            this.panelBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBuscar.BackColor = System.Drawing.Color.LightGray;
            this.panelBuscar.Controls.Add(this.pictureBox1);
            this.panelBuscar.Controls.Add(this.txtBuscar);
            this.panelBuscar.Location = new System.Drawing.Point(3, 2);
            this.panelBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(587, 46);
            this.panelBuscar.TabIndex = 98;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CU.Properties.Resources.magnifying_glass;
            this.pictureBox1.Location = new System.Drawing.Point(20, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(49, 10);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(394, 26);
            this.txtBuscar.TabIndex = 5;
            // 
            // listaArticulos
            // 
            this.listaArticulos.AllowUserToAddRows = false;
            this.listaArticulos.AllowUserToDeleteRows = false;
            this.listaArticulos.AllowUserToResizeColumns = false;
            this.listaArticulos.AllowUserToResizeRows = false;
            this.listaArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaArticulos.BackgroundColor = System.Drawing.Color.LightGray;
            this.listaArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.listaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdArticulo,
            this.NombreArticulo,
            this.Bonificacion,
            this.Precio,
            this.IdProveedor,
            this.RazonSocial});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaArticulos.DefaultCellStyle = dataGridViewCellStyle5;
            this.listaArticulos.EnableHeadersVisualStyles = false;
            this.listaArticulos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listaArticulos.Location = new System.Drawing.Point(20, 85);
            this.listaArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaArticulos.Name = "listaArticulos";
            this.listaArticulos.ReadOnly = true;
            this.listaArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.listaArticulos.RowHeadersWidth = 51;
            this.listaArticulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaArticulos.Size = new System.Drawing.Size(587, 409);
            this.listaArticulos.TabIndex = 97;
            this.listaArticulos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaArticulos_CellContentDoubleClick);
            // 
            // IdArticulo
            // 
            this.IdArticulo.HeaderText = "ID Artículo";
            this.IdArticulo.MinimumWidth = 6;
            this.IdArticulo.Name = "IdArticulo";
            this.IdArticulo.ReadOnly = true;
            this.IdArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NombreArticulo
            // 
            this.NombreArticulo.HeaderText = "Artículo";
            this.NombreArticulo.MinimumWidth = 6;
            this.NombreArticulo.Name = "NombreArticulo";
            this.NombreArticulo.ReadOnly = true;
            // 
            // Bonificacion
            // 
            this.Bonificacion.HeaderText = "Bonificación";
            this.Bonificacion.MinimumWidth = 6;
            this.Bonificacion.Name = "Bonificacion";
            this.Bonificacion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio Unitario";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // IdProveedor
            // 
            this.IdProveedor.HeaderText = "Codigo de Proveedor";
            this.IdProveedor.MinimumWidth = 6;
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.ReadOnly = true;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Proveedor";
            this.RazonSocial.MinimumWidth = 6;
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Controls.Add(this.panelBuscar);
            this.panel4.Location = new System.Drawing.Point(17, 38);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(592, 458);
            this.panel4.TabIndex = 99;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(771, 412);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(234, 22);
            this.txtPrecio.TabIndex = 101;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(613, 414);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(139, 23);
            this.lblPrecio.TabIndex = 100;
            this.lblPrecio.Text = "Precio unitario";
            // 
            // txtArticulos
            // 
            this.txtArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArticulos.Enabled = false;
            this.txtArticulos.Location = new System.Drawing.Point(707, 172);
            this.txtArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArticulos.Name = "txtArticulos";
            this.txtArticulos.Size = new System.Drawing.Size(298, 22);
            this.txtArticulos.TabIndex = 102;
            // 
            // txtCodProv
            // 
            this.txtCodProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.txtCodProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodProv.Enabled = false;
            this.txtCodProv.Location = new System.Drawing.Point(771, 92);
            this.txtCodProv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodProv.Name = "txtCodProv";
            this.txtCodProv.Size = new System.Drawing.Size(234, 22);
            this.txtCodProv.TabIndex = 104;
            // 
            // lblCodProv
            // 
            this.lblCodProv.AutoSize = true;
            this.lblCodProv.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProv.Location = new System.Drawing.Point(613, 94);
            this.lblCodProv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodProv.Name = "lblCodProv";
            this.lblCodProv.Size = new System.Drawing.Size(137, 23);
            this.lblCodProv.TabIndex = 103;
            this.lblCodProv.Text = "Cod Proveedor";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(799, 460);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(97, 36);
            this.btnFinalizar.TabIndex = 105;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            // 
            // SubFrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1021, 512);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txtCodProv);
            this.Controls.Add(this.lblCodProv);
            this.Controls.Add(this.txtArticulos);
            this.Controls.Add(this.listaArticulos);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.LblArticulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBon);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtBonificacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SubFrmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SubFrmCompras";
            this.Load += new System.EventHandler(this.SubFrmCompras_Load);
            this.panel1.ResumeLayout(false);
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaArticulos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label LblArticulo;
        private System.Windows.Forms.Label lblBon;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtBonificacion;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button buttonMinimizar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView listaArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtArticulos;
        private System.Windows.Forms.TextBox txtCodProv;
        private System.Windows.Forms.Label lblCodProv;
        private System.Windows.Forms.Button btnFinalizar;
    }
}