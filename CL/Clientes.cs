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

        public Estado Estado;

        public Clientes()
        {
            provincia = new Provincia();
        }

        /***************************************************
        *Método para dar de alta o modificar un Cliente**
        ***************************************************/

        public bool Accion(Proveedor cliente, string ejecutar)
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

                if (ejecutar == "ALTA")
                {
                    cmd.CommandText = "INSERT INTO Clientes "
                        + "VALUES " + "('" + cliente.CuitCuil + "','" + cliente.RazonSocial + "','" + cliente.Direccion + "','"
                        + cliente.Localidad + "'," + cliente.provincia.IdProvincia + ",'" + cliente.Tel1 + "','" + cliente.Tel2 + "','"
                        + cliente.Email + "'," + cliente.Estado.IdEstado + ")";

                }

                /***************
                **MODIFICACION**
                ***************/

                else if (ejecutar == "MODIFICAR")
                {
                    cmd.CommandText = "UPDATE Proveedores SET CuitCuil = '" + cliente.CuitCuil + "',"
                        + " RazonSocial = '" + cliente.RazonSocial + "', " + "Direccion = '" + cliente.Direccion + "',"
                        + " Localidad = '" + cliente.Localidad + "', " + " IdProvincia = " + cliente.provincia.IdProvincia + ", "
                        + " Tel1 = '" + cliente.Tel1 + "'," + " Tel2 = '" + cliente.Tel2 + "' ," + " Email = '" + cliente.Email + "' ,"
                        + " IdEstado = " + cliente.Estado.IdEstado + ","
                        + " WHERE IdProveedor = " + cliente.IdProveedor;
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
        public List<Proveedor> obtenerCliente(string cadena)
        {
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var baseDatos = new Conectar();
            var listaProveedores = new List<Proveedor>();

            try
            {
                conn = baseDatos.Abrir();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT t1.*,t2.DescripcionProvincia, t3.DescripcionEstado FROM Cliente as t1"
                                + " INNER JOIN Provincia as t2 "
                                + "ON t1.IdProvincia=t2.IdProvincia "
                                + " INNER JOIN Estado as t3 "
                                + " ON t1.IdEstado = t3.IdEstado "
                                + " WHERE t1.RazonSocial like '%" + cadena + "%'"
                                + "ORDER BY t1.RazonSocial";
                var registroObtenido = cmd.ExecuteReader();
                while (registroObtenido != null && registroObtenido.Read())
                {
                    var cliente = new Clientes();
                    cliente.IdCliente = (int)registroObtenido["IdCliente"];
                    cliente.CuitCuil = (string)registroObtenido["CuitCuil"];
                    cliente.RazonSocial = (string)registroObtenido["RazonSocial"];
                    cliente.Direccion = (string)registroObtenido["Direccion"];
                    cliente.Localidad = (string)registroObtenido["Localidad"];
                    cliente.provincia.IdProvincia = (int)registroObtenido["IdProvincia"];
                    cliente.provincia.DescripcionProvincia = (string)registroObtenido["DescripcionProvincia"];
                    cliente.Tel1 = (string)registroObtenido["Tel1"];
                    cliente.Tel2 = (string)registroObtenido["Tel2"];
                    cliente.Email = (string)registroObtenido["Email"];
                    cliente.Estado.IdEstado = (int)registroObtenido["IdEstado"];
                    cliente.Estado.DescripcionEstado = (string)registroObtenido["DescripcionEstado"];

                    //listaClientes.Add(cliente);

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

