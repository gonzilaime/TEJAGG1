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
    public partial class FrmNewModClientes : Form
    {

        public Clientes _cliente;
        public Provincia _provincia;
        public Estado _estado;
        public string Accion;
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
            this.Hide();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
