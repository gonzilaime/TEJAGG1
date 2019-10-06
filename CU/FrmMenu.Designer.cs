namespace CU
{
    partial class FrmMenu
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
            this.lblGestion = new System.Windows.Forms.Label();
            this.lblTejag = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timerHoraYFecha = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblGestion
            // 
            this.lblGestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGestion.AutoSize = true;
            this.lblGestion.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestion.Location = new System.Drawing.Point(557, 117);
            this.lblGestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(111, 31);
            this.lblGestion.TabIndex = 5;
            this.lblGestion.Text = "Gestión";
            // 
            // lblTejag
            // 
            this.lblTejag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTejag.AutoSize = true;
            this.lblTejag.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTejag.Location = new System.Drawing.Point(345, 92);
            this.lblTejag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTejag.Name = "lblTejag";
            this.lblTejag.Size = new System.Drawing.Size(236, 62);
            this.lblTejag.TabIndex = 4;
            this.lblTejag.Text = "TEJAG ";
            this.lblTejag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(436, 629);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(102, 41);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "label1";
            this.lblFecha.Click += new System.EventHandler(this.LblFecha_Click);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(520, 524);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(239, 97);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "label1";
            this.lblHora.Click += new System.EventHandler(this.LblHora_Click);
            // 
            // timerHoraYFecha
            // 
            this.timerHoraYFecha.Enabled = true;
            this.timerHoraYFecha.Tick += new System.EventHandler(this.TimerHoraYFecha_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1024, 686);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblGestion);
            this.Controls.Add(this.lblTejag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestion;
        private System.Windows.Forms.Label lblTejag;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timerHoraYFecha;
    }
}