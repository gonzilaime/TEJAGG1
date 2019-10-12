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
        public Articulos _articulo;
        public Provincia _provincia;
        public Proveedor _proveedor;
        public string Accion; 
        public FrmNewModArt(Articulos articulos)
        {
            InitializeComponent();
            _articulo = new Articulos();
            _provincia = new Provincia();
            _proveedor = new Proveedor();
            Validacion.combo2campos(cboProveedor, "RazonSocial", "IdProveedor", "Proveedor");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Accion == "ALTA")
            {
                _articulo.IdArticulo = Convert.ToInt32(txtIdArticulo.Text.ToString());
                _articulo.NombreArticulo = txtNombreProd.Text.ToString();
                _articulo.Bonificacion = Convert.ToInt32(txtBonificacion.Text.ToString());
            }
        }
    }
}
