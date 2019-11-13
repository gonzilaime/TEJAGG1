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
    public partial class FrmNewModCompras : Form
    {

        public Proveedor _proveedor;
        public OrdenDeCompra _ordenDecompra;
        public Detalle detalle_;
        public decimal total;

        #region sombra y movilidad.
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
#endregion
        public FrmNewModCompras(Detalle detalle)
        {
            InitializeComponent();
            _proveedor = new Proveedor();
            _ordenDecompra = new OrdenDeCompra();
            detalle_ = new Detalle();
            Validacion.combo2campos(cboProveedor, "RazonSocial", "IdProveedor", "Proveedores");
            Validacion.combo2campos(cboEstado, "DescripcionOrdenCompra", "IdEstadoOrdenCompra", "EstadoOrdenCompra");

            if (detalle != null)
            {
                BtnGenerar.Enabled = false;
                BtnGenerar.Visible = false;
                detalle_.ordenCompra.IdOrdenDeCompra = detalle.ordenCompra.IdOrdenDeCompra;
                detalle_.proveedor.IdProveedor = detalle.proveedor.IdProveedor;
                cboProveedor.Text = detalle.proveedor.RazonSocial.ToString();
                cboProveedor.Enabled = false;
                listarDetalles();

            }
            else
            {
                btnModificar.Enabled = false;
                btnModificar.Visible = false;
               
            }
        }

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wparam, int lparam);


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*************************************************************
       * Método para llenar ListBox con Detalle de orden de compra***
      ****************************************************************/
        public void listarDetalles()
        {
            listaDetalle.Rows.Clear();
            var detalleObtenido = detalle_.obtenerDetalleByOrdenDeCompra(detalle_.ordenCompra.IdOrdenDeCompra);

            foreach (var detalles in detalleObtenido)
            {
                listaDetalle.Rows.Add(detalles.IdDetalle,detalles.proveedor.IdProveedor, detalles.articulos.NombreArticulo,
                    detalles.Cantidad, detalles.Bonificacion, detalles.PrecioUnitario, detalles.Subtotal);

            }//foreach

        }//listarDetalles


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboProveedor.Enabled == false)
            {
                SubFrmCompras SubCompras = new SubFrmCompras(detalle_.proveedor.IdProveedor, detalle_.ordenCompra.IdOrdenDeCompra);
                SubCompras.ShowDialog();
            }
            else
            { 
                int IdProveedor = Convert.ToInt32(((DataRowView)cboProveedor.SelectedItem)["IdProveedor"]);
                SubFrmCompras SubCompras = new SubFrmCompras(IdProveedor,0);
                SubCompras.ShowDialog();
            }

            listarDetalles();

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


        private void FrmNewModCompras_Load(object sender, EventArgs e)
        {
            listarDetalles();
            
        }

        private void FrmNewModCompras_Activated(object sender, EventArgs e)
        {
            listarDetalles();
        }

        
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            _ordenDecompra.IdOrdenDeCompra = detalle_.ordenCompra.IdOrdenDeCompra;
            _ordenDecompra._estado.IdEstadoOrdenCompra = Convert.ToInt32(((DataRowView)cboEstado.SelectedItem)["IdEstadoOrdenCompra"]);
            _ordenDecompra.Accion(_ordenDecompra, "MODIFICAR");
            MessageBox.Show("Se modificó la orden de compra número " + _ordenDecompra.IdOrdenDeCompra +" exitosamente.");
            listarDetalles();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in listaDetalle.Rows)
            {
                total += Convert.ToDecimal(row.Cells["SubTotal"].Value);
            }
            textBox1.Text = Convert.ToString(total);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea borrar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
            detalle_.IdDetalle = Convert.ToInt32(listaDetalle.CurrentRow.Cells[0].Value.ToString());
                detalle_.Alta(detalle_, "BAJA");
            }else
            {
                
            }
            listarDetalles();
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            _ordenDecompra.proveedor.IdProveedor = Convert.ToInt32(((DataRowView)cboProveedor.SelectedItem)["IdProveedor"]);
            _ordenDecompra._estado.IdEstadoOrdenCompra = Convert.ToInt32(((DataRowView)cboEstado.SelectedItem)["IdEstadoOrdenCompra"]);
            _ordenDecompra.Accion(_ordenDecompra, "ALTA");
            MessageBox.Show("Se generó la orden de compra exitosamente, agregue los artículos en la siguiente lista:", "MENSAJE DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listarDetalles();
        }
    }
}
