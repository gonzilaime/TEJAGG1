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
    public partial class FormMenu : Form
    {

        
        public FormMenu()
        {
            InitializeComponent();
        }



        private void BtnArticulos_Click(object sender, EventArgs e)
        {
            panelArticulos.Visible = true;
            panelClientes.Visible = false;
            panelProveedores.Visible = false;
            panelCompras.Visible = false;
            panelInicio.Visible = false;
            btnArt.Visible = true;
            btnArticulos.Visible = false;
            btnProv.Visible = false;
            btnProveedores.Visible = true;
            btnClientes.Visible = true;
            btnCli.Visible = false;
            btnCompras.Visible = true;
            btnCom.Visible = false;
            btnInicio.Visible = false;
            btnIni.Visible = true;

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            panelArticulos.Visible = false;
            panelClientes.Visible = true;
            panelProveedores.Visible = false;
            panelCompras.Visible = false;
            panelInicio.Visible = false;
            btnCli.Visible = true;
            btnClientes.Visible = false;
            btnProv.Visible = false;
            //btnCli.Enabled = false;
            btnProveedores.Visible = true;
            btnArticulos.Visible = true;
            btnArt.Visible = false;
            btnCompras.Visible = true;
            btnCom.Visible = false;
            btnInicio.Visible = false;
            btnIni.Visible = true;
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmProveedores());
            panelArticulos.Visible = false;
            panelClientes.Visible = false;
            panelProveedores.Visible = true;
            panelCompras.Visible = false;
            panelInicio.Visible = false;

            btnProv.Visible = true;
            btnProveedores.Visible = false;
            btnClientes.Visible = true;
            btnCli.Visible = false;
            btnArticulos.Visible = true;
            btnArt.Visible = false;
            btnCompras.Visible = true;
            btnCom.Visible = false;
            btnIni.Visible = true;
            btnInicio.Visible = false;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnProv_Click(object sender, EventArgs e)
        {

        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            panelArticulos.Visible = false;
            panelClientes.Visible = false;
            panelProveedores.Visible = false;
            panelInicio.Visible = false;
            panelCompras.Visible = true;
            btnProv.Visible = false;
            btnProveedores.Visible = true;
            btnClientes.Visible = true;
            btnCli.Visible = false;
            btnArticulos.Visible = true;
            btnArt.Visible = false;
            btnCom.Visible = true;
            btnInicio.Visible = false;
            btnIni.Visible = true;


        }

        private void BtnCompras_MouseMove(object sender, MouseEventArgs e)
        {
            //panelSubMenuCompras.Visible = true;
        }

        private void BtnCompras_MouseLeave(object sender, EventArgs e)
        {
            // panelSubMenuCompras.Visible = false;
        }

        private void BtnCompras_MouseUp(object sender, MouseEventArgs e)
        {
            //panelSubMenuCompras.Visible = true;
        }
        //Metodo para abrir forms dentro del panel contenedor del menu
        private void AbrirFormHijo(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            panelArticulos.Visible = false;
            panelClientes.Visible = false;
            panelProveedores.Visible = false;
            panelCompras.Visible = false;
            btnArt.Visible = false;
            btnArticulos.Visible = true;
            btnProv.Visible = false;
            btnProveedores.Visible = true;
            btnClientes.Visible = true;
            btnCli.Visible = false;
            btnCompras.Visible = true;
            btnCom.Visible = false;

        }

        private void BtnIni_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmMenu());

            panelInicio.Visible = true;
            btnInicio.Visible = true;
            btnIni.Visible = false;
            btnProv.Visible = false;
            btnCli.Visible = false;
            btnArt.Visible = false;
            btnCom.Visible = false;
            btnProveedores.Visible = true;
            btnClientes.Visible = true;
            btnArticulos.Visible = true;
            btnCompras.Visible = true;
            btnIni.Visible = false;
            panelArticulos.Visible = false;
            panelCompras.Visible = false;
            panelProveedores.Visible = false;
            panelClientes.Visible = false;


        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelArriba_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMenu_Load_1(object sender, EventArgs e)
        {
            BtnIni_Click(null, e);
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;

        }

        private void BtnNormal_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnNormal.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }
    }
}
