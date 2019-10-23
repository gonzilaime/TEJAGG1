﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CL;

namespace CU
{
    public partial class FrmNewModArt : Form
    {
        public Articulos articulo;
        public Provincia _provincia;
        public Proveedor _proveedor;
        public string AccionArticulo;

        #region SOMBRA FORMULARIO
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        #endregion
        public FrmNewModArt(Articulos articulos)
        {
            InitializeComponent();
            articulo = new Articulos();
            _provincia = new Provincia();
            _proveedor = new Proveedor();
            Validacion.combo2campos(cboProveedor, "RazonSocial", "IdProveedor", "Proveedores");

            if (articulos != null)
            {
                lblPrecio.Text = "Precio nuevo";
                btnGuardar.Visible = false;
                btnGuardar.Enabled = false;
                txtIdArticulo.Enabled = false;
                txtPrecio.Enabled = false;
                txtIdArticulo.Text = Convert.ToInt32(articulos.IdArticulo.ToString()).ToString();
                txtNombreProd.Text = articulos.NombreArticulo;
                txtBonificacion.Text = Convert.ToInt32(articulos.Bonificacion.ToString()).ToString();
                txtPrecio.Text = Convert.ToDecimal(articulos.Precio.ToString()).ToString();
                cboProveedor.Text = articulos.proveedor.RazonSocial;

                AccionArticulo = "MODIFICAR";

            }
            else
            {
                btnModificar.Enabled = false;
                btnModificar.Visible = false;
                txtIdArticulo.Visible = false;
                txtPrecio.Visible = false;
                lblIdArt.Visible = false;
                AccionArticulo = "ALTA";
            }
                 
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (AccionArticulo == "ALTA")
            {
                articulo.NombreArticulo = txtNombreProd.Text.ToString();
                articulo.Bonificacion = Convert.ToInt32(txtBonificacion.Text.ToString());
                articulo.PrecioEntero = Convert.ToInt32(txtEntero.Text.ToString());
                articulo.PrecioDecimal = Convert.ToInt32(txtDecimal.Text.ToString());
                articulo.proveedor.IdProveedor = Convert.ToInt32(((DataRowView)cboProveedor.SelectedItem)["IdProveedor"]);

                articulo.AccionArticulo(articulo, "ALTA");
                this.Hide();
                MessageBox.Show("El articulo " + articulo.NombreArticulo + " ha sido ingresado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (AccionArticulo == "MODIFICAR")
            {
                articulo.IdArticulo = Convert.ToInt32(txtIdArticulo.Text.ToString());
                articulo.NombreArticulo = txtNombreProd.Text.ToString();
                articulo.Bonificacion = Convert.ToInt32(txtBonificacion.Text.ToString());
                articulo.PrecioEntero = Convert.ToInt32(txtEntero.Text.ToString());
                articulo.PrecioDecimal = Convert.ToInt32(txtDecimal.Text.ToString());
                articulo.proveedor.IdProveedor = Convert.ToInt32(((DataRowView)cboProveedor.SelectedItem)["IdProveedor"]);

                articulo.AccionArticulo(articulo, "MODIFICAR");
                this.Hide();
                MessageBox.Show("El articulo " + articulo.NombreArticulo + " ha sido modificado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cancelar la operación?" +
          " Se perderán los datos ingresados.",
             "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }

        }

        private void FrmNewModArt_Load(object sender, EventArgs e)
        {
            articulo = new Articulos();
            _provincia = new Provincia();
            _proveedor = new Proveedor();
        }

        private void TxtDecimal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtEntero_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Movilidad
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
