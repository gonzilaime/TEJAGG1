using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CL
{
    public class Provincia
    {

        public int IdProvincia{ get; set; }
        public string DescripcionProvincia { get; set; }


        public static bool combo(ComboBox combo, string campo1, string campo2, string tabla)
        {
            bool rta;
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var conectar = new Conectar();
            var sql = "SELECT " + campo1 + " , " + campo2 + " FROM " + tabla + " ORDER BY '" + campo1 + "'";

            try
            {
                conn = conectar.Abrir();
                cmd.Connection = conn;
                var comando = new SqlCommand(sql, conn);

                var da = new SqlDataAdapter(comando);
                var ds = new DataSet();

                da.Fill(ds);

                combo.DataSource = ds.Tables[0];
                combo.DisplayMember = ds.Tables[0].Columns[0].Caption;

                rta = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el ComboBox: " + ex.ToString());
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
