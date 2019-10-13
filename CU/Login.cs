using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CL;
using System.Windows.Forms;

namespace CU
{
    public partial class Login : Form
    {

        public Usuario usuario;
        public FrmMenu menu;
        public FormMenu formMenu;
        public Menu _menu;
              
        public Login()
        {
            InitializeComponent();
            usuario = new Usuario();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;

            }
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.Black;

            }
        }

        private void TxtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = true;

            }
        }

        private void TxtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = false;
            }

            }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if(txtPass.Text == "" || txtUser.Text == "")
            {
                MessageBox.Show("Ingresar usuario y contraeseña", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }else
            {
                if (usuario.login(this.txtUser.Text, this.txtPass.Text))
                {
                    this.Hide();
                    //FrmMenu menu = new FrmMenu(usuario.NroPerfil);
                    //menu.Show();
                    FormMenu formMenu = new FormMenu(usuario.NroPerfil);
                    formMenu.Show();

                }
                else
                {
                    txtUser.Text = "";
                    txtPass.Text = "";
                    return;
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

       
}
