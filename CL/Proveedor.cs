﻿using System;
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
        

        public int Tel1 { get; set; }
        public int Tel2 { get; set; }

        public string Email { get; set; }
        public int Bonificacion { get; set; }
        public int IdEstado { get; set; }
       

        public Provincia provincia;
        public EstadoProveedor EstadoProv;

        public Proveedor()
        {
            EstadoProv = new EstadoProveedor();
            provincia = new Provincia();
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
                conn= database.Abrir();
                cmd.Connection = conn;
                

                if (ejecutar == "ALTA")
                {
                    cmd.CommandText = "INSERT INTO Proveedores (CuitCuil, RazonSocial, Direccion, Localidad, IdProvincia, Tel1, Tel2, Bonificacion, Email, IdEstado) " +
                                       "VALUES " + "('" + proveedor.CuitCuil + "', '" + proveedor.RazonSocial + "' , '" + proveedor.Direccion + "', '"
                                        + proveedor.Localidad + "', " + proveedor.provincia.IdProvincia + ", " + proveedor.Tel1 + ", " + proveedor.Tel2 + ", "
                                        + proveedor.Bonificacion + ", '" + proveedor.Email + "' , " + proveedor.EstadoProv.IdEstadoProveedor + ")";

                }

                        /***************
                        **MODIFICACION**
                        ***************/

                else if (ejecutar == "MODIFICAR")
                {
                    cmd.CommandText = "UPDATE Proveedores SET CuitCuil = '" + proveedor.CuitCuil + "'," + " RazonSocial = '" + proveedor.RazonSocial + "'," + " Direccion = '" + proveedor.Direccion +
                                      " Localidad = '," + proveedor.Localidad + "'," + " IdProvincia = '" + proveedor.provincia.IdProvincia + "', " + " Tel1 = " + proveedor.Tel1 + "," + " Tel2 = "
                                      + proveedor.Tel2 + ", " + " Bonificacion = " + proveedor.Bonificacion + "," + " Email = '" + proveedor.Email + "'," + " IdEstado = " + proveedor.EstadoProv.IdEstadoProveedor 
                                      +" WHERE IdProveedor =" + proveedor.IdProveedor;
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
        public List<Proveedor> obtenerProveedores()
        {
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var baseDatos = new Conectar();
            var listaProveedores = new List<Proveedor>();

            try
            {
                conn = baseDatos.Abrir();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT t1.*, t2.DescripcionProvincia FROM Proveedores as t1"
                                + " INNER JOIN Provincia as t2 " 
                                + "ON t1.IdProvincia=t2.IdProvincia "
                                + "INNER JOIN EstadoProv as t3 "
                                + "ON t1.IdEstado = t3.IdEstadoProveedor "
                                + "ORDER BY t1.RazonSocial";
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
                    proveedor.Tel1 = (int)registroObtenido["Tel1"];
                    proveedor.Tel2 = (int)registroObtenido["Tel2"];
                    proveedor.Email = (string)registroObtenido["Email"];
                    proveedor.Bonificacion = (int)registroObtenido["Bonificacion"];
                    proveedor.EstadoProv.IdEstadoProveedor = (int)registroObtenido["IdEstado"];
                    proveedor.provincia.DescripcionProvincia = (string)registroObtenido["DescripcionProvincia"];

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