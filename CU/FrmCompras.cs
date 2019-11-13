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
                listar(txtBuscar.Text,"t2.RazonSocial");
            }//if
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador",
                   "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//end-if
        }//btnAgregar

        public void listar(string cadena,string condicion)
        {
            OrdenDeCompra compra = new OrdenDeCompra();
            listaOrdenes.Rows.Clear();
            var ordenObtenida = compra.obtenerCompras(cadena, condicion);

            foreach (var orden in ordenObtenida)
            {
                listaOrdenes.Rows.Add(orden.IdOrdenDeCompra, orden.Fecha, orden.proveedor.RazonSocial,orden.proveedor.IdProveedor,
                    orden._estado.DescripcionEstadoOrdenCompra,orden.Monto);
            }//foreach

        }//listar

        private void FrmCompras_Load(object sender, EventArgs e)
        {

            chequear();
            
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            listar(txtBuscar.Text, "t2.RazonSocial");
        }//txtChanged

        private void ListaOrdenes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tipoPerfil.IdPerfil == 1)
            {
                Detalle detail = new Detalle();
                detail.ordenCompra.IdOrdenDeCompra = Convert.ToInt32(listaOrdenes.Rows[e.RowIndex].Cells[0].Value.ToString());
                detail.proveedor.RazonSocial = listaOrdenes.Rows[e.RowIndex].Cells[2].Value.ToString();
                detail.proveedor.IdProveedor = Convert.ToInt32(listaOrdenes.Rows[e.RowIndex].Cells[3].Value.ToString());
                FrmNewModCompras formularioOrden = new FrmNewModCompras(detail);
                formularioOrden.ShowDialog();
                listar(txtBuscar.Text, "t2.RazonSocial");
            }//if
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador",
                   "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//end-if
        }

        public void chequear()
        {
            if(radioBtnPendiente.Checked == true)
            {
                listar("PENDIENTE", "t3.DescripcionOrdenCompra");
            }
            else if (radioBtnAnuladas.Checked == true)
            {
                listar("ANULADA", "t3.DescripcionOrdenCompra");
            }
            else if (radioBtnEntregada.Checked == true)
            {
                listar("ENTREGADA", "t3.DescripcionOrdenCompra");
            }
            else if(RadioBtnOC.Checked == true)
            { 
                listar(txtBuscar.Text, "t2.RazonSocial");
            }
            else
            {
                listar(txtBuscar.Text, "t2.RazonSocial");
            }
        }
        private void FrmCompras_Activated(object sender, EventArgs e)
        {
            chequear();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (tipoPerfil.IdPerfil == 1)
            {
                Detalle deta = new Detalle();
                deta.ordenCompra.IdOrdenDeCompra = Convert.ToInt32(listaOrdenes.CurrentRow.Cells[0].Value.ToString());
                deta.proveedor.RazonSocial = listaOrdenes.CurrentRow.Cells[2].Value.ToString();
                deta.proveedor.IdProveedor = Convert.ToInt32(listaOrdenes.CurrentRow.Cells[3].Value.ToString());
                FrmNewModCompras formularioOrden = new FrmNewModCompras(deta);
                formularioOrden.ShowDialog();
                listar(txtBuscar.Text,"t2.RazonSocial");
            }
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region RadioBtn
        private void RadioBtnPendiente_CheckedChanged(object sender, EventArgs e)
        {
            chequear();
        }

        private void RadioBtnAnuladas_CheckedChanged(object sender, EventArgs e)
        {
            chequear();
        }

        private void RadioBtnEntregada_CheckedChanged(object sender, EventArgs e)
        {
            chequear();
        }

        private void RadioBtnPendiente_Click(object sender, EventArgs e)
        {
            chequear();
        }

        private void RadioBtnAnuladas_Click(object sender, EventArgs e)
        {
            chequear();
        }

        private void RadioBtnEntregada_Click(object sender, EventArgs e)
        {
            chequear();
        }

        private void BtnOC_CheckedChanged(object sender, EventArgs e)
        {
            chequear();
        }

        private void RadioBtnOC_Click(object sender, EventArgs e)
        {
            chequear();
        }
    }//FrmCompras
    #endregion

}//CU
