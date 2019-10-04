using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using CL;
namespace CL
{
    public class Validacion
    {
        public void soloNumeros(KeyPressEventArgs ex) // validacion para text box solo numeros
        {
            try
            {
                if (char.IsNumber(ex.KeyChar))
                {
                    ex.Handled = false;
                }
                else if (Char.IsControl(ex.KeyChar))
                {
                    ex.Handled = false;
                }
                else
                {
                    ex.Handled = true;
                    MessageBox.Show("Solo se permiten numeros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Concat(e.Message, e.StackTrace), "");
            }
        }
        public void soloLetras(KeyPressEventArgs ex) // validacion para text box solo letras 
        {
            try
            {
                if (char.IsLetter(ex.KeyChar))
                {
                    ex.Handled = false;
                }
                else if (char.IsControl(ex.KeyChar))
                {
                    ex.Handled = false;
                }
                else if (char.IsSeparator(ex.KeyChar))

                {
                    ex.Handled = false;
                }
                else
                {
                    ex.Handled = true;
                    MessageBox.Show("Solo se permiten letras", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Concat(e.Message, e.StackTrace), "");
            }

        }
        public bool existeRazonSocial(string Razon) // validacion de DNI ya existente 
        {
            var con = new SqlConnection();
            var comando = new SqlCommand();
            var baseDato = new Conectar();
            SqlDataReader reader;
            bool rta = false;

            try
            {
                con = baseDato.Abrir();
                SqlCommand cmd = new SqlCommand(" select * from Proveedores where RazonSocial = " + Razon + "", con);
                cmd.Parameters.AddWithValue("Proveedores", Razon);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    rta = true;
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Concat(e.Message, e.StackTrace), "");
                rta = false;
            }
            return rta;


        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}