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
            if (_tipoPerfil.IdPerfil == 1)
            { 
                FrmNewProvCli formulario = new FrmNewProvCli(_proveedor=null);
                formulario.ShowDialog();

                chequear();
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
            chequear();

        }

        public void listar(string cadena)
        {
            Proveedor pr = new Proveedor();
            listaProveedor.Rows.Clear();
            var proveedorObtenido = pr.obtenerProveedores(cadena);

            foreach (var reg in proveedorObtenido)
            {
                listaProveedor.Rows.Add(reg.IdProveedor, reg.CuitCuil, reg.RazonSocial, reg.Direccion,
                    reg.Localidad, reg.provincia.DescripcionProvincia, reg.Tel1, reg.Tel2, reg.Email,
                    reg.Estado.DescripcionEstado);
            }
        }

        public void listarProv()
        {
            Proveedor pr = new Proveedor();
            listaProveedor.Rows.Clear();
            var cadena = txtBuscar.Text.ToString();
            var proveedorObtenido = pr.obtenerProveedoresPorRazon(cadena);

            foreach (var reg in proveedorObtenido)
            {
                listaProveedor.Rows.Add(reg.IdProveedor, reg.CuitCuil, reg.RazonSocial, reg.Direccion,
                    reg.Localidad, reg.provincia.DescripcionProvincia, reg.Tel1, reg.Tel2, reg.Email,
                    reg.Estado.DescripcionEstado);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (_tipoPerfil.IdPerfil == 1)
            {
                Proveedor prov = new Proveedor();
                prov.IdProveedor = Convert.ToInt32(listaProveedor.CurrentRow.Cells[0].Value.ToString());
                prov.CuitCuil = listaProveedor.CurrentRow.Cells[1].Value.ToString();
                prov.RazonSocial = listaProveedor.CurrentRow.Cells[2].Value.ToString();
                prov.Direccion = listaProveedor.CurrentRow.Cells[3].Value.ToString();
                prov.Localidad = listaProveedor.CurrentRow.Cells[4].Value.ToString();
                prov.provincia.DescripcionProvincia = listaProveedor.CurrentRow.Cells[5].Value.ToString();
                prov.Tel1 = listaProveedor.CurrentRow.Cells[6].Value.ToString();
                prov.Tel2 = listaProveedor.CurrentRow.Cells[7].Value.ToString();
                prov.Email = listaProveedor.CurrentRow.Cells[8].Value.ToString();
                prov.Estado.DescripcionEstado = listaProveedor.CurrentRow.Cells[9].Value.ToString();


                Form formProveedor = new FrmNewProvCli(prov);
                formProveedor.ShowDialog();
                chequear();
            }
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ListaProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_tipoPerfil.IdPerfil == 1)
            {
                Proveedor proveedor = new Proveedor();
                proveedor.IdProveedor = Convert.ToInt32(listaProveedor.Rows[e.RowIndex].Cells[0].Value.ToString());
                proveedor.CuitCuil = listaProveedor.Rows[e.RowIndex].Cells[1].Value.ToString();
                proveedor.RazonSocial = listaProveedor.Rows[e.RowIndex].Cells[2].Value.ToString();
                proveedor.Direccion = listaProveedor.Rows[e.RowIndex].Cells[3].Value.ToString();
                proveedor.Localidad = listaProveedor.Rows[e.RowIndex].Cells[4].Value.ToString();
                proveedor.provincia.DescripcionProvincia = listaProveedor.Rows[e.RowIndex].Cells[5].Value.ToString();
                proveedor.Tel1 = listaProveedor.Rows[e.RowIndex].Cells[6].Value.ToString();
                proveedor.Tel2 = listaProveedor.Rows[e.RowIndex].Cells[7].Value.ToString();
                proveedor.Email = listaProveedor.Rows[e.RowIndex].Cells[8].Value.ToString();
                proveedor.Estado.DescripcionEstado = listaProveedor.Rows[e.RowIndex].Cells[9].Value.ToString();

                FrmNewProvCli formProveedor = new FrmNewProvCli(proveedor);
                formProveedor.ShowDialog();
                chequear();
            }
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void chequear()
        {
            if (radioBtnActivos.Checked == true)

            {
                listar("Activo");
            }
            else if (radioBtnInactivos.Checked == true)
            {
                listar("Inactivo");
            }
            else
            {
                listarProv();
            }
        }


        private void frmProveedores_Activated(object sender, EventArgs e)
        {
            chequear();
        }

        private void RadioBtnActivos_CheckedChanged(object sender, EventArgs e)
        {
            chequear();
        }

        private void RadioBtnInactivos_CheckedChanged(object sender, EventArgs e)
        {
            chequear();
        }

        private void RadioBtnInactivos_Click(object sender, EventArgs e)
        {
            chequear();
        }

        private void RadioBtnActivos_Click(object sender, EventArgs e)
        {
            chequear();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            listarProv();
        }
    }
}
