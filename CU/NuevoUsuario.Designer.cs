namespace CU
{
    partial class NuevoUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.lblNick = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.cboProv = new System.Windows.Forms.ComboBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblNickObligatorio = new System.Windows.Forms.Label();
            this.lblContraseñaObligatorio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(145)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 25);
            this.panel1.TabIndex = 2;
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
            this.btnMinimizar.Location = new System.Drawing.Point(317, -1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(26, 26);
            this.btnMinimizar.TabIndex = 15;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
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
            this.btnCerrar.Location = new System.Drawing.Point(344, -1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(26, 26);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtNick
            // 
            this.txtNick.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNick.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNick.Location = new System.Drawing.Point(173, 57);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(178, 23);
            this.txtNick.TabIndex = 9;
            this.txtNick.TextChanged += new System.EventHandler(this.txtNick_TextChanged);
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNick.Location = new System.Drawing.Point(12, 60);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(155, 19);
            this.lblNick.TabIndex = 37;
            this.lblNick.Text = "Nombre de usuario *";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(12, 117);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(99, 19);
            this.lblContraseña.TabIndex = 38;
            this.lblContraseña.Text = "Contraseña *";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.Gainsboro;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(117, 114);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(234, 23);
            this.txtContraseña.TabIndex = 39;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(12, 174);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(106, 19);
            this.lblPerfil.TabIndex = 40;
            this.lblPerfil.Text = "Tipo de perfil ";
            // 
            // cboProv
            // 
            this.cboProv.BackColor = System.Drawing.Color.White;
            this.cboProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProv.FormattingEnabled = true;
            this.cboProv.Location = new System.Drawing.Point(124, 171);
            this.cboProv.Name = "cboProv";
            this.cboProv.Size = new System.Drawing.Size(227, 24);
            this.cboProv.TabIndex = 41;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(257, 227);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(94, 29);
            this.btnFinalizar.TabIndex = 42;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblNickObligatorio
            // 
            this.lblNickObligatorio.AutoSize = true;
            this.lblNickObligatorio.BackColor = System.Drawing.Color.Transparent;
            this.lblNickObligatorio.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickObligatorio.ForeColor = System.Drawing.Color.Red;
            this.lblNickObligatorio.Location = new System.Drawing.Point(190, 83);
            this.lblNickObligatorio.Name = "lblNickObligatorio";
            this.lblNickObligatorio.Size = new System.Drawing.Size(148, 16);
            this.lblNickObligatorio.TabIndex = 56;
            this.lblNickObligatorio.Text = "Este campo es obligatorio.";
            this.lblNickObligatorio.Visible = false;
            // 
            // lblContraseñaObligatorio
            // 
            this.lblContraseñaObligatorio.AutoSize = true;
            this.lblContraseñaObligatorio.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseñaObligatorio.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaObligatorio.ForeColor = System.Drawing.Color.Red;
            this.lblContraseñaObligatorio.Location = new System.Drawing.Point(158, 140);
            this.lblContraseñaObligatorio.Name = "lblContraseñaObligatorio";
            this.lblContraseñaObligatorio.Size = new System.Drawing.Size(148, 16);
            this.lblContraseñaObligatorio.TabIndex = 57;
            this.lblContraseñaObligatorio.Text = "Este campo es obligatorio.";
            this.lblContraseñaObligatorio.Visible = false;
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(369, 268);
            this.Controls.Add(this.lblContraseñaObligatorio);
            this.Controls.Add(this.lblNickObligatorio);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.cboProv);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblNick);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoUsuario";
            this.Load += new System.EventHandler(this.NuevoUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cboProv;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblNickObligatorio;
        private System.Windows.Forms.Label lblContraseñaObligatorio;
    }
}