namespace CU
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
            this.components = new System.ComponentModel.Container();
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
            this.button3 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNewProveedor = new System.Windows.Forms.Button();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.listaProveedor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaProveedor
            // 
            this.listaProveedor.AllowUserToAddRows = false;
            this.listaProveedor.AllowUserToDeleteRows = false;
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
            this.listaProveedor.Location = new System.Drawing.Point(17, 141);
            this.listaProveedor.Name = "listaProveedor";
            this.listaProveedor.ReadOnly = true;
            this.listaProveedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listaProveedor.RowHeadersWidth = 51;
            this.listaProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaProveedor.Size = new System.Drawing.Size(736, 316);
            this.listaProveedor.TabIndex = 0;
            this.listaProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.listaProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaProveedor_CellDoubleClick);
            // 
            // IdProveedor
            // 
            this.IdProveedor.HeaderText = "Código Proveedor";
            this.IdProveedor.MinimumWidth = 6;
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.ReadOnly = true;
            // 
            // CuitCuil
            // 
            this.CuitCuil.HeaderText = "CUIT/CUIL";
            this.CuitCuil.MinimumWidth = 6;
            this.CuitCuil.Name = "CuitCuil";
            this.CuitCuil.ReadOnly = true;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razón Social";
            this.RazonSocial.MinimumWidth = 6;
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Localidad
            // 
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.MinimumWidth = 6;
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            // 
            // DescripcionProvincia
            // 
            this.DescripcionProvincia.HeaderText = "Provincia";
            this.DescripcionProvincia.MinimumWidth = 6;
            this.DescripcionProvincia.Name = "DescripcionProvincia";
            this.DescripcionProvincia.ReadOnly = true;
            this.DescripcionProvincia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DescripcionProvincia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tel1
            // 
            this.Tel1.HeaderText = "Teléfono1";
            this.Tel1.MinimumWidth = 6;
            this.Tel1.Name = "Tel1";
            this.Tel1.ReadOnly = true;
            // 
            // Tel2
            // 
            this.Tel2.HeaderText = "Teléfono2";
            this.Tel2.MinimumWidth = 6;
            this.Tel2.Name = "Tel2";
            this.Tel2.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // DescripcionEstado
            // 
            this.DescripcionEstado.HeaderText = "Estado";
            this.DescripcionEstado.MinimumWidth = 6;
            this.DescripcionEstado.Name = "DescripcionEstado";
            this.DescripcionEstado.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lblProveedores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 37);
            this.panel1.TabIndex = 1;
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.Location = new System.Drawing.Point(12, 5);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(117, 26);
            this.lblProveedores.TabIndex = 0;
            this.lblProveedores.Text = "Proveedores";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnNewProveedor);
            this.panel2.Controls.Add(this.shapeContainer3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 28);
            this.panel2.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(266, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1000, 24);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
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
            this.btnModificar.Text = "Modificar Proveedor";
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
            this.btnNewProveedor.Location = new System.Drawing.Point(2, 2);
            this.btnNewProveedor.Name = "btnNewProveedor";
            this.btnNewProveedor.Size = new System.Drawing.Size(130, 24);
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
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(24, 8);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(121, 17);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Buscar Proveedor";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(160, 6);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(271, 20);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Controls.Add(this.lblBuscar);
            this.panel3.Location = new System.Drawing.Point(17, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(736, 32);
            this.panel3.TabIndex = 6;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(15, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(740, 352);
            this.panel4.TabIndex = 7;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(768, 557);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listaProveedor);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProveedores";
            this.Text = "frmAgregarModificar";
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaProveedor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listaProveedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNewProveedor;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private System.Windows.Forms.Button btnModificar;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel4;
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
    }
}