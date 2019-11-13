using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CL
{
    public class OrdenDeCompra
    {
        public int IdOrdenDeCompra { get; set; }
        public int IdProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public int IdEstadoCompra { get; set; }
        public decimal Monto { get; set; }

        public Proveedor proveedor;
        public EstadoOrdenCompra _estado;



        public OrdenDeCompra()
        {
            _estado = new EstadoOrdenCompra();
            proveedor = new Proveedor();


        }//constructor

        /******************************************
         *Método para generar una orden de compra *
         ******************************************/

        public bool Accion(OrdenDeCompra orden, string ejecutar)
        {
            bool rta;

            try
            {
                var ejecutarSP = new EjecutarSP();
                var parametros = new List<SqlParameter>();

                if(ejecutar == "ALTA")
                {
                    parametros.Add(new SqlParameter("@IdProveedor", orden.proveedor.IdProveedor));
                    parametros.Add(new SqlParameter("@IdEstadoOrdenCompra", orden._estado.IdEstadoOrdenCompra));
                    parametros.Add(new SqlParameter("@Nick", UsuarioLogueado.Nick));
                    rta = ejecutarSP.ExecuteNonQuery("GenerarOrdenDeCompra_SP", parametros);
                }else
                {
                    parametros.Add(new SqlParameter("@IdOrdenDeCompra", orden.IdOrdenDeCompra));
                    parametros.Add(new SqlParameter("@IdEstadoOrdenCompra", orden._estado.IdEstadoOrdenCompra));
                    parametros.Add(new SqlParameter("@Nick", UsuarioLogueado.Nick));
                    rta = ejecutarSP.ExecuteNonQuery("ActualizarOrdenDeCompra_SP", parametros);
                }

            }//try
            catch (Exception e)
            {
                MessageBox.Show(string.Concat(e.Message, e.StackTrace), "");
                rta = false;
            }//catch

            return rta;

        }//Accion

        /*******************************************
         * Método para listar Ordenes de de compra**
         *******************************************/

        public List<OrdenDeCompra> obtenerCompras(string cadena,string condicion)
        {
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var baseDatos = new Conectar();
            var listaCompras = new List<OrdenDeCompra>();

            try
            {
                conn = baseDatos.Abrir();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT t1.IdOrdenDeCompra, t1.Fecha, t1.IdProveedor, t2.RazonSocial,t1.IdEstadoOrdenCompra, "
                                 + "t3.DescripcionOrdenCompra, SUM(t4.Cantidad * t4.PrecioUnitario - t4.Cantidad * t4.PrecioUnitario * t4.Bonificacion / 100) Monto "
                                 + "FROM OrdenDeCompra as t1 "
                                 + "INNER JOIN Proveedores as t2 "
                                 + "ON t1.IdProveedor = t2.IdProveedor "
                                 + "INNER JOIN EstadoOrdenCompra as t3 "
                                 + "ON t1.IdEstadoOrdenCompra = t3.IdEstadoOrdenCompra "
                                 + "INNER JOIN Detalle as t4 "
                                 + "ON t1.IdOrdenDeCompra = t4.IdOrdenDeCompra "
                                 + "WHERE " + condicion + " like '%" + cadena +"%' "
                                 + "GROUP BY t1.IdOrdenDeCompra, t1.Fecha, t1.IdProveedor," 
                                 + "t2.RazonSocial, t1.IdEstadoOrdenCompra, t3.DescripcionOrdenCompra "
                                 + "ORDER BY t1.IdOrdenDeCompra";

                var registroObtenido = cmd.ExecuteReader();
                while (registroObtenido != null && registroObtenido.Read())
                {
                    var ordenDeCompra = new OrdenDeCompra();

                    ordenDeCompra.IdOrdenDeCompra = (int)registroObtenido["IdOrdenDeCompra"];
                    ordenDeCompra.Fecha = (DateTime)registroObtenido["Fecha"];
                    ordenDeCompra.proveedor.IdProveedor = (int)registroObtenido["IdProveedor"];
                    ordenDeCompra.proveedor.RazonSocial = (string)registroObtenido["RazonSocial"];
                    ordenDeCompra._estado.IdEstadoOrdenCompra = (int)registroObtenido["IdEstadoOrdenCompra"];
                    ordenDeCompra._estado.DescripcionEstadoOrdenCompra = (string)registroObtenido["DescripcionOrdenCompra"];
                    ordenDeCompra.Monto = (decimal)registroObtenido["Monto"];
                    listaCompras.Add(ordenDeCompra);

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

            return listaCompras;

        }//obtenerCompras

    }//OrdenDeCompra
}//CL
