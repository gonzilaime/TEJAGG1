using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CL;
using System.Runtime.InteropServices;
using System.Windows;
using Application = System.Windows.Forms.Application;

namespace CU
{
    public partial class FormMenu : Form
    {
        public TipoPerfil _tipoPerfil;
        public Usuario usuario;
        public FrmMenu frmMenu;
        
            

        #region
        //private const int WM_NCHITTEST = 0x84;
        //private const int HTCLIENT = 0x1;
        //private const int HTCAPTION = 0x2;

        //private bool m_aeroEnabled;

        //private const int CS_DROPSHADOW = 0x00020000;
        //private const int WM_NCPAINT = 0x0085;
        //private const int WM_ACTIVATEAPP = 0x001C;

        //[System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        //public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        //[System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        //public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        //[System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        //public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        //[System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn(
        //    int nLeftRect,
        //    int nTopRect,
        //    int nRightRect,
        //    int nBottomRect,
        //    int nWidthEllipse,
        //    int nHeightEllipse
        //    );

        //public struct MARGINS
        //{
        //    public int leftWidth;
        //    public int rightWidth;
        //    public int topHeight;
        //    public int bottomHeight;
        //}
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        m_aeroEnabled = CheckAeroEnabled();
        //        CreateParams cp = base.CreateParams;
        //        if (!m_aeroEnabled)
        //            cp.ClassStyle |= CS_DROPSHADOW; return cp;
        //    }
        //}
        //private bool CheckAeroEnabled()
        //{
        //    if (Environment.OSVersion.Version.Major >= 6)
        //    {
        //        int enabled = 0; DwmIsCompositionEnabled(ref enabled);
        //        return (enabled == 1) ? true : false;
        //    }
        //    return false;
        //}
        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case WM_NCPAINT:
        //            if (m_aeroEnabled)
        //            {
        //                var v = 2;
        //                DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
        //                MARGINS margins = new MARGINS()
        //                {
        //                    bottomHeight = 1,
        //                    leftWidth = 0,
        //                    rightWidth = 0,
        //                    topHeight = 0
        //                }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
        //            }
        //            break;
        //        default: break;
        //    }
        //    base.WndProc(ref m);
        //    if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        //}
        #endregion//sombra formulario
        public FormMenu(int _perfil,string Nick)
        {
            InitializeComponent();
            _tipoPerfil = new TipoPerfil();
            _tipoPerfil.IdPerfil = _perfil;
            usuario = new Usuario();
            

        }

     

