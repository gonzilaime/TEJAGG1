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
    public partial class FrmNewModClientes : Form
    {

        public Clientes _cliente;
        public Provincia _provincia;
        public Estado _estado;
        public string Accion;

        #region SOMBRA EN EL FORMULARIO
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

        
        public FrmNewModClientes(Clientes clientes)
        {
            InitializeComponent();
            _cliente = new Clientes();
            _provincia = new Provincia();
            _estado = new Estado();
           

            Validacion.combo2campos(cboProv, "DescripcionProvincia", "IdProvincia", "Provincia");
            Validacion.combo2campos(cboEstadoCli, "DescripcionEstado", "IdEstado", "Estado");

            
            if (clientes != null)
            {
                btnGuardar.Visible = false;
                btnGuardar.Enabled = false;
                txtCodigoClientes.Enabled = false;
                txtCodigoClientes.Text = Convert.ToInt32(clientes.IdCliente.ToString()).ToString();
                txtCuit.Text = clientes.CuitCuil;
                txtRazonSocial.Text = clientes.RazonSocial;
                txtDireccion.Text = clientes.Direccion;
                txtLocalidad.Text = clientes.Localidad;
                cboProv.Text = clientes.provincia.DescripcionProvincia;
                txtTel1.Text = clientes.Tel1;
                txtTel2.Text = clientes.Tel2;
                TxtEmail.Text = clientes.Email;
                cboEstadoCli.Text = clientes.estado.DescripcionEstado;
                Accion = "MODIFICAR";
                
            }//end-if
            else
            {
                btnModificar.Enabled = false;
                btnModificar.Visible = false;
                txtCodigoClientes.Visible = false;
                lblCodigoCliente.Visible = false;
                Accion = "ALTA";
            }
        }//constuctor

        #region Movilidad del formulario
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


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Accion == "ALTA")
            {
               
                _cliente.CuitCuil = txtCuit.Text;
                _cliente.RazonSocial = txtRazonSocial.Text;
                _cliente.Direccion = txtDireccion.Text;
                _cliente.Localidad = txtLocalidad.Text;
                _cliente.provincia.IdProvincia = Convert.ToInt32(((DataRowView)cboProv.SelectedItem)["IdProvincia"]);
                _cliente.Tel1 = txtTel1.Text.ToString();
                _cliente.Tel2 = txtTel2.Text.ToString();
                _cliente.Email = TxtEmail.Text.ToString();
                _cliente.estado.IdEstado = Convert.ToInt32(((DataRowView)cboEstadoCli.SelectedItem)["IdEstado"]);

                _cliente.Accion(_cliente, "ALTA");
                this.Hide();
                MessageBox.Show("El cliente " + _cliente.RazonSocial + " ha sido ingresado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Accion = "MODIFICAR";

            if (Accion == "MODIFICAR")
            {

                _cliente.IdCliente = Convert.ToInt32(txtCodigoClientes.Text.ToString());
                _cliente.CuitCuil = txtCuit.Text;
                _cliente.RazonSocial = txtRazonSocial.Text;
                _cliente.Direccion = txtDireccion.Text;
                _cliente.Localidad = txtLocalidad.Text;
                _cliente.provincia.IdProvincia = Convert.ToInt32(((DataRowView)cboProv.SelectedItem)["IdProvincia"]);
                _cliente.Tel1 = txtTel1.Text.ToString();
                _cliente.Tel2 = txtTel2.Text.ToString();
                _cliente.Email = TxtEmail.Text.ToString();
                _cliente.estado.IdEstado = Convert.ToInt32(((DataRowView)cboEstadoCli.SelectedItem)["IdEstado"]);

                _cliente.Accion(_cliente, "MODIFICAR");
                this.Hide();
                MessageBox.Show("El cliente " + _cliente.RazonSocial + " ha sido modificado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }//end-if
        }

        private void FrmNewModClientes_Load(object sender, EventArgs e)
        {
  
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
       

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        

        // Generar sombra en el formulario


    }
}
