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
         * Métodos para llenar LitBox con datos de Articulos***
        *******************************************************/
        public void listarArticulos()
        {
            listaArticulos.Rows.Clear();
            var filtro = txtBuscar.Text;
            var articuloObtenido = articulo.obtenerArticulos(filtro);

            foreach(var articulo in articuloObtenido)
            {
                listaArticulos.Rows.Add(articulo.IdArticulo, articulo.NombreArticulo, articulo.Bonificacion,
                    articulo.Precio, articulo.proveedor.IdProveedor, articulo.proveedor.RazonSocial);

            }//foreach

        }//listarArticulos


        private void BtnNewArticulo_Click_1(object sender, EventArgs e)
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
    }
}
