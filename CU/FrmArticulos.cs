using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CL;

namespace CU
{
    public partial class FrmArticulos : Form
    {
        public Articulos articulo;
        public Proveedor proveedor;
        public TipoPerfil tipoPerfil;
        public Usuario usuario;
        public FrmArticulos(int _perfil)
        {
            InitializeComponent();
            tipoPerfil = new TipoPerfil();
            tipoPerfil.IdPerfil = _perfil;
            articulo = new Articulos();
            proveedor = new Proveedor();
            
        }//constructor
        

        /******************************************************
         * Métodos para llenar ListBox con datos de Articulos***
        *******************************************************/
        public void listarArticulos()
        {
            Articulos art = new Articulos();
            listaArticulos.Rows.Clear();
            var filtro = txtBuscar.Text;
            var articuloObtenido = art.obtenerArticulos(filtro);

            foreach(var articulo in articuloObtenido)
            {
                listaArticulos.Rows.Add(articulo.IdArticulo, articulo.NombreArticulo,
                    articulo.Precio, articulo.proveedor.IdProveedor, articulo.proveedor.RazonSocial);

            }//foreach

        }//listarArticulos


        private void BtnNewArticulo_Click_1(object sender, EventArgs e)
        {
            if (tipoPerfil.IdPerfil == 1)
            {
                FrmNewModArt formulario = new FrmNewModArt(articulo = null);
                formulario.ShowDialog();
                listarArticulos();
            }//IF
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador",
                    "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//END-IF
        }

        

        private void ListaArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tipoPerfil.IdPerfil == 1)
            {
                Articulos art = new Articulos();
                art.IdArticulo = Convert.ToInt32(listaArticulos.Rows[e.RowIndex].Cells[0].Value.ToString());
                art.NombreArticulo = listaArticulos.Rows[e.RowIndex].Cells[1].Value.ToString();
                art.Precio = Convert.ToDecimal(listaArticulos.Rows[e.RowIndex].Cells[2].Value.ToString());
                art.proveedor.IdProveedor = Convert.ToInt32(listaArticulos.Rows[e.RowIndex].Cells[3].Value.ToString());
                art.proveedor.RazonSocial = listaArticulos.Rows[e.RowIndex].Cells[4].Value.ToString();


                FrmNewModArt formulario = new FrmNewModArt(art);
                formulario.ShowDialog();
                listarArticulos();
            }//IF
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador",
                    "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//END-IF
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            listarArticulos();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

            listarArticulos();
        }

        private void ListaArticulos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tipoPerfil.IdPerfil == 1)
            {
            }//IF
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador",
                    "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//END-IF
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            if (tipoPerfil.IdPerfil == 1)
            {
                Articulos artic = new Articulos();
                artic.IdArticulo = Convert.ToInt32(listaArticulos.CurrentRow.Cells[0].Value.ToString());
                artic.NombreArticulo = listaArticulos.CurrentRow.Cells[1].Value.ToString();
                artic.Precio = Convert.ToDecimal(listaArticulos.CurrentRow.Cells[2].Value.ToString());
                artic.proveedor.IdProveedor = Convert.ToInt32(listaArticulos.CurrentRow.Cells[3].Value.ToString());
                artic.proveedor.RazonSocial = listaArticulos.CurrentRow.Cells[4].Value.ToString();


                FrmNewModArt formulario = new FrmNewModArt(artic);
                formulario.ShowDialog();
                listarArticulos();
            }//IF
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador",
                    "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//END-IF
        }

        private void FrmArticulos_Activated(object sender, EventArgs e)
        {
            listarArticulos();
        }
    }
}
