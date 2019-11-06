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
                query.CommandType = CommandType.StoredProcedure;

                if (ejecutar == "ALTA")
                {
                    query.CommandText = "prc_AltaArticulo";
                    query.Parameters.Add(new SqlParameter("@NombreArticulo", articulo.NombreArticulo));
                    query.Parameters.Add(new SqlParameter("@Bonificacion", articulo.Bonificacion));
                    query.Parameters.Add(new SqlParameter("@Precio", articulo.Precio));
                    query.Parameters.Add(new SqlParameter("@IdProveedor", articulo.proveedor.IdProveedor));
                    query.Parameters.Add(new SqlParameter("@Nick", UsuarioLogueado.Nick));

                }//IF

                /***************
                 * MODIFICAR ***
                 ***************/

                else if (ejecutar == "MODIFICAR")
                {
                    query.CommandText = "prc_ModificarArticulo";
                    query.Parameters.Add(new SqlParameter("@IdArticulo", articulo.IdArticulo));
                    query.Parameters.Add(new SqlParameter("@NombreArticulo", articulo.NombreArticulo));
                    query.Parameters.Add(new SqlParameter("@Bonificacion", articulo.Bonificacion));
                    query.Parameters.Add(new SqlParameter("@Precio", articulo.Precio));
                    query.Parameters.Add(new SqlParameter("@IdProveedor", articulo.proveedor.IdProveedor));
                    query.Parameters.Add(new SqlParameter("@Nick", UsuarioLogueado.Nick));

                        
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



    }//Articulos



}
