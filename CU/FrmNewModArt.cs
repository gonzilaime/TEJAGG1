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
    public partial class FrmNewModArt : Form
    {
        public Articulos articulo;
        public Provincia _provincia;
        public Proveedor _proveedor;
        public string AccionArticulo;
        public FrmNewModArt(Articulos articulos)
        {
            InitializeComponent();
            articulo = new Articulos();
            _provincia = new Provincia();
            _proveedor = new Proveedor();
            Validacion.combo2campos(cboProveedor, "RazonSocial", "IdProveedor", "Proveedores");

            if (articulos != null)
            {
                btnGuardar.Visible = false;
                btnGuardar.Enabled = false;
                txtIdArticulo.Enabled = false;
                txtIdArticulo.Text = Convert.ToInt32(articulos.IdArticulo.ToString()).ToString();
                txtNombreProd.Text = articulos.NombreArticulo;
                txtBonificacion.Text = Convert.ToInt32(articulos.Bonificacion.ToString()).ToString();
                txtPrecio.Text = Convert.ToDecimal(articulos.Bonificacion.ToString()).ToString();
                cboProveedor.Text = articulos.proveedor.RazonSocial;

                AccionArticulo = "MODIFICAR";

            }
            else
            {
                btnModificar.Enabled = false;
                btnModificar.Visible = false;
                txtIdArticulo.Visible = false;
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
                articulo.Precio = Convert.ToDecimal(txtPrecio.Text.ToString());
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
                articulo.Precio = Convert.ToDecimal(txtPrecio.Text.ToString());
                articulo.proveedor.IdProveedor = Convert.ToInt32(((DataRowView)cboProveedor.SelectedItem)["IdProveedor"]);

                articulo.AccionArticulo(articulo, "MODIFICAR");
                this.Hide();
                MessageBox.Show("El articulo " + articulo.NombreArticulo + " ha sido modificado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
