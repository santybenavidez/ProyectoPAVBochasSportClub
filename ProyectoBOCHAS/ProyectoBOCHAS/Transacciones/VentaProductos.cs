using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoBOCHAS
{
    class VentaProductos
    {
        DBHelper oDatos;
        List<SqlCommand> lista = new List<SqlCommand>();
        string numRecibo;


        public VentaProductos()
        {
            oDatos = new DBHelper();

        }

        public DataTable buscarProductos()
        {
            DataTable tabla = oDatos.ConsultarTabla("Productos");
            return tabla;
        }

        public string buscarTipo(string producto) {
            SqlCommand comando = new SqlCommand("select t.nombre from TipoProducto t join Productos p on  p.idTipoProducto=t.idTipoProducto where p.descripcion=@producto");
            comando.Parameters.AddWithValue("@producto", producto);
            DataTable tablaTipos = new DataTable();
            tablaTipos = oDatos.ConsultaSQL(comando);
            return tablaTipos.Rows[0][0].ToString();
        }

        public DataTable buscarPrecioProducto(string nombreProducto)
        {
            SqlCommand comando = new SqlCommand("select precioUnitario from Productos where descripcion =@nombre");
            comando.Parameters.AddWithValue("@nombre", nombreProducto);
            DataTable tablaPrecios = oDatos.ConsultaSQL(comando);
            return tablaPrecios;
        }

        public DataTable buscarSocios(string id)
        {
            DataTable tabla = new DataTable();
            string sql = "select * from socios s where s.idSocio = @id";
            SqlCommand consulta = new SqlCommand(sql);
            consulta.Parameters.AddWithValue("@id", id);
            tabla = oDatos.ConsultaSQL(consulta);
            return tabla;
        }

        public DataTable buscarIdProducto(string descripcion)
        {
            SqlCommand comando = new SqlCommand("select idProductos from Productos where descripcion=@desc");
            comando.Parameters.AddWithValue("@desc", descripcion);
            DataTable tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }

        public DataTable buscarIdTipoProducto(string nombreTipo) {
            SqlCommand comando = new SqlCommand("select idTipoProducto from TipoProducto where nombre=@nombre");
            comando.Parameters.AddWithValue("@nombre", nombreTipo);
            DataTable tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }

        public string nRecibo()//actualiza la variable numRecibo al ultimo valor nroRecibo de la tabla Recibo con el metodo encabezado()
        {
            SqlCommand comando = new SqlCommand("select IDENT_CURRENT('Recibo')");
            DataTable tabla = oDatos.ConsultaSQL(comando);
            string nr = tabla.Rows[0][0].ToString();
            numRecibo = nr;
            return nr;
            

        }

        public void encabezado(string monto, string descripcion, string nombreCliente, string domicilioCliente) //agrega a recibo
        {
            SqlCommand comando = new SqlCommand("INSERT INTO Recibo (fechaRecibo, montoPagado, descripcion, nombreCliente, domicilioCliente) VALUES (GETDATE(), @monto, @descripcion, @nombreCliente, @domiciliocliente)");
            comando.Parameters.AddWithValue("@monto", monto);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@nombreCliente", nombreCliente);
            comando.Parameters.AddWithValue("@domicilioCliente", domicilioCliente);
            lista.Add(comando);
        }

        public void detalle(int idProductos, int idTipoProducto)//agrega a VentaProductos 
        {
            nRecibo();
            SqlCommand comando = new SqlCommand("INSERT INTO VentaProductos(nroRecibo,idProductos,idTipoProducto) VALUES (@numeroRecibo,@idProducto,@idTipoProducto)");
            comando.Parameters.AddWithValue("@numeroRecibo", numRecibo);
            comando.Parameters.AddWithValue("@idProducto",idProductos);
            comando.Parameters.AddWithValue("@idTipoProducto", idTipoProducto);
            lista.Add(comando);
        }

        public bool realizarTransaccion()
        {
            bool bandera = oDatos.TransaccionSQL(lista);
            lista = new List<SqlCommand>();
            return bandera;

        }


    }
}
