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
    public class Clientes
    {
        public int IdCliente { get; set; }
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

        public Estado estado;

        public Clientes()
        {
            provincia = new Provincia();
            estado = new Estado();
        }

        /***************************************************
        *Método para dar de alta o modificar un Cliente**
        ***************************************************/

        public bool Accion(Clientes cliente, string ejecutar)
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
                    cmd.CommandText = "prc_AltaCliente";

                    cmd.Parameters.Add(new SqlParameter("@CuitCuil", cliente.CuitCuil));
                    cmd.Parameters.Add(new SqlParameter("@RazonSocial", cliente.RazonSocial));
                    cmd.Parameters.Add(new SqlParameter("@Direccion", cliente.Direccion));
                    cmd.Parameters.Add(new SqlParameter("@Localidad", cliente.Localidad));
                    cmd.Parameters.Add(new SqlParameter("@IdProvincia", cliente.provincia.IdProvincia));
                    cmd.Parameters.Add(new SqlParameter("@Tel1", cliente.Tel1));
                    cmd.Parameters.Add(new SqlParameter("@Tel2", cliente.Tel2));
                    cmd.Parameters.Add(new SqlParameter("@Email", cliente.Email));
                    cmd.Parameters.Add(new SqlParameter("@IdEstado", cliente.estado.IdEstado));
                    cmd.Parameters.Add(new SqlParameter("@Nick", UsuarioLogueado.Nick));
                }

                /***************
                **MODIFICACION**
                ***************/

                else if (ejecutar == "MODIFICAR")
                {
                    cmd.CommandText = "prc_ModificarClientes";
                    cmd.Parameters.Add(new SqlParameter("@IdCliente", cliente.IdCliente));
                    cmd.Parameters.Add(new SqlParameter("@CuitCuil", cliente.CuitCuil));
                    cmd.Parameters.Add(new SqlParameter("@RazonSocial", cliente.RazonSocial));
                    cmd.Parameters.Add(new SqlParameter("@Direccion", cliente.Direccion));
                    cmd.Parameters.Add(new SqlParameter("@Localidad", cliente.Localidad));
                    cmd.Parameters.Add(new SqlParameter("@IdProvincia", cliente.provincia.IdProvincia));
                    cmd.Parameters.Add(new SqlParameter("@Tel1", cliente.Tel1));
                    cmd.Parameters.Add(new SqlParameter("@Tel2", cliente.Tel2));
                    cmd.Parameters.Add(new SqlParameter("@Email", cliente.Email));
                    cmd.Parameters.Add(new SqlParameter("@IdEstado", cliente.estado.IdEstado));
                    cmd.Parameters.Add(new SqlParameter("@Nick", UsuarioLogueado.Nick));
                }

                cmd.ExecuteNonQuery();
                rta = true;
            }//try
            catch (Exception e)
            {
                MessageBox.Show(string.Concat(e.Message, e.StackTrace), "");
                rta = false;
            }//catch
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Dispose();
                    conn.Close();
                }
            }//finally
            return rta;

        }//Accion
        public List<Clientes> obtenerCliente(string cadenacliente)
        {
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var baseDatos = new Conectar();
            var listaClientes = new List<Clientes>();

            try
            {
                conn = baseDatos.Abrir();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT t1.*,t2.DescripcionProvincia, t3.DescripcionEstado FROM Clientes as t1"
                                + " INNER JOIN Provincia as t2 "
                                + "ON t1.IdProvincia=t2.IdProvincia "
                                + " INNER JOIN Estado as t3 "
                                + " ON t1.IdEstado = t3.IdEstado "
                                + " WHERE t1.RazonSocial like '%" + cadenacliente + "%'"
                                + "ORDER BY t1.RazonSocial";
                var clientesObtenido = cmd.ExecuteReader();
                while (clientesObtenido != null && clientesObtenido.Read())
                {
                    var cliente = new Clientes();
                    cliente.IdCliente = (int)clientesObtenido["IdCliente"];
                    cliente.CuitCuil = (string)clientesObtenido["CuitCuil"];
                    cliente.RazonSocial = (string)clientesObtenido["RazonSocial"];
                    cliente.Direccion = (string)clientesObtenido["Direccion"];
                    cliente.Localidad = (string)clientesObtenido["Localidad"];
                    cliente.provincia.IdProvincia = (int)clientesObtenido["IdProvincia"];
                    cliente.provincia.DescripcionProvincia = (string)clientesObtenido["DescripcionProvincia"];
                    cliente.Tel1 = (string)clientesObtenido["Tel1"];
                    cliente.Tel2 = (string)clientesObtenido["Tel2"];
                    cliente.Email = (string)clientesObtenido["Email"];
                    cliente.estado.IdEstado = (int)clientesObtenido["IdEstado"];
                    cliente.estado.DescripcionEstado = (string)clientesObtenido["DescripcionEstado"];

                    listaClientes.Add(cliente);

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

            return listaClientes;
        }//obtenerProveedores
    }


}

