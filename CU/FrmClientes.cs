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
                listar(txtBuscar.Text, "t1.RazonSocial");
                chequear();
            }
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador",
                   "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listar(string cadena, string condicion)
        {
            Clientes cli = new Clientes();
            listaCliente.Rows.Clear();
            var clienteObtenido = cli.obtenerCliente(cadena, condicion);

            foreach (var reg in clienteObtenido)
            {
                listaCliente.Rows.Add(reg.IdCliente, reg.CuitCuil, reg.RazonSocial, reg.Direccion, reg.Localidad, reg.provincia.DescripcionProvincia, reg.Tel1, reg.Tel2, reg.Email, reg.estado.DescripcionEstado);
            }
        }
        public void chequear()
        {
            if(radioBtnActivos.Checked == true)
            {
                listar("Activo", "t3.DescripcionEstado");
            }    
            else if (radioBtnInactivos.Checked == true)
            {
                listar("Inactivo", "t3.DescripcionEstado");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (tipoPerfil.IdPerfil == 1)
            {
                Clientes cliente = new Clientes();
                cliente.IdCliente = Convert.ToInt32(listaCliente.CurrentRow.Cells[0].Value.ToString());
                cliente.CuitCuil = listaCliente.CurrentRow.Cells[1].Value.ToString();
                cliente.RazonSocial = listaCliente.CurrentRow.Cells[2].Value.ToString();
                cliente.Direccion = listaCliente.CurrentRow.Cells[3].Value.ToString();
                cliente.Localidad = listaCliente.CurrentRow.Cells[4].Value.ToString();
                cliente.provincia.DescripcionProvincia = listaCliente.CurrentRow.Cells[5].Value.ToString();
                cliente.Tel1 = listaCliente.CurrentRow.Cells[6].Value.ToString();
                cliente.Tel2 = listaCliente.CurrentRow.Cells[7].Value.ToString();
                cliente.Email = listaCliente.CurrentRow.Cells[8].Value.ToString();
                cliente.estado.DescripcionEstado = listaCliente.CurrentRow.Cells[9].Value.ToString();

                FrmNewModClientes formulario = new FrmNewModClientes(cliente);
                formulario.ShowDialog();
                listar(txtBuscar.Text, "t1.RazonSocial" );
                chequear();
            }
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador", 
                    "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

       

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            listar(txtBuscar.Text, "t1.RazonSocial" );
            chequear();
        }

     

        private void ListaCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tipoPerfil.IdPerfil == 1)
            {
                Clientes clientes = new Clientes();
                clientes.IdCliente = Convert.ToInt32(listaCliente.Rows[e.RowIndex].Cells[0].Value.ToString());
                clientes.CuitCuil = listaCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
                clientes.RazonSocial = listaCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
                clientes.Direccion = listaCliente.Rows[e.RowIndex].Cells[3].Value.ToString();
                clientes.Localidad = listaCliente.Rows[e.RowIndex].Cells[4].Value.ToString();
                clientes.provincia.DescripcionProvincia = listaCliente.Rows[e.RowIndex].Cells[5].Value.ToString();
                clientes.Tel1 = listaCliente.Rows[e.RowIndex].Cells[6].Value.ToString();
                clientes.Tel2 = listaCliente.Rows[e.RowIndex].Cells[7].Value.ToString();
                clientes.Email = listaCliente.Rows[e.RowIndex].Cells[8].Value.ToString();
                clientes.estado.DescripcionEstado = listaCliente.Rows[e.RowIndex].Cells[9].Value.ToString();


                FrmNewModClientes formProveedor = new FrmNewModClientes(clientes);
                formProveedor.ShowDialog();
                listar(txtBuscar.Text, "t1.RazonSocial");
                chequear();
            }
            else
            {
                MessageBox.Show("No posee permisos para realizar esta acción, comuníquese con el Administrador",
                    "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            listar(txtBuscar.Text, "t1.RazonSocial");
        }

        private void FrmClientes_Activated(object sender, EventArgs e)
        {
            listar(txtBuscar.Text, "t1.RazonSocial");
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
    }
}
