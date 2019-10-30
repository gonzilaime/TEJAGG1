using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CL
{
    public class EjecutarSP
    {

        public Boolean ExecuteNonQuery(string stored, List<SqlParameter> parametros)
        {
            var BaseDeDatos = new Conectar();
            using (SqlConnection conexion = BaseDeDatos.Abrir())
            {
                bool retornar = true;
                conexion.Open();
                var comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = stored;

                try
                {
                    foreach (var p in parametros)
                    {
                        comando.Parameters.Add(p);
                    }
                    comando.ExecuteNonQuery();

                    retornar = true;
                }
                catch (SqlException e)
                {
                    retornar = false;
                }
                finally
                {
                    conexion.Close();
                }
                return retornar;
            }


        }//ExecuteNonQuery


    }//EjecutarSP
}//CL
