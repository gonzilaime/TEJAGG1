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
        public string NickUsu { get; set; }
        public string Contraseña { get; set; }

        public int IdPerfil { get; set; }
        public int NroPerfil;

        public TipoPerfil perfil;

        public Encriptar encriptar;
        public Usuario()
        {
            perfil = new TipoPerfil();
            encriptar = new Encriptar();
        }
        
        public bool login(string NickUsu, string Contraseña)
        {
            var conn = new SqlConnection();
            var comando = new SqlCommand();
            var baseDatos = new Conectar();
            bool rta;
            

            try
            {
                conn = baseDatos.Abrir();
                comando.Connection = conn;
                SqlCommand cmd = new SqlCommand("SELECT NickUsu, Contraseña, IdPerfil FROM Usuario WHERE NickUsu = @NickUsu AND Contraseña = @Contraseña", conn);
                cmd.Parameters.AddWithValue("NickUsu", NickUsu);
                cmd.Parameters.AddWithValue("Contraseña", Contraseña);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);



                DataTable dt = new DataTable();
                sda.Fill(dt);
                rta = true;
               
                if (dt.Rows.Count == 1)
                {
                    string rowUser = dt.Rows[0]["NickUsu"].ToString();
                    Usuario.CacheUser.Nick = rowUser;
                    UsuarioLogueado.Nick = rowUser;

                    if (Convert.ToInt32(dt.Rows[0][2]) == 1)
                    {
                        NroPerfil = 1;
                        Usuario.CacheUser.IdPerfil = "Administrador";
                        rta = true;
                    }
                    else if (Convert.ToInt32(dt.Rows[0][2]) == 2)
                    {
                        NroPerfil = 2;
                        Usuario.CacheUser.IdPerfil = "Usuario";
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
            public static class CacheUser
        {
            public static string Nick { get; set; } 
            public static string IdPerfil { get; set; }
        }

        public bool AgregarUsuario(Usuario Usuario)
        {
            //string cadenaEncriptada = encriptar.GetMD5(Contraseña);

            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var basedeDatos = new Conectar();
            bool rta;

            try
            {
                conn = basedeDatos.Abrir();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "prc_AltaUsuario";
                cmd.Parameters.Add(new SqlParameter("@NickUsu", Usuario.NickUsu));
                cmd.Parameters.Add(new SqlParameter("@Contraseña", Usuario.Contraseña));
                cmd.Parameters.Add(new SqlParameter("@IdPerfil", Usuario.perfil.IdPerfil));
                cmd.Parameters.Add(new SqlParameter("@Nick", UsuarioLogueado.Nick));
                cmd.ExecuteNonQuery();
                rta = true;

            }
            catch (Exception e)
            {
                MessageBox.Show(string.Concat(e.Message, e.StackTrace), "");
                rta = false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                }

            }
            return rta;
        }
    }
}
