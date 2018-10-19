using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoBOCHAS
{
    class Recibo
    {
        DBHelper oDatos;

        public Recibo()
        {
            oDatos = new DBHelper();
        }

        public DataTable ConsultarRecibo(string nroRecibo)
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("select nroRecibo, fechaRecibo, montoPagado from Recibo where nroRecibo = @nroRecibo");
            comando.Parameters.AddWithValue("@nroRecibo", nroRecibo);
            tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }
    }
}
