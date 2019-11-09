using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using CL;

namespace CU
{
    public partial class NuevoUsuario : Form
    {
        public Usuario _usuario;
        public Encriptar _encriptar;

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
        public NuevoUsuario()
        {
            _usuario = new Usuario();
            _encriptar = new Encriptar(); 

            InitializeComponent();
            Validacion.combo2campos(cboTipoPerfil, "DescripcionPerfil", "IdPerfil", "TipoPerfil");
        }
        #region CAMPOS OBLIGATORIOS
        public bool CamposObligatorios()
        {
            if (txtNick.Text == "" && txtContraseña.Text == "")
            {
                lblNickObligatorio.Visible = true;
                lblContraseñaObligatorio.Visible = true;

                return false;
            }

            else if(txtNick.Text == "")
            {
                lblNickObligatorio.Visible = true;
                return false;
            }
            else if (txtContraseña.Text == "")
            {
                lblContraseñaObligatorio.Visible = true;
                return false;
            }
            return true;
        }
        #endregion

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wparam, int lparam);


        private void txtNick_TextChanged(object sender, EventArgs e)
        {
            lblNickObligatorio.Visible = false;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            lblContraseñaObligatorio.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            bool rta = false;
            if (CamposObligatorios() == rta)
            {
                return;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            _usuario.NickUsu = txtNick.Text;
            // string cadenaEncriptada = _encriptar.GetMD5(txtContraseña.Text); 
            _usuario.Contraseña = txtContraseña.Text; // cadenaEncriptada
            _usuario.perfil.IdPerfil = Convert.ToInt32(((DataRowView)cboTipoPerfil.SelectedItem)["IdPerfil"]);
            _usuario.AgregarUsuario(_usuario);
            txtNick.Clear();
            txtContraseña.Clear();
            MessageBox.Show("El usuario " + _usuario.NickUsu + " ha sido ingresado ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
    }

}
