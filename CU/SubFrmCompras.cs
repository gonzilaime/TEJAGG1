﻿using CL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CU
{
    public partial class SubFrmCompras : Form
    {

        #region movilidad y sombra

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
            //if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        #endregion Movilidad y sombra movilidad y sombra movilidad y sombra
        public Articulos articulos_;
        public Detalle detalle;

        public SubFrmCompras(int IdProveedor)
        {
            InitializeComponent();
            articulos_ = new Articulos();
            detalle = new Detalle();
            articulos_.IdProveedor = IdProveedor;

        }
        #region movilidad para panel

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wparam, int lparam);
        #endregion


        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /******************************************************
         * Métodos para llenar ListBox con datos de Articulos***
        *******************************************************/
        public void listarArticulos()
        {
            listaArticulos.Rows.Clear();
            var filtro = txtBuscar.Text;
            var articuloObtenido = articulos_.obtenerArticulosByProveedor(articulos_.IdProveedor);

            foreach (var articulo in articuloObtenido)
            {
                listaArticulos.Rows.Add(articulo.IdArticulo, articulo.NombreArticulo, articulo.Bonificacion,
                    articulo.Precio, articulo.proveedor.IdProveedor, articulo.proveedor.RazonSocial);

            }//foreach

        }//listarArticulos

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SubFrmCompras_Load(object sender, EventArgs e)
        {
            listarArticulos();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void ListaArticulos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txtCodProv.Text = listaArticulos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtArticulos.Text = listaArticulos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBonificacion.Text = listaArticulos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrecio.Text = listaArticulos.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in listaArticulos.Rows)
            {
                detalle.IdArticulo = Convert.ToInt32(txtCodProv.Text);
                detalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                detalle.Bonificacion = Convert.ToInt32(txtBonificacion.Text);

                detalle.Alta(detalle);
            }
        }
    }
}
