using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CL
{
    public class Articulos
    {
        public int IdArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public int Bonificacion { get; set; }
        public int PrecioEntero { get; set; }
        public int PrecioDecimal { get; set; }
        public decimal Precio { get; set; }
        public int IdProveedor {get; set;}

        public Proveedor proveedor;

        public Articulos()
        {
            proveedor = new Proveedor();
        }//constructor

        /**===================================================
        ** Accion Alta, o modificación de un Articulo
        *======================================================*/

        public bool AccionArticulo (Articulos articulo,string ejecutar)
        {
            var conexion = new SqlConnection();
            var TEJAGG = new Conectar();
            var query = new SqlCommand();
            bool rta;

            /***********
             * ALTA*****
             ***********/
            try
            {
                conexion = TEJAGG.Abrir();
                query.Connection = conexion;

                if (ejecutar == "ALTA")
                {
                    query.CommandText = "INSERT INTO Articulo "
                        + "VALUES " + "('" + articulo.NombreArticulo + "'," + articulo.Bonificacion + "," + articulo.PrecioEntero + "." + articulo.PrecioDecimal + "," + articulo.proveedor.IdProveedor + ")";

                }//IF

                /***************
                 * MODIFICAR ***
                 ***************/

                else if (ejecutar == "MODIFICAR")
                {
                    query.CommandText = "UPDATE Articulo "
                        + "SET NombreArticulo = '" + articulo.NombreArticulo + "',"
                        + " Bonificacion = " + articulo.Bonificacion + ","
                        + " Precio = " + articulo.PrecioEntero + "." + articulo.PrecioDecimal + ","
                        + " IdProveedor = " + articulo.proveedor.IdProveedor
                        + " WHERE IdArticulo = " + articulo.IdArticulo;

                }

                query.ExecuteNonQuery();
                rta = true;
            }//try
            catch(Exception e)
            {
                MessageBox.Show(string.Concat(e.Message, e.StackTrace), "");
                rta = false;
            }//catch
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Dispose();
                    conexion.Close();
                }//IF

            }//finally

            return rta;

        }//AccionArticulo


        public List<Articulos> obtenerArticulos(string filtro)
        {
            var conexion = new SqlConnection();
            var TEJAGG = new Conectar();
            var query = new SqlCommand();
            var articulos = new List<Articulos>();

            try
            {
                conexion = TEJAGG.Abrir();
                query.Connection = conexion;
                query.CommandText = "SELECT t1.*,t2.RazonSocial "
                    + "FROM Articulo as t1"
                    + " INNER JOIN Proveedores as t2"
                    + " ON t1.IdProveedor=t2.IdProveedor"
                    + " WHERE t1.NombreArticulo LIKE"
                    + " '%" + filtro + "%'"
                    + " ORDER BY t2.RazonSocial";

                var articulosObtenidos = query.ExecuteReader();

                while (articulosObtenidos != null && articulosObtenidos.Read())
                {
                    var articulo = new Articulos();
                    articulo.IdArticulo = (int)articulosObtenidos["IdArticulo"];
                    articulo.NombreArticulo = (string)articulosObtenidos["NombreArticulo"];
                    articulo.Bonificacion = (int)articulosObtenidos["Bonificacion"];
                    articulo.Precio = (decimal)articulosObtenidos["Precio"];
                    articulo.proveedor.IdProveedor = (int)articulosObtenidos["IdProveedor"];
                    articulo.proveedor.RazonSocial = (string)articulosObtenidos["RazonSocial"];

                    articulos.Add(articulo);

                }//while
            }//try

            catch (Exception e)
            {
                MessageBox.Show(string.Concat(e.Message, e.StackTrace), "");
                MessageBox.Show("Falla al cargar lista de artículos");
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Dispose();
                    conexion.Close();
                }
            }

            return articulos;

        }//obtenerArticulos

        public List<Articulos> obtenerArticulosByProveedor(int IdProveedor)
        {
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var baseDatos = new Conectar();
            var lista = new List<Articulos>();

            try
            {
                conn = baseDatos.Abrir();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT t1.IdArticulo,t1.NombreArticulo,t1.Bonificacion,t1.Precio,t2.IdProveedor,t2.RazonSocial"
                                + " FROM Articulo as t1 "
                                + "INNER JOIN Proveedores as t2 "
                                + " ON t1.IdProveedor = t2.IdProveedor "
                                + " WHERE t2.IdProveedor = " + IdProveedor;
                

                var registroObtenido = cmd.ExecuteReader();
                while (registroObtenido != null && registroObtenido.Read())
                {
                    var articulo = new Articulos();

                    articulo.IdArticulo = (int)registroObtenido["IdArticulo"];
                    articulo.NombreArticulo = (string)registroObtenido["NombreArticulo"];
                    articulo.Bonificacion = (int)registroObtenido["Bonificacion"];
                    articulo.Precio = (decimal)registroObtenido["Precio"];
                    articulo.proveedor.IdProveedor = (int)registroObtenido["IdProveedor"];
                    articulo.proveedor.RazonSocial = (string)registroObtenido["RazonSocial"];

                    lista.Add(articulo);

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

            return lista;

        }//obtenerArticulosByProveedor


    }//Articulos



}
