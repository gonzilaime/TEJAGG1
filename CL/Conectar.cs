using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CL
{
    public class Conectar
    {
        public string servidor;
        public string databaseName;
        public string usuario;
        public string cadenaConexion;

        public Conectar()
        {

            try
            {
                
                servidor = "EQUIPO-01";
                databaseName = "TEJAGG";
                usuario = "EQUIPO-01\\Usuario";
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Concat(e.Message, e.StackTrace), "");
                MessageBox.Show("Fallo de la conexión");
            }

        }

        public SqlConnection Abrir()
        {
            cadenaConexion = ("Server =" + servidor + "; DataBase =" + databaseName + "; Trusted_Connection=Yes");

            var conn = new SqlConnection(cadenaConexion);
            conn.Open();
            return conn;
        }
    }
}
