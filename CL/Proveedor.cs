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
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string CuitCuil { get; set; }
        public string RazonSocial { get; set; }

        public string Direccion { get; set; }
        public string Localidad { get; set; }
        
        public int IdProvincia { get; set; }

        public string Tel1 { get; set; }

        public string Tel2 { get; set; }

        public string Email { get; set; }

        public int IdEstado { get; set; }

        public Provincia provincia;

        public Estado Estado;

        public Proveedor()
        {
            provincia = new Provincia();
            Estado = new Estado();
        }

        /***************************************************
         *Método para dar de alta o modificar un Proveedor**
         ***************************************************/
        public bool Accion(Proveedor proveedor, string ejecutar)
        {
            var conn = new SqlConnection();
            var database = new Conectar();
            var cmd = new SqlCommand();
            bool rta;

            /********
             **ALTA**
             ********/
            try
            {
                conn = database.Abrir();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                if (ejecutar == "ALTA")
                {

                    cmd.CommandText = "prc_AltaProveedor";

                    cmd.Parameters.Add(new SqlParameter("@CuitCuil", proveedor.CuitCuil));
                    cmd.Parameters.Add(new SqlParameter("@RazonSocial", proveedor.RazonSocial));
                    cmd.Parameters.Add(new SqlParameter("@Direccion", proveedor.Direccion));
                    cmd.Parameters.Add(new SqlParameter("@Localidad", proveedor.Localidad));
                    cmd.Parameters.Add(new SqlParameter("@IdProvincia", proveedor.provincia.IdProvincia));
                    cmd.Parameters.Add(new SqlParameter("@Tel1", proveedor.Tel1));
                    cmd.Parameters.Add(new SqlParameter("@Tel2", proveedor.Tel2));
                    cmd.Parameters.Add(new SqlParameter("@Email", proveedor.Email));
                    cmd.Parameters.Add(new SqlParameter("@IdEstado", proveedor.Estado.IdEstado));
                    cmd.Parameters.Add(new SqlParameter("@Nick", UsuarioLogueado.Nick));

                }

                /***************
                **MODIFICACION**
                ***************/

                else if (ejecutar == "MODIFICAR")
                {
                    cmd.CommandText = "prc_ModificarProveedor";
                    cmd.Parameters.Add(new SqlParameter("@IdProveedor", proveedor.IdProveedor));
                    cmd.Parameters.Add(new SqlParameter("@CuitCuil", proveedor.CuitCuil));
                    cmd.Parameters.Add(new SqlParameter("@RazonSocial", proveedor.RazonSocial));
                    cmd.Parameters.Add(new SqlParameter("@Direccion", proveedor.Direccion));
                    cmd.Parameters.Add(new SqlParameter("@Localidad", proveedor.Localidad));
                    cmd.Parameters.Add(new SqlParameter("@IdProvincia", proveedor.provincia.IdProvincia));
                    cmd.Parameters.Add(new SqlParameter("@Tel1", proveedor.Tel1));
                    cmd.Parameters.Add(new SqlParameter("@Tel2", proveedor.Tel2));
                    cmd.Parameters.Add(new SqlParameter("@Email", proveedor.Email));
                    cmd.Parameters.Add(new SqlParameter("@IdEstado", proveedor.Estado.IdEstado));
                    cmd.Parameters.Add(new SqlParameter("@Nick", UsuarioLogueado.Nick));
                }

                cmd.ExecuteNonQuery();
                rta = true;
            }//try
            catch(Exception e)
            {
                MessageBox.Show(string.Concat(e.Message, e.StackTrace), "");
                rta = false;
            }//catch
            finally
            {
                if(conn.State== ConnectionState.Open)
                { 
                    conn.Dispose();
                    conn.Close();
                }
            }//finally
            return rta;

        }//Accion

        //====================================================
        //Método para llenar ListBox con registros de la BBDD
        //====================================================
        public List<Proveedor> obtenerProveedores(string condicion)
        {
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var baseDatos = new Conectar();
            var listaProveedores = new List<Proveedor>();

            try
            {
                conn = baseDatos.Abrir();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT t1.*,t2.DescripcionProvincia, t3.DescripcionEstado FROM Proveedores as t1"
                                + " INNER JOIN Provincia as t2 " 
                                + "ON t1.IdProvincia=t2.IdProvincia "
                                + " INNER JOIN Estado as t3 "
                                + " ON t1.IdEstado = t3.IdEstado "
                                + " WHERE t3.DescripcionEstado= '" + condicion + "' "
                                + "ORDER BY t1.IdProveedor ";
                var registroObtenido = cmd.ExecuteReader();
                while(registroObtenido != null && registroObtenido.Read())
                {
                    var proveedor = new Proveedor();
                    proveedor.IdProveedor = (int)registroObtenido["IdProveedor"];
                    proveedor.CuitCuil = (string)registroObtenido["CuitCuil"];
                    proveedor.RazonSocial = (string)registroObtenido["RazonSocial"];
                    proveedor.Direccion = (string)registroObtenido["Direccion"];
                    proveedor.Localidad = (string)registroObtenido["Localidad"];
                    proveedor.provincia.IdProvincia = (int)registroObtenido["IdProvincia"];
                    proveedor.provincia.DescripcionProvincia = (string)registroObtenido["DescripcionProvincia"];
                    proveedor.Tel1 = (string)registroObtenido["Tel1"];
                    proveedor.Tel2 = (string)registroObtenido["Tel2"];
                    proveedor.Email = (string)registroObtenido["Email"];
                    proveedor.Estado.IdEstado = (int)registroObtenido["IdEstado"];
                    proveedor.Estado.DescripcionEstado = (string)registroObtenido["DescripcionEstado"];

                    listaProveedores.Add(proveedor);

                }//while

            }//try
            catch (Exception e)
            {
                MessageBox.Show(string.Concat(e.Message, e.StackTrace), "");
                MessageBox.Show("Falla al cargar lista");
            }//catch
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Dispose();
                    conn.Close();
                }
            }//finally

            return listaProveedores;
        }//obtenerProveedores

        public List<Proveedor> obtenerProveedoresPorRazon(string cadena)
        {
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var baseDatos = new Conectar();
            var listaProveedores = new List<Proveedor>();

            try
            {
                conn = baseDatos.Abrir();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT t1.*,t2.DescripcionProvincia, t3.DescripcionEstado FROM Proveedores as t1"
                                + " INNER JOIN Provincia as t2"
                                + " ON t1.IdProvincia=t2.IdProvincia"
                                + " INNER JOIN Estado as t3"
                                + " ON t1.IdEstado = t3.IdEstado"
                                + " WHERE t1.RazonSocial like '%" + cadena + "%'"
                                + " ORDER BY t1.IdProveedor";
                var registroObtenido = cmd.ExecuteReader();
                while (registroObtenido != null && registroObtenido.Read())
                {
                    var proveedor = new Proveedor();
                    proveedor.IdProveedor = (int)registroObtenido["IdProveedor"];
                    proveedor.CuitCuil = (string)registroObtenido["CuitCuil"];
                    proveedor.RazonSocial = (string)registroObtenido["RazonSocial"];
                    proveedor.Direccion = (string)registroObtenido["Direccion"];
                    proveedor.Localidad = (string)registroObtenido["Localidad"];
                    proveedor.provincia.IdProvincia = (int)registroObtenido["IdProvincia"];
                    proveedor.provincia.DescripcionProvincia = (string)registroObtenido["DescripcionProvincia"];
                    proveedor.Tel1 = (string)registroObtenido["Tel1"];
                    proveedor.Tel2 = (string)registroObtenido["Tel2"];
                    proveedor.Email = (string)registroObtenido["Email"];
                    proveedor.Estado.IdEstado = (int)registroObtenido["IdEstado"];
                    proveedor.Estado.DescripcionEstado = (string)registroObtenido["DescripcionEstado"];

                    listaProveedores.Add(proveedor);

                }//while

            }//try
            catch (Exception e)
            {
                MessageBox.Show(string.Concat(e.Message, e.StackTrace), "");
                MessageBox.Show("Falla al cargar lista");
            }//catch
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Dispose();
                    conn.Close();
                }
            }//finally

            return listaProveedores;
        }//obtenerProveedores

    }
}
