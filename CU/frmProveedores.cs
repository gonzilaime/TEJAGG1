using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CL;

namespace CU
{
    public partial class frmProveedores : Form
    {

        public Conectar conexion;
        public Proveedor _proveedor;
        public Provincia _provincia;
        public TipoPerfil _tipoPerfil;
        public Usuario usuario;

        public frmProveedores(int _perfil)
        {

            InitializeComponent();
            _tipoPerfil = new TipoPerfil();
            _tipoPerfil.IdPerfil = _perfil;
            conexion = new Conectar();
            _proveedor = new Proveedor();
            _provincia = new Provincia();
        }

        private void BtnNewProveedor_Click(object sender, EventArgs e)
        {
            if (_tipoPerfil.IdPerfil == 1) { 
            FrmNewProvCli formulario = new FrmNewProvCli(_proveedor=null);
            formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // string textoCelda = listaProveedor.SelectedCells[0].Value.ToString();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {

            listar();
           
        }

        private void listar()
        {
            listaProveedor.Rows.Clear();
            var cadena = txtBuscar.Text.ToString();
            var proveedorObtenido = _proveedor.obtenerProveedores(cadena);

            foreach (var reg in proveedorObtenido)
            {
                listaProveedor.Rows.Add(reg.IdProveedor, reg.CuitCuil, reg.RazonSocial, reg.Direccion, reg.Localidad, reg.provincia.DescripcionProvincia, reg.Tel1, reg.Tel2, reg.Email, reg.Estado.DescripcionEstado);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (_tipoPerfil.IdPerfil == 1)
            {
                _proveedor.IdProveedor = Convert.ToInt32(listaProveedor.CurrentRow.Cells[0].Value.ToString());
                _proveedor.CuitCuil = listaProveedor.CurrentRow.Cells[1].Value.ToString();
                _proveedor.RazonSocial = listaProveedor.CurrentRow.Cells[2].Value.ToString();
                _proveedor.Direccion = listaProveedor.CurrentRow.Cells[3].Value.ToString();
                _proveedor.Localidad = listaProveedor.CurrentRow.Cells[4].Value.ToString();
                _proveedor.provincia.DescripcionProvincia = listaProveedor.CurrentRow.Cells[5].Value.ToString();
                _proveedor.Tel1 = listaProveedor.CurrentRow.Cells[6].Value.ToString();
                _proveedor.Tel2 = listaProveedor.CurrentRow.Cells[7].Value.ToString();
                _proveedor.Email = listaProveedor.CurrentRow.Cells[8].Value.ToString();
                _proveedor.Estado.DescripcionEstado = listaProveedor.CurrentRow.Cells[9].Value.ToString();


                Form formProveedor = new FrmNewProvCli(_proveedor);
                formProveedor.ShowDialog();
            }
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ListaProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_tipoPerfil.IdPerfil == 1) { 
            _proveedor.IdProveedor = Convert.ToInt32(listaProveedor.Rows[e.RowIndex].Cells[0].Value.ToString());
            _proveedor.CuitCuil = listaProveedor.Rows[e.RowIndex].Cells[1].Value.ToString();
            _proveedor.RazonSocial = listaProveedor.Rows[e.RowIndex].Cells[2].Value.ToString();
            _proveedor.Direccion = listaProveedor.Rows[e.RowIndex].Cells[3].Value.ToString();
            _proveedor.Localidad = listaProveedor.Rows[e.RowIndex].Cells[4].Value.ToString();
            _proveedor.provincia.DescripcionProvincia = listaProveedor.Rows[e.RowIndex].Cells[5].Value.ToString();
            _proveedor.Tel1 = listaProveedor.Rows[e.RowIndex].Cells[6].Value.ToString();
            _proveedor.Tel2 = listaProveedor.Rows[e.RowIndex].Cells[7].Value.ToString();
            _proveedor.Email = listaProveedor.Rows[e.RowIndex].Cells[8].Value.ToString();
           _proveedor.Estado.DescripcionEstado = listaProveedor.Rows[e.RowIndex].Cells[9].Value.ToString();

            
            FrmNewProvCli formProveedor = new FrmNewProvCli(_proveedor);
            formProveedor.ShowDialog();
            }
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            listar();
        }
    }
}
