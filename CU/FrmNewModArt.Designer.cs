namespace CU
{
    partial class FrmNewModArt
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.lblEstadoArt = new System.Windows.Forms.Label();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtIdArticulo = new System.Windows.Forms.TextBox();
            this.lblIdArt = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblProductoObligatorio = new System.Windows.Forms.Label();
            this.lblPrecioObligatorio = new System.Windows.Forms.Label();
            this.txtEntero = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(160, 226);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(95, 29);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(273, 226);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(160, 226);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 29);
            this.btnGuardar.TabIndex = 78;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // cboProveedor
            // 
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(117, 39);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(250, 24);
            this.cboProveedor.TabIndex = 1;
            // 
            // lblEstadoArt
            // 
            this.lblEstadoArt.AutoSize = true;
            this.lblEstadoArt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoArt.Location = new System.Drawing.Point(17, 43);
            this.lblEstadoArt.Name = "lblEstadoArt";
            this.lblEstadoArt.Size = new System.Drawing.Size(87, 19);
            this.lblEstadoArt.TabIndex = 80;
            this.lblEstadoArt.Text = "Proveedor ";
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNombreProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProd.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProd.Location = new System.Drawing.Point(107, 83);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(260, 23);
            this.txtNombreProd.TabIndex = 2;
            this.txtNombreProd.TextChanged += new System.EventHandler(this.txtNombreProd_TextChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(17, 87);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(84, 19);
            this.lblProducto.TabIndex = 88;
            this.lblProducto.Text = "Producto *";
            // 
            // txtIdArticulo
            // 
            this.txtIdArticulo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtIdArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdArticulo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdArticulo.Location = new System.Drawing.Point(125, 177);
            this.txtIdArticulo.Name = "txtIdArticulo";
            this.txtIdArticulo.Size = new System.Drawing.Size(242, 23);
            this.txtIdArticulo.TabIndex = 90;
            // 
            // lblIdArt
            // 
            this.lblIdArt.AutoSize = true;
            this.lblIdArt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdArt.Location = new System.Drawing.Point(17, 177);
            this.lblIdArt.Name = "lblIdArt";
            this.lblIdArt.Size = new System.Drawing.Size(84, 19);
            this.lblIdArt.TabIndex = 91;
            this.lblIdArt.Text = "ID Artículo";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(226, 128);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(141, 23);
            this.txtPrecio.TabIndex = 93;
            this.txtPrecio.TextChanged += new System.EventHandler(this.TxtPrecio_TextChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(17, 130);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(64, 19);
            this.lblPrecio.TabIndex = 94;
            this.lblPrecio.Text = "Precio *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(156, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 16);
            this.label5.TabIndex = 101;
            this.label5.Text = ",";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(145)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 23);
            this.panel1.TabIndex = 103;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(145)))));
            this.btnMinimizar.BackgroundImage = global::CU.Properties.Resources.minimizar16;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(338, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(23, 20);
            this.btnMinimizar.TabIndex = 15;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(145)))));
            this.btnCerrar.BackgroundImage = global::CU.Properties.Resources.cancel_16;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(361, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 20);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // lblProductoObligatorio
            // 
            this.lblProductoObligatorio.AutoSize = true;
            this.lblProductoObligatorio.BackColor = System.Drawing.Color.Transparent;
            this.lblProductoObligatorio.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoObligatorio.ForeColor = System.Drawing.Color.Red;
            this.lblProductoObligatorio.Location = new System.Drawing.Point(172, 109);
            this.lblProductoObligatorio.Name = "lblProductoObligatorio";
            this.lblProductoObligatorio.Size = new System.Drawing.Size(148, 16);
            this.lblProductoObligatorio.TabIndex = 104;
            this.lblProductoObligatorio.Text = "Este campo es obligatorio.";
            this.lblProductoObligatorio.Visible = false;
            // 
            // lblPrecioObligatorio
            // 
            this.lblPrecioObligatorio.AutoSize = true;
            this.lblPrecioObligatorio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioObligatorio.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioObligatorio.ForeColor = System.Drawing.Color.Red;
            this.lblPrecioObligatorio.Location = new System.Drawing.Point(172, 154);
            this.lblPrecioObligatorio.Name = "lblPrecioObligatorio";
            this.lblPrecioObligatorio.Size = new System.Drawing.Size(148, 16);
            this.lblPrecioObligatorio.TabIndex = 106;
            this.lblPrecioObligatorio.Text = "Este campo es obligatorio.";
            this.lblPrecioObligatorio.Visible = false;
            // 
            // txtEntero
            // 
            this.txtEntero.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEntero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntero.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntero.Location = new System.Drawing.Point(107, 128);
            this.txtEntero.Name = "txtEntero";
            this.txtEntero.Size = new System.Drawing.Size(48, 23);
            this.txtEntero.TabIndex = 107;
            this.txtEntero.TextChanged += new System.EventHandler(this.txtEntero_TextChanged);
            // 
            // txtDecimal
            // 
            this.txtDecimal.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDecimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDecimal.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimal.Location = new System.Drawing.Point(166, 128);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(48, 23);
            this.txtDecimal.TabIndex = 108;
            // 
            // FrmNewModArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(383, 277);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtEntero);
            this.Controls.Add(this.lblPrecioObligatorio);
            this.Controls.Add(this.lblProductoObligatorio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtIdArticulo);
            this.Controls.Add(this.lblIdArt);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.cboProveedor);
            this.Controls.Add(this.lblEstadoArt);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewModArt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewModArt";
            this.Load += new System.EventHandler(this.FrmNewModArt_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label lblEstadoArt;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtIdArticulo;
        private System.Windows.Forms.Label lblIdArt;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblProductoObligatorio;
        private System.Windows.Forms.Label lblPrecioObligatorio;
        private System.Windows.Forms.TextBox txtEntero;
        private System.Windows.Forms.TextBox txtDecimal;
    }
}