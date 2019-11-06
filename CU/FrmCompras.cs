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
        public Detalle _detalle;
        public FrmCompras(int _perfil)
        {
            InitializeComponent();
            tipoPerfil = new TipoPerfil();
            tipoPerfil.IdPerfil = _perfil;
            ordenCompra = new OrdenDeCompra();
            _estadoCompra = new EstadoOrdenCompra();
            _detalle = new Detalle();
        }//constructor

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (tipoPerfil.IdPerfil == 1)
            {


                FrmNewModCompras formularioOrden = new FrmNewModCompras(_detalle=null);
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
                listaOrdenes.Rows.Add(orden.IdOrdenDeCompra, orden.Fecha, orden.proveedor.RazonSocial,
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

        private void ListaOrdenes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tipoPerfil.IdPerfil == 1)
            {

                _detalle.IdOrdenDeCompra = Convert.ToInt32(listaOrdenes.Rows[e.RowIndex].Cells[0].Value.ToString());
                //_detalle.proveedor.IdProveedor = Convert.ToInt32(listaOrdenes.Rows[e.RowIndex].Cells[4].Value.ToString());
                //articulo.Bonificacion = Convert.ToInt32(listaArticulos.Rows[e.RowIndex].Cells[2].Value.ToString());
                //articulo.Precio = Convert.ToDecimal(listaArticulos.Rows[e.RowIndex].Cells[3].Value.ToString());
                //articulo.proveedor.IdProveedor = Convert.ToInt32(listaArticulos.Rows[e.RowIndex].Cells[4].Value.ToString());
                //articulo.proveedor.RazonSocial = listaArticulos.Rows[e.RowIndex].Cells[5].Value.ToString();

                FrmNewModCompras formularioOrden = new FrmNewModCompras(_detalle);
                formularioOrden.ShowDialog();
            }//if
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador",
                   "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//end-if
        }
    }//FrmCompras
    
}//CU