        private void BtnArticulos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmArticulos(_tipoPerfil.IdPerfil));
            panelArticulos.Visible = true;
            panelClientes.Visible = false;
            panelProveedores.Visible = false;
            panelCompras.Visible = false;
            panelInicio.Visible = false;
            btnArt.Visible = true;
            btnArticulos.Visible = false;
            btnProv.Visible = false;
            btnProveedores.Visible = true;
            btnClientes.Visible = true;
            btnCli.Visible = false;
            btnCompras.Visible = true;
            btnCom.Visible = false;
            btnInicio.Visible = false;
            btnIni.Visible = true;

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmClientes(_tipoPerfil.IdPerfil));
            panelArticulos.Visible = false;
            panelClientes.Visible = true;
            panelProveedores.Visible = false;
            panelCompras.Visible = false;
            panelInicio.Visible = false;
            btnCli.Visible = true;
            btnClientes.Visible = false;  
            btnProveedores.Visible = true;
            btnProv.Visible = false;
            btnArticulos.Visible = true;
            btnArt.Visible = false;
            btnCompras.Visible = true;
            btnCom.Visible = false;
            btnIni.Visible = true;
            btnInicio.Visible = false;
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmProveedores(_tipoPerfil.IdPerfil));
            panelArticulos.Visible = false;
            panelClientes.Visible = false;
            panelProveedores.Visible = true;
            panelCompras.Visible = false;
            panelInicio.Visible = false;

            btnProv.Visible = true;
            btnProveedores.Visible = false;
            btnClientes.Visible = true;
            btnCli.Visible = false;
            btnArticulos.Visible = true;
            btnArt.Visible = false;
            btnCompras.Visible = true;
            btnCom.Visible = false;
            btnIni.Visible = true;
            btnInicio.Visible = false;
        }
     
        private void BtnProv_Click(object sender, EventArgs e)
        {

        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmCompras(_tipoPerfil.IdPerfil));
            panelArticulos.Visible = false;
            panelClientes.Visible = false;
            panelProveedores.Visible = false;
            panelInicio.Visible = false;
            panelCompras.Visible = true;
            btnProv.Visible = false;
            btnProveedores.Visible = true;
            btnClientes.Visible = true;
            btnCli.Visible = false;
            btnArticulos.Visible = true;
            btnArt.Visible = false;
            btnCom.Visible = true;
            btnInicio.Visible = false;
            btnIni.Visible = true;


        }

        private void BtnCompras_MouseMove(object sender, MouseEventArgs e)
        {
            //panelSubMenuCompras.Visible = true;
        }

        private void BtnCompras_MouseLeave(object sender, EventArgs e)
        {
            // panelSubMenuCompras.Visible = false;
        }

        private void BtnCompras_MouseUp(object sender, MouseEventArgs e)
        {
            //panelSubMenuCompras.Visible = true;
        }
        //Metodo para abrir forms dentro del panel contenedor del menu
        private void AbrirFormHijo(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            panelArticulos.Visible = false;
            panelClientes.Visible = false;
            panelProveedores.Visible = false;
            panelCompras.Visible = false;
            btnArt.Visible = false;
            btnArticulos.Visible = true;
            btnProv.Visible = false;
            btnProveedores.Visible = true;
            btnClientes.Visible = true;
            btnCli.Visible = false;
            btnCompras.Visible = true;
            btnCom.Visible = false;

        }

        private void BtnIni_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmMenu(_tipoPerfil.IdPerfil));

            panelInicio.Visible = true;
            btnInicio.Visible = true;
            btnIni.Visible = false;
            btnProv.Visible = false;
            btnCli.Visible = false;
            btnArt.Visible = false;
            btnCom.Visible = false;
            btnProveedores.Visible = true;
            btnClientes.Visible = true;
            btnArticulos.Visible = true;
            btnCompras.Visible = true;
            btnIni.Visible = false;
            panelArticulos.Visible = false;
            panelCompras.Visible = false;
            panelProveedores.Visible = false;
            panelClientes.Visible = false;
            
            
           
        }


        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelArriba_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMenu_Load_1(object sender, EventArgs e)
        {
            BtnIni_Click(null, e);
        
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        #region MOVILIDAD DEL FORM

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wparam, int lparam);
        #endregion
        private void PanelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            if (WindowState == FormWindowState.Normal)
            {
                btnMaximizar.Visible = true;
                btnNormal.Visible = false;
            }
            else
            {
                btnMaximizar.Visible = false;
                btnNormal.Visible = true;
            }
        }

        private void PanelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            if (WindowState == FormWindowState.Normal)
            {
                btnMaximizar.Visible = true;
                btnNormal.Visible = false;
            }
            else
            {
                btnMaximizar.Visible = false;
                btnNormal.Visible = true;
            }
        }

        private void PanelArriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);


            if (WindowState == FormWindowState.Normal)
            {
                btnMaximizar.Visible = true;
                btnNormal.Visible = false;
            }
            else
            {
                btnMaximizar.Visible = false;
                btnNormal.Visible = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login1 = new Login();
            login1.ShowDialog();


        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;

        }

        private void btnNormal_Click_1(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnNormal.Visible = false;
            this.WindowState = FormWindowState.Normal;

          
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
  

    }
}
