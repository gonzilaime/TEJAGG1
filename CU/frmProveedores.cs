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

        public frmProveedores()
        {
            InitializeComponent();
            conexion = new Conectar();
            _proveedor = new Proveedor();
            _provincia = new Provincia();

          
        }

        private void BtnNewProveedor_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmNewProvCli(_proveedor=null);
            formulario.Show();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string textoCelda = lista.SelectedCells[0].Value.ToString();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {

            listar();

        }

        private void listar()
        {
            lista.Rows.Clear();

            var proveedorObtenido = _proveedor.obtenerProveedores();

            foreach (var reg in proveedorObtenido)
            {
                lista.Rows.Add(reg.IdProveedor, reg.CuitCuil, reg.RazonSocial, reg.Direccion, reg.Localidad, reg.IdProvincia, reg.Tel1, reg.Tel2, reg.Email, reg.Bonificacion, reg.IdEstado);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            _proveedor.IdProveedor = Convert.ToInt32(lista.CurrentRow.Cells[0].Value.ToString());
            _proveedor.CuitCuil = lista.CurrentRow.Cells[1].Value.ToString();
            _proveedor.RazonSocial = lista.CurrentRow.Cells[2].Value.ToString();
            _proveedor.Direccion = lista.CurrentRow.Cells[3].Value.ToString();
            _proveedor.Localidad = lista.CurrentRow.Cells[4].Value.ToString();
            _proveedor.provincia.DescripcionProvincia = lista.CurrentRow.Cells[5].Value.ToString();
            _proveedor.Tel1 = Convert.ToInt32(lista.CurrentRow.Cells[6].Value.ToString());
            _proveedor.Tel2 = Convert.ToInt32(lista.CurrentRow.Cells[7].Value.ToString());
            _proveedor.Email = lista.CurrentRow.Cells[8].Value.ToString();
            _proveedor.Bonificacion = Convert.ToInt32(lista.CurrentRow.Cells[9].Value.ToString());
            _proveedor.EstadoProv.Descripcion = lista.CurrentRow.Cells[10].Value.ToString();
            

            Form formProveedor = new FrmNewProvCli(_proveedor);
            formProveedor.ShowDialog();
        }

        private void Lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _proveedor.IdProveedor = Convert.ToInt32(lista.Rows[e.RowIndex].Cells[0].Value.ToString());
            _proveedor.RazonSocial = lista.Rows[e.RowIndex].Cells[1].Value.ToString();
            _proveedor.CuitCuil = lista.Rows[e.RowIndex].Cells[2].Value.ToString();
            _proveedor.Direccion = lista.Rows[e.RowIndex].Cells[3].Value.ToString();
            _proveedor.Localidad = lista.Rows[e.RowIndex].Cells[4].Value.ToString();
            _proveedor.provincia.DescripcionProvincia = lista.Rows[e.RowIndex].Cells[5].Value.ToString();
            _proveedor.Tel1 = Convert.ToInt32(lista.Rows[e.RowIndex].Cells[6].Value.ToString());
            _proveedor.Tel2 = Convert.ToInt32(lista.Rows[e.RowIndex].Cells[7].Value.ToString());
            _proveedor.Email = lista.Rows[e.RowIndex].Cells[8].Value.ToString();
            _proveedor.Bonificacion = Convert.ToInt32(lista.Rows[e.RowIndex].Cells[9].Value.ToString());
            _proveedor.EstadoProv.Descripcion = lista.Rows[e.RowIndex].Cells[10].Value.ToString();

            FrmNewProvCli formProveedor = new FrmNewProvCli(_proveedor);
            formProveedor.ShowDialog();
        }
    }
}
