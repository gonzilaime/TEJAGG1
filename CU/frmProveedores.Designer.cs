﻿namespace CU
{
    partial class frmProveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listaProveedor = new System.Windows.Forms.DataGridView();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuitCuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNewProveedor = new System.Windows.Forms.Button();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioBtnInactivos = new System.Windows.Forms.RadioButton();
            this.radioBtnActivos = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.listaProveedor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaProveedor
            // 
            this.listaProveedor.AllowUserToAddRows = false;
            this.listaProveedor.AllowUserToDeleteRows = false;
            this.listaProveedor.AllowUserToResizeColumns = false;
            this.listaProveedor.AllowUserToResizeRows = false;
            this.listaProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaProveedor.BackgroundColor = System.Drawing.Color.LightGray;
            this.listaProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaProveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProveedor,
            this.CuitCuil,
            this.RazonSocial,
            this.Direccion,
            this.Localidad,
            this.DescripcionProvincia,
            this.Tel1,
            this.Tel2,
            this.Email,
            this.DescripcionEstado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaProveedor.DefaultCellStyle = dataGridViewCellStyle2;
            this.listaProveedor.EnableHeadersVisualStyles = false;
            this.listaProveedor.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listaProveedor.Location = new System.Drawing.Point(3, 42);
            this.listaProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaProveedor.MultiSelect = false;
            this.listaProveedor.Name = "listaProveedor";
            this.listaProveedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listaProveedor.RowHeadersWidth = 30;
            this.listaProveedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listaProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaProveedor.ShowCellErrors = false;
            this.listaProveedor.ShowCellToolTips = false;
            this.listaProveedor.ShowEditingIcon = false;
            this.listaProveedor.ShowRowErrors = false;
            this.listaProveedor.Size = new System.Drawing.Size(1283, 519);
            this.listaProveedor.TabIndex = 0;
            this.listaProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.listaProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaProveedor_CellDoubleClick);
            // 
            // IdProveedor
            // 
            this.IdProveedor.HeaderText = "Código Proveedor";
            this.IdProveedor.MinimumWidth = 6;
            this.IdProveedor.Name = "IdProveedor";
            // 
            // CuitCuil
            // 
            this.CuitCuil.HeaderText = "CUIT/CUIL";
            this.CuitCuil.MinimumWidth = 6;
            this.CuitCuil.Name = "CuitCuil";
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razón Social";
            this.RazonSocial.MinimumWidth = 6;
            this.RazonSocial.Name = "RazonSocial";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            // 
            // Localidad
            // 
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.MinimumWidth = 6;
            this.Localidad.Name = "Localidad";
            // 
            // DescripcionProvincia
            // 
            this.DescripcionProvincia.HeaderText = "Provincia";
            this.DescripcionProvincia.MinimumWidth = 6;
            this.DescripcionProvincia.Name = "DescripcionProvincia";
            this.DescripcionProvincia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DescripcionProvincia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tel1
            // 
            this.Tel1.HeaderText = "Teléfono1";
            this.Tel1.MinimumWidth = 6;
            this.Tel1.Name = "Tel1";
            // 
            // Tel2
            // 
            this.Tel2.HeaderText = "Teléfono2";
            this.Tel2.MinimumWidth = 6;
            this.Tel2.Name = "Tel2";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // DescripcionEstado
            // 
            this.DescripcionEstado.HeaderText = "Estado";
            this.DescripcionEstado.MinimumWidth = 6;
            this.DescripcionEstado.Name = "DescripcionEstado";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lblProveedores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 46);
            this.panel1.TabIndex = 1;
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.Location = new System.Drawing.Point(16, 6);
            this.lblProveedores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(151, 33);
            this.lblProveedores.TabIndex = 0;
            this.lblProveedores.Text = "Proveedores";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnNewProveedor);
            this.panel2.Controls.Add(this.shapeContainer3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1326, 34);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(355, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(971, 30);
            this.panel5.TabIndex = 10;
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
            this.btnModificar.Location = new System.Drawing.Point(179, 2);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(173, 30);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnNewProveedor
            // 
            this.btnNewProveedor.BackColor = System.Drawing.Color.LightGray;
            this.btnNewProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewProveedor.FlatAppearance.BorderSize = 0;
            this.btnNewProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnNewProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnNewProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProveedor.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProveedor.ForeColor = System.Drawing.Color.Black;
            this.btnNewProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProveedor.Location = new System.Drawing.Point(3, 2);
            this.btnNewProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewProveedor.Name = "btnNewProveedor";
            this.btnNewProveedor.Size = new System.Drawing.Size(173, 30);
            this.btnNewProveedor.TabIndex = 5;
            this.btnNewProveedor.Text = "Agregar";
            this.btnNewProveedor.UseVisualStyleBackColor = false;
            this.btnNewProveedor.Click += new System.EventHandler(this.BtnNewProveedor_Click);
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape2});
            this.shapeContainer3.Size = new System.Drawing.Size(1326, 34);
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
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.radioBtnInactivos);
            this.panel3.Controls.Add(this.radioBtnActivos);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(23, 134);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1283, 39);
            this.panel3.TabIndex = 6;
            // 
            // radioBtnInactivos
            // 
            this.radioBtnInactivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnInactivos.AutoSize = true;
            this.radioBtnInactivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnInactivos.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnInactivos.Location = new System.Drawing.Point(1108, 5);
            this.radioBtnInactivos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBtnInactivos.Name = "radioBtnInactivos";
            this.radioBtnInactivos.Size = new System.Drawing.Size(110, 32);
            this.radioBtnInactivos.TabIndex = 19;
            this.radioBtnInactivos.Text = "Inactivos";
            this.radioBtnInactivos.UseVisualStyleBackColor = true;
            this.radioBtnInactivos.CheckedChanged += new System.EventHandler(this.RadioBtnInactivos_CheckedChanged);
            this.radioBtnInactivos.Click += new System.EventHandler(this.RadioBtnInactivos_Click);
            // 
            // radioBtnActivos
            // 
            this.radioBtnActivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnActivos.AutoSize = true;
            this.radioBtnActivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnActivos.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnActivos.Location = new System.Drawing.Point(854, 5);
            this.radioBtnActivos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBtnActivos.Name = "radioBtnActivos";
            this.radioBtnActivos.Size = new System.Drawing.Size(97, 32);
            this.radioBtnActivos.TabIndex = 18;
            this.radioBtnActivos.Text = "Activos";
            this.radioBtnActivos.UseVisualStyleBackColor = true;
            this.radioBtnActivos.CheckedChanged += new System.EventHandler(this.RadioBtnActivos_CheckedChanged);
            this.radioBtnActivos.Click += new System.EventHandler(this.RadioBtnActivos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CU.Properties.Resources.magnifying_glass;
            this.pictureBox1.Location = new System.Drawing.Point(20, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(773, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(4, 39);
            this.panel7.TabIndex = 17;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(49, 6);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(394, 26);
            this.txtBuscar.TabIndex = 7;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(1029, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(4, 39);
            this.panel6.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Controls.Add(this.listaProveedor);
            this.panel4.Location = new System.Drawing.Point(20, 132);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1289, 563);
            this.panel4.TabIndex = 7;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1326, 725);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProveedores";
            this.ShowIcon = false;
            this.Text = "frmAgregarModificar";
            this.Activated += new System.EventHandler(this.frmProveedores_Activated);
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaProveedor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNewProveedor;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private System.Windows.Forms.Button btnModificar;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuitCuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionEstado;
        public System.Windows.Forms.DataGridView listaProveedor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioBtnInactivos;
        private System.Windows.Forms.RadioButton radioBtnActivos;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
    }
}