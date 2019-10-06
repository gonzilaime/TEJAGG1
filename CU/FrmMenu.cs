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
    public partial class FrmMenu : Form
    {
        public TipoPerfil _tipoPerfil;
        public FrmMenu(int _perfil)
        {
            InitializeComponent();
            _tipoPerfil = new TipoPerfil();
            _tipoPerfil.IdPerfil = _perfil;
        }

        private void TimerHoraYFecha_Tick(object sender, EventArgs e)
        {
            
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void LblHora_Click(object sender, EventArgs e)
        {

        }

        private void LblFecha_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
