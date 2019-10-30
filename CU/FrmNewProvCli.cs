using System;
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
    public partial class FrmNewProvCli : Form
    {
        public Proveedor _proveedor;
        public Provincia _provincia;
        public string Accion;

        //Sombra en el panel y efecto ShowDialog
        #region
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
    
        public FrmNewProvCli(Proveedor proveedor)
        {
            InitializeComponent();
            
            _proveedor = new Proveedor();
            _provincia = new Provincia();
            Validacion.combo2campos(cboProv, "DescripcionProvincia", "IdProvincia", "Provincia");
            Validacion.combo2campos(cboEstadoProv, "DescripcionEstado", "IdEstado", "Estado");

            if (proveedor != null)
            {
                btnGuardar.Visible = false;
                btnGuardar.Enabled = false;
                txtCodigoProveedor.Enabled = false;
                txtCodigoProveedor.Text = Convert.ToInt32(proveedor.IdProveedor.ToString()).ToString();
                txtCuit.Text = proveedor.CuitCuil;
                txtRazonSocial.Text = proveedor.RazonSocial;
                txtDireccion.Text = proveedor.Direccion;
                txtLocalidad.Text = proveedor.Localidad;
                cboProv.Text = proveedor.provincia.DescripcionProvincia;
                txtTel1.Text = proveedor.Tel1;
                txtTel2.Text = proveedor.Tel2;
                TxtEmail.Text = proveedor.Email;
                cboEstadoProv.Text = proveedor.Estado.DescripcionEstado;
                Accion = "MODIFICAR";
                
            }//end-if
            else
            {
                btnModificar.Enabled = false;
                btnModificar.Visible = false;
                txtCodigoProveedor.Visible = false;
                lblCodigoProveedor.Visible = false;
                Accion = "ALTA";
            }
        }//constuctor


        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
                private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wparam, int lparam);

       

        private void FrmNewProv_Load(object sender, EventArgs e)
        {

        }

      

        private void FrmNewProv_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

  

        private void LblCodProv_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Accion == "ALTA")
            {
               
                _proveedor.CuitCuil = txtCuit.Text;
                _proveedor.RazonSocial = txtRazonSocial.Text;
                _proveedor.Direccion = txtDireccion.Text;
                _proveedor.Localidad = txtLocalidad.Text;
                _proveedor.provincia.IdProvincia = Convert.ToInt32(((DataRowView)cboProv.SelectedItem)["IdProvincia"]);
                _proveedor.Tel1 = txtTel1.Text.ToString();
                _proveedor.Tel2 = txtTel2.Text.ToString();
                _proveedor.Email = TxtEmail.Text.ToString();
                _proveedor.Estado.IdEstado = Convert.ToInt32(((DataRowView)cboEstadoProv.SelectedItem)["IdEstado"]);

                _proveedor.Accion(_proveedor, "ALTA");
                this.Close();
                MessageBox.Show("El proveedor " + _proveedor.RazonSocial + " ha sido ingresado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            Accion = "MODIFICAR";

            if (Accion == "MODIFICAR") {

                _proveedor.IdProveedor = Convert.ToInt32(txtCodigoProveedor.Text.ToString());
                _proveedor.CuitCuil = txtCuit.Text;
                _proveedor.RazonSocial = txtRazonSocial.Text;
                _proveedor.Direccion = txtDireccion.Text;
                _proveedor.Localidad = txtLocalidad.Text;
                _proveedor.provincia.IdProvincia = Convert.ToInt32(((DataRowView)cboProv.SelectedItem)["IdProvincia"]);
                _proveedor.Tel1 = txtTel1.Text.ToString();
                _proveedor.Tel2 = txtTel2.Text.ToString();
                _proveedor.Email = TxtEmail.Text.ToString();
                _proveedor.Estado.IdEstado = Convert.ToInt32(((DataRowView)cboEstadoProv.SelectedItem)["IdEstado"]);

                _proveedor.Accion(_proveedor, "MODIFICAR");
                this.Close();
                MessageBox.Show("El proveedor " + _proveedor.RazonSocial + " ha sido modificado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }//end-if
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtCuit_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
