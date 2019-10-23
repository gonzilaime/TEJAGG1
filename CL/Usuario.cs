using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace CL
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nick { get; set; }
        public string Contraseña { get; set; }

        public int IdPerfil { get; set; }
        public int NroPerfil;

        public TipoPerfil perfil;

        public Usuario()
        {
            perfil = new TipoPerfil();

        }
        
        public bool login(string Nick, string Contraseña)
        {
            var conn = new SqlConnection();
            var comando = new SqlCommand();
            var baseDatos = new Conectar();
            bool rta;
            

            try
            {
               
                conn = baseDatos.Abrir();
                comando.Connection = conn;
                SqlCommand cmd = new SqlCommand("SELECT Nick, Contraseña, IdPerfil FROM Usuario WHERE Nick = @Nick AND Contraseña = @Contraseña", conn);
                cmd.Parameters.AddWithValue("Nick", Nick);
                cmd.Parameters.AddWithValue("Contraseña", Contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                
                DataTable dt = new DataTable();
                sda.Fill(dt);
                rta = true;
               
                if (dt.Rows.Count == 1)
                {
                    if (Convert.ToInt32(dt.Rows[0][2]) == 1)
                    {
                        NroPerfil = 1;
                        
                        rta = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][2]) == 2)
                    {
                        NroPerfil = 2;
                        rta = true;
                    }
                    
                   
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rta = false;
                }
            }//try
            catch(Exception e)
            {
                MessageBox.Show(String.Concat(e.Message, e.StackTrace), "");
                rta = false;
            }//catch
            finally
            {
                conn.Close();
                conn.Dispose();

            }//finally
            return rta;
        }

    }
}
