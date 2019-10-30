using CL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CU
{
    public partial class FrmCompras : Form
    {
        public TipoPerfil tipoPerfil;
        public OrdenDeCompra ordenCompra;
        public EstadoOrdenCompra _estadoCompra;
        public FrmCompras(int _perfil)
        {
            InitializeComponent();
            tipoPerfil = new TipoPerfil();
            tipoPerfil.IdPerfil = _perfil;
            ordenCompra = new OrdenDeCompra();
            _estadoCompra = new EstadoOrdenCompra();

        }//constructor

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (tipoPerfil.IdPerfil == 1)
            {


                FrmNewModCompras formularioOrden = new FrmNewModCompras();
                formularioOrden.ShowDialog();
                
            }//if
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador",
                   "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//end-if

        }//btnAgregar

        public void listar()
        {
            OrdenDeCompra compra = new OrdenDeCompra();
            listaOrdenes.Rows.Clear();
            var cadena = txtBuscar.Text.ToString();
            var ordenObtenida = compra.obtenerCompras(cadena);

            foreach (var orden in ordenObtenida)
            {
                listaOrdenes.Rows.Add(orden.IdOrdenDeCompra,orden.Fecha,orden.proveedor.RazonSocial,
                    orden._estado.DescripcionEstadoOrdenCompra);
            }//foreach

        }//listar

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            listar();

            
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            listar();
        }//txtChanged

        
    }//FrmCompras
    
}//CU
