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

        public FrmNewProvCli(Proveedor proveedor)
        {
            InitializeComponent();
            _proveedor = new Proveedor();
            _provincia = new Provincia();
            Provincia.combo(cboProv, "Descripcion", "IdProvincia", "Provincia");
            Provincia.combo(cboEstadoProv, "Descripcion", "IdEstadoProveedor", "EstadoProv");

            if (proveedor != null)
            {
                btnAlta.Visible = false;
                btnAlta.Enabled = false;

                txtCuit.Text = proveedor.CuitCuil;
                txtRazonSocial.Text = proveedor.RazonSocial;
                txtDireccion.Text = proveedor.Direccion;
                txtLocalidad.Text = proveedor.Localidad;
                cboProv.Text = proveedor.provincia.DescripcionProvincia;
                txtTel1.Text = Convert.ToInt32(proveedor.Tel1.ToString()).ToString();
                txtTel2.Text = Convert.ToInt32(proveedor.Tel2.ToString()).ToString();
                TxtEmail.Text = proveedor.Email;
                txtBonificacion.Text = Convert.ToInt32(proveedor.Bonificacion.ToString()).ToString();
                cboEstadoProv.Text = proveedor.EstadoProv.Descripcion;

                Accion = "MODIFICAR";




            }//end-if
            else
            {
                btnModificar.Enabled = false;
                btnModificar.Visible = false;
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

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                _proveedor.Tel1 = Convert.ToInt32(txtTel1.Text.ToString());
                _proveedor.Tel2 = Convert.ToInt32(txtTel2.Text.ToString());
                _proveedor.Email = TxtEmail.Text;
                _proveedor.Bonificacion = Convert.ToInt32(txtBonificacion.Text.ToString());
                //_proveedor.EstadoProv.IdEstadoProveedor = Convert.ToInt32(((DataRowView)cboEstadoProv.SelectedItem)["IdEstadoProveedor"]);


                _proveedor.Accion(_proveedor, "ALTA");
                this.Hide();
                MessageBox.Show("El proveedor " + _proveedor.RazonSocial + " ha sido ingresado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (Accion == "MODIFICAR ")
            {
                _proveedor.CuitCuil = txtCuit.Text;
                _proveedor.RazonSocial = txtRazonSocial.Text;
                _proveedor.Direccion = txtDireccion.Text;
                _proveedor.Localidad = txtLocalidad.Text;
                _proveedor.provincia.IdProvincia = Convert.ToInt32(((DataRowView)cboProv.SelectedItem)["IdProvincia"]);
                _proveedor.Tel1 = Convert.ToInt32(txtTel1.Text.ToString());
                _proveedor.Tel2 = Convert.ToInt32(txtTel2.Text.ToString());
                _proveedor.Email = TxtEmail.Text;
                _proveedor.EstadoProv.IdEstadoProveedor = Convert.ToInt32(((DataRowView)cboEstadoProv.SelectedItem)["IdEstadoProveedor"]);

                _proveedor.Accion(_proveedor, "MODIFICAR");
                this.Hide();
                MessageBox.Show("El proveedor " + _proveedor.RazonSocial + " ha sido modificado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
