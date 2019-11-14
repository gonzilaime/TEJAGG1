namespace CU
{
    partial class FrmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.RadioBtnOC = new System.Windows.Forms.RadioButton();
            this.radioBtnPendiente = new System.Windows.Forms.RadioButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.radioBtnAnuladas = new System.Windows.Forms.RadioButton();
            this.radioBtnEntregada = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listaOrdenes = new System.Windows.Forms.DataGridView();
            this.IdOrdenDeCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionEstadoOrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaOrdenes)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.shapeContainer3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 28);
            this.panel2.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(266, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(502, 24);
            this.panel5.TabIndex = 11;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.LightGray;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(134, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 24);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightGray;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 24);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape2});
            this.shapeContainer3.Size = new System.Drawing.Size(768, 28);
            this.shapeContainer3.TabIndex = 6;
            this.shapeContainer3.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderWidth = 2;
            this.lineShape4.Enabled = false;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 349;
            this.lineShape4.X2 = 349;
            this.lineShape4.Y1 = -1;
            this.lineShape4.Y2 = 30;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 174;
            this.lineShape2.X2 = 174;
            this.lineShape2.Y1 = -2;
            this.lineShape2.Y2 = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lblProveedores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 37);
            this.panel1.TabIndex = 11;
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblProveedores.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.Location = new System.Drawing.Point(12, 5);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(161, 26);
            this.lblProveedores.TabIndex = 0;
            this.lblProveedores.Text = "Orden de compra";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.RadioBtnOC);
            this.panel3.Controls.Add(this.radioBtnPendiente);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.radioBtnAnuladas);
            this.panel3.Controls.Add(this.radioBtnEntregada);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(19, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 32);
            this.panel3.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(248, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(3, 32);
            this.panel9.TabIndex = 22;
            // 
            // RadioBtnOC
            // 
            this.RadioBtnOC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioBtnOC.AutoSize = true;
            this.RadioBtnOC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioBtnOC.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtnOC.Location = new System.Drawing.Point(259, 2);
            this.RadioBtnOC.Name = "RadioBtnOC";
            this.RadioBtnOC.Size = new System.Drawing.Size(69, 25);
            this.RadioBtnOC.TabIndex = 21;
            this.RadioBtnOC.TabStop = true;
            this.RadioBtnOC.Text = "Todas";
            this.RadioBtnOC.UseVisualStyleBackColor = true;
            this.RadioBtnOC.CheckedChanged += new System.EventHandler(this.BtnOC_CheckedChanged);
            this.RadioBtnOC.Click += new System.EventHandler(this.RadioBtnOC_Click);
            // 
            // radioBtnPendiente
            // 
            this.radioBtnPendiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnPendiente.AutoSize = true;
            this.radioBtnPendiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnPendiente.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnPendiente.Location = new System.Drawing.Point(359, 2);
            this.radioBtnPendiente.Name = "radioBtnPendiente";
            this.radioBtnPendiente.Size = new System.Drawing.Size(104, 25);
            this.radioBtnPendiente.TabIndex = 20;
            this.radioBtnPendiente.TabStop = true;
            this.radioBtnPendiente.Text = "Pendientes";
            this.radioBtnPendiente.UseVisualStyleBackColor = true;
            this.radioBtnPendiente.CheckedChanged += new System.EventHandler(this.RadioBtnPendiente_CheckedChanged);
            this.radioBtnPendiente.Click += new System.EventHandler(this.RadioBtnPendiente_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(346, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(3, 32);
            this.panel8.TabIndex = 18;
            // 
            // radioBtnAnuladas
            // 
            this.radioBtnAnuladas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnAnuladas.AutoSize = true;
            this.radioBtnAnuladas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnAnuladas.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAnuladas.Location = new System.Drawing.Point(497, 2);
            this.radioBtnAnuladas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnAnuladas.Name = "radioBtnAnuladas";
            this.radioBtnAnuladas.Size = new System.Drawing.Size(92, 25);
            this.radioBtnAnuladas.TabIndex = 19;
            this.radioBtnAnuladas.TabStop = true;
            this.radioBtnAnuladas.Text = "Anuladas";
            this.radioBtnAnuladas.UseVisualStyleBackColor = true;
            this.radioBtnAnuladas.CheckedChanged += new System.EventHandler(this.RadioBtnAnuladas_CheckedChanged);
            this.radioBtnAnuladas.Click += new System.EventHandler(this.RadioBtnAnuladas_Click);
            // 
            // radioBtnEntregada
            // 
            this.radioBtnEntregada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnEntregada.AutoSize = true;
            this.radioBtnEntregada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnEntregada.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnEntregada.Location = new System.Drawing.Point(616, 2);
            this.radioBtnEntregada.Name = "radioBtnEntregada";
            this.radioBtnEntregada.Size = new System.Drawing.Size(105, 25);
            this.radioBtnEntregada.TabIndex = 18;
            this.radioBtnEntregada.TabStop = true;
            this.radioBtnEntregada.Text = "Entregadas";
            this.radioBtnEntregada.UseVisualStyleBackColor = true;
            this.radioBtnEntregada.CheckedChanged += new System.EventHandler(this.RadioBtnEntregada_CheckedChanged);
            this.radioBtnEntregada.Click += new System.EventHandler(this.RadioBtnEntregada_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(481, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(3, 32);
            this.panel7.TabIndex = 17;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(37, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(206, 22);
            this.txtBuscar.TabIndex = 7;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(606, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3, 32);
            this.panel6.TabIndex = 16;
            // 
            // listaOrdenes
            // 
            this.listaOrdenes.AllowUserToAddRows = false;
            this.listaOrdenes.AllowUserToDeleteRows = false;
            this.listaOrdenes.AllowUserToResizeColumns = false;
            this.listaOrdenes.AllowUserToResizeRows = false;
            this.listaOrdenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaOrdenes.BackgroundColor = System.Drawing.Color.LightGray;
            this.listaOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaOrdenes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaOrdenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOrdenDeCompra,
            this.Fecha,
            this.RazonSocial,
            this.IdProveedor,
            this.DescripcionEstadoOrdenCompra,
            this.Monto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaOrdenes.DefaultCellStyle = dataGridViewCellStyle2;
            this.listaOrdenes.EnableHeadersVisualStyles = false;
            this.listaOrdenes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listaOrdenes.Location = new System.Drawing.Point(2, 34);
            this.listaOrdenes.Name = "listaOrdenes";
            this.listaOrdenes.ReadOnly = true;
            this.listaOrdenes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaOrdenes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listaOrdenes.RowHeadersWidth = 51;
            this.listaOrdenes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listaOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaOrdenes.Size = new System.Drawing.Size(736, 390);
            this.listaOrdenes.TabIndex = 13;
            this.listaOrdenes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaOrdenes_CellContentDoubleClick);
            // 
            // IdOrdenDeCompra
            // 
            this.IdOrdenDeCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdOrdenDeCompra.Frozen = true;
            this.IdOrdenDeCompra.HeaderText = "Numero orden de compra";
            this.IdOrdenDeCompra.MinimumWidth = 6;
            this.IdOrdenDeCompra.Name = "IdOrdenDeCompra";
            this.IdOrdenDeCompra.ReadOnly = true;
            this.IdOrdenDeCompra.Width = 186;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Fecha.Frozen = true;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 186;
            // 
            // RazonSocial
            // 
            this.RazonSocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RazonSocial.Frozen = true;
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.MinimumWidth = 6;
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Width = 186;
            // 
            // IdProveedor
            // 
            this.IdProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdProveedor.Frozen = true;
            this.IdProveedor.HeaderText = "Cod proveedor";
            this.IdProveedor.MinimumWidth = 6;
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.ReadOnly = true;
            this.IdProveedor.Width = 125;
            // 
            // DescripcionEstadoOrdenCompra
            // 
            this.DescripcionEstadoOrdenCompra.HeaderText = "Estado";
            this.DescripcionEstadoOrdenCompra.MinimumWidth = 6;
            this.DescripcionEstadoOrdenCompra.Name = "DescripcionEstadoOrdenCompra";
            this.DescripcionEstadoOrdenCompra.ReadOnly = true;
            this.DescripcionEstadoOrdenCompra.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Controls.Add(this.listaOrdenes);
            this.panel4.Location = new System.Drawing.Point(16, 96);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(740, 426);
            this.panel4.TabIndex = 15;
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(768, 557);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCompras";
            this.Text = "FrmCompras";
            this.Activated += new System.EventHandler(this.FrmCompras_Activated);
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaOrdenes)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView listaOrdenes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioBtnPendiente;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton radioBtnAnuladas;
        private System.Windows.Forms.RadioButton radioBtnEntregada;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrdenDeCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionEstadoOrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton RadioBtnOC;
    }
}