using CL;
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
        public int id;
        Validacion validar;

        public SubFrmCompras(int IdProveedor, int IdOrdenCompra)
        {
            InitializeComponent();
            articulos_ = new Articulos();
            detalle = new Detalle();
            articulos_.IdProveedor = IdProveedor;
            id = IdOrdenCompra;
            validar = new Validacion();

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
                listaArticulos.Rows.Add(articulo.IdArticulo, articulo.NombreArticulo,
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

        public bool CamposObligatorios()
        {
            if(txtCantidad.Text == "")
            {
                lblCantidadObligatorio.Visible = true;

                return false;
            }
            else if(txtBonificacion.Text == "")
            {
                lblBonificacionObligatoria.Visible = true;

                return false;
            }

            return true;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        

        private void ListaArticulos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txtCodProv.Text = listaArticulos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtArticulos.Text = listaArticulos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrecio.Text = listaArticulos.Rows[e.RowIndex].Cells[2].Value.ToString();
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in listaArticulos.Rows)
            {
                bool rta = false;
                if (txtArticulos.Text == "" && txtCodProv.Text == "" && txtCantidad.Text == "" &&
                    txtPrecio.Text == "" && txtBonificacion.Text == "")
                {
                    MessageBox.Show("Primero debe seleccionar un artículo", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (CamposObligatorios() == rta)

                {
                    return;
                }
                else if (id != 0)
                {
                    detalle.IdArticulo = Convert.ToInt32(txtCodProv.Text);
                    detalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                    detalle.Bonificacion = Convert.ToInt32(txtBonificacion.Text);
                    detalle.PrecioUnitario = Convert.ToDecimal(listaArticulos.CurrentRow.Cells[3].Value.ToString());
                    detalle.IdOrdenDeCompra = id;

                    detalle.Alta(detalle, "MODIFICAR");

                    txtArticulos.Clear();
                    txtBonificacion.Clear();
                    txtCantidad.Clear();
                    txtCodProv.Clear();
                    txtPrecio.Clear();

                    break;
                }
                else
                {
                    detalle.IdArticulo = Convert.ToInt32(txtCodProv.Text);
                    detalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                    detalle.Bonificacion = Convert.ToInt32(txtBonificacion.Text);
                    detalle.PrecioUnitario = Convert.ToDecimal(listaArticulos.CurrentRow.Cells[3].Value.ToString());

                    detalle.Alta(detalle,"ALTA");

                    txtArticulos.Clear();
                    txtBonificacion.Clear();
                    txtCantidad.Clear();
                    txtCodProv.Clear();
                    txtPrecio.Clear();

                    break;
                }

            }
        }

        private void ListaArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodProv.Text = listaArticulos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtArticulos.Text = listaArticulos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrecio.Text = listaArticulos.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBonificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e);
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e);
        }
    }
}
