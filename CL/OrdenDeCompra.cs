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

                    rta = ejecutarSP.ExecuteNonQuery("GenerarOrdenDeCompra_SP", parametros);
                }else
                {
                    parametros.Add(new SqlParameter("@IdOrdenDeCompra", orden.IdOrdenDeCompra));
                    parametros.Add(new SqlParameter("@IdEstadoOrdenCompra", orden._estado.IdEstadoOrdenCompra));

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

        public List<OrdenDeCompra> obtenerCompras(string cadena)
        {
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var baseDatos = new Conectar();
            var listaCompras = new List<OrdenDeCompra>();

            try
            {
                conn = baseDatos.Abrir();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT t1.IdOrdenDeCompra,t1.Fecha,t1.IdProveedor,t2.RazonSocial,t1.IdEstadoOrdenCompra,t3.DescripcionOrdenCompra"
                                + " FROM OrdenDeCompra as t1"
                                + " INNER JOIN Proveedores as t2"
                                + " ON t1.IdProveedor=t2.IdProveedor"
                                + " INNER JOIN EstadoOrdenCompra as t3"
                                + " ON t1.IdEstadoOrdenCompra = t3.IdEstadoOrdenCompra WHERE t2.RazonSocial like '%" + cadena + "%'"
                                + "ORDER BY t1.IdOrdenDeCompra ";

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
