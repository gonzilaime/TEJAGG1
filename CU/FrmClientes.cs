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
    public partial class FrmClientes : Form
    {
        public Clientes _cliente;
        public Provincia _provincia;
        public TipoPerfil tipoPerfil;
        public Usuario usuario;


        public FrmClientes(int _perfil)
        {
            InitializeComponent();
            tipoPerfil = new TipoPerfil();
            tipoPerfil.IdPerfil = _perfil;
            _cliente = new Clientes();
            _provincia = new Provincia();

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (tipoPerfil.IdPerfil == 1)
            {

            
                FrmNewModClientes formulario = new FrmNewModClientes(_cliente=null);
            formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador",
                   "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listar()
        {
            listaCliente.Rows.Clear();
            var cadena = txtBuscar.Text.ToString();
            var clienteObtenido = _cliente.obtenerCliente(cadena);

            foreach (var reg in clienteObtenido)
            {
                listaCliente.Rows.Add(reg.IdCliente, reg.CuitCuil, reg.RazonSocial, reg.Direccion, reg.Localidad, reg.provincia.DescripcionProvincia, reg.Tel1, reg.Tel2, reg.Email, reg.estado.DescripcionEstado);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (tipoPerfil.IdPerfil == 1)
            {
                _cliente.IdCliente = Convert.ToInt32(listaCliente.CurrentRow.Cells[0].Value.ToString());
                _cliente.CuitCuil = listaCliente.CurrentRow.Cells[1].Value.ToString();
                _cliente.RazonSocial = listaCliente.CurrentRow.Cells[2].Value.ToString();
                _cliente.Direccion = listaCliente.CurrentRow.Cells[3].Value.ToString();
                _cliente.Localidad = listaCliente.CurrentRow.Cells[4].Value.ToString();
                _cliente.provincia.DescripcionProvincia = listaCliente.CurrentRow.Cells[5].Value.ToString();
                _cliente.Tel1 = listaCliente.CurrentRow.Cells[6].Value.ToString();
                _cliente.Tel2 = listaCliente.CurrentRow.Cells[7].Value.ToString();
                _cliente.Email = listaCliente.CurrentRow.Cells[8].Value.ToString();
                _cliente.estado.DescripcionEstado = listaCliente.CurrentRow.Cells[9].Value.ToString();

                FrmNewModClientes formulario = new FrmNewModClientes(_cliente);
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador", 
                    "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

       

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            listar();
        }

     

        private void ListaCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tipoPerfil.IdPerfil == 1)
            {

                _cliente.IdCliente = Convert.ToInt32(listaCliente.Rows[e.RowIndex].Cells[0].Value.ToString());
                _cliente.CuitCuil = listaCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
                _cliente.RazonSocial = listaCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
                _cliente.Direccion = listaCliente.Rows[e.RowIndex].Cells[3].Value.ToString();
                _cliente.Localidad = listaCliente.Rows[e.RowIndex].Cells[4].Value.ToString();
                _cliente.provincia.DescripcionProvincia = listaCliente.Rows[e.RowIndex].Cells[5].Value.ToString();
                _cliente.Tel1 = listaCliente.Rows[e.RowIndex].Cells[6].Value.ToString();
                _cliente.Tel2 = listaCliente.Rows[e.RowIndex].Cells[7].Value.ToString();
                _cliente.Email = listaCliente.Rows[e.RowIndex].Cells[8].Value.ToString();
                _cliente.estado.DescripcionEstado = listaCliente.Rows[e.RowIndex].Cells[9].Value.ToString();


                FrmNewModClientes formProveedor = new FrmNewModClientes(_cliente);
                formProveedor.ShowDialog();
                listar();
            }
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador",
                    "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            listar();
        }

        private void FrmClientes_Activated(object sender, EventArgs e)
        {
            listar();
        }
    }
}
