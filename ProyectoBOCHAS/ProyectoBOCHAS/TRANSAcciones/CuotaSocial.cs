using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoBOCHAS
{
    class CuotaSocial
    {
  
        DBHelper oDatos;
        List<SqlCommand> lista = new List<SqlCommand>();
        string nroRecibo;


        public CuotaSocial()
        {
            oDatos = new DBHelper();

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

        public string EncabezadoCuotaSocial(int nroSocio, string nombreCliente, string domicilioCliente, int montoPagado)
        {
            SqlCommand comando = new SqlCommand("insert into recibo (fechaRecibo, montoPagado, descripcion, nombreCliente, domicilioCliente) values (GETDATE(), @montoPagado, 'Comprobante pago Cuota Social', @nombreCliente, @domicilioCliente)");
            comando.Parameters.AddWithValue("@nroSocio", nroSocio);
            comando.Parameters.AddWithValue("@nombreCliente", nombreCliente);
            comando.Parameters.AddWithValue("@domicilioCliente", domicilioCliente);
            comando.Parameters.AddWithValue("@montoPagado", montoPagado);
            lista.Add(comando);
            comando = new SqlCommand("select IDENT_CURRENT('recibo')+1"); //VERDADERA magia que trae el identity para no romper todo
            DataTable tabla = new DataTable();
            tabla = oDatos.ConsultaSQL(comando);
            nroRecibo = tabla.Rows[0][0].ToString(); //nro de recibo que va a tener el insert despues de ejecutar
            return nroRecibo;
        }

        public void DetalleCuotaSocial(int nroSocio, string mes)
        {
            SqlCommand comando = new SqlCommand("INSERT INTO CuotaSocial(nroRecibo, idSocio, mes) VALUES (@nroRecibo, @nroSocio, @mes)");
            comando.Parameters.AddWithValue("@nroSocio", nroSocio);
            comando.Parameters.AddWithValue("@nroRecibo", nroRecibo);
            comando.Parameters.AddWithValue("@mes", mes);
            lista.Add(comando);
        }
        public bool realizarTransaccion()
        {
            bool bandera = oDatos.TransaccionSQL(lista);
            lista = new List<SqlCommand>();
            return bandera;
        }

        public string numRecibo()
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("select ident_current('recibo')");
            tabla = oDatos.ConsultaSQL(comando);
            string numero = tabla.Rows[0][0].ToString();
            return numero;
        }
    }
}
