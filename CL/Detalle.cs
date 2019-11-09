using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CL
{
    public class Detalle
    {
        public int IdDetalle { get; set; }
        public int IdArticulo { get; set; }
        public int IdOrdenDeCompra { get; set; }
        public int Cantidad { get; set; }
        public int Bonificacion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
        public Proveedor proveedor;
        public Articulos articulos;
        public OrdenDeCompra ordenCompra;


        public Detalle()
        {
            proveedor = new Proveedor();
            articulos = new Articulos();
            ordenCompra = new OrdenDeCompra();

        }//constructor
        public bool Alta(Detalle detalle,string accion)
        {
            bool rta;

            try
            {
                var ejecutarSP = new EjecutarSP();
                var parametros = new List<SqlParameter>();
                if (accion == "ALTA")
                { 
                
                    parametros.Add(new SqlParameter("@IdArticulo", detalle.IdArticulo));
                    parametros.Add(new SqlParameter("@Cantidad", detalle.Cantidad));
                    parametros.Add(new SqlParameter("@Bonificacion", detalle.Bonificacion));
                    parametros.Add(new SqlParameter("@PrecioUnitario", detalle.PrecioUnitario));
                    parametros.Add(new SqlParameter("@Nick", UsuarioLogueado.Nick));
                    rta = ejecutarSP.ExecuteNonQuery("InsertarDetalle_SP", parametros);
                }
                else if (accion == "MODIFICAR")
                {
                    parametros.Add(new SqlParameter("@IdArticulo", detalle.IdArticulo));
                    parametros.Add(new SqlParameter("@IdOrdenDeCompra", detalle.IdOrdenDeCompra));
                    parametros.Add(new SqlParameter("@Cantidad", detalle.Cantidad));
                    parametros.Add(new SqlParameter("@Bonificacion", detalle.Bonificacion));
                    parametros.Add(new SqlParameter("@PrecioUnitario", detalle.PrecioUnitario));
                    parametros.Add(new SqlParameter("@Nick", UsuarioLogueado.Nick));
                    rta = ejecutarSP.ExecuteNonQuery("ActualizarDetalle_SP", parametros);
                }
                else
                {
                    parametros.Add(new SqlParameter("@IdDetalle", detalle.IdDetalle));
                    rta = ejecutarSP.ExecuteNonQuery("BorrarDetalle_SP", parametros);
                }



            }//try
            catch (Exception e)
            {
                MessageBox.Show(string.Concat(e.Message, e.StackTrace), "");
                rta = false;
            }//catch

            return rta;

        }//Alta

        public List<Detalle> obtenerDetalleByOrdenDeCompra(int IdOrdenDeCompra)
        {
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var baseDatos = new Conectar();
            var lista = new List<Detalle>();

            try
            {
                conn = baseDatos.Abrir();
                cmd.Connection = conn;
                cmd.CommandText = "Select t3.IdDetalle, t1.IdProveedor, t2.NombreArticulo,t3.Cantidad," +
                                  "t3.Bonificacion,t3.PrecioUnitario, t3.Cantidad* t3.PrecioUnitario Subtotal " +
                                  "FROM Proveedores as t1 " +
                                  "INNER JOIN Articulo as t2 " +
                                  "ON t1.IdProveedor = t2.IdProveedor " +
                                  "INNER JOIN Detalle as t3 " +
                                  "ON t2.IdArticulo = t3.IdArticulo " +
                                  "WHERE t3.IdOrdenDeCompra = " + IdOrdenDeCompra;


                var registroObtenido = cmd.ExecuteReader();
                while (registroObtenido != null && registroObtenido.Read())
                {
                    var detalle = new Detalle();
                    detalle.IdDetalle = (int)registroObtenido["IdDetalle"];
                    detalle.proveedor.IdProveedor = (int)registroObtenido["IdProveedor"];
                    detalle.articulos.NombreArticulo = (string)registroObtenido["NombreArticulo"];
                    detalle.Cantidad = (int)registroObtenido["Cantidad"];
                    detalle.Bonificacion = (int)registroObtenido["Bonificacion"];
                    detalle.PrecioUnitario = (decimal)registroObtenido["PrecioUnitario"];
                    detalle.Subtotal = (decimal)registroObtenido["Subtotal"];

                    lista.Add(detalle);

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




    }//Detalle




}//CL
