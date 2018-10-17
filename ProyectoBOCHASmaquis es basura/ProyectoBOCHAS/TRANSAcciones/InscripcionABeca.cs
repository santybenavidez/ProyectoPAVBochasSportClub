using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoBOCHAS
{
    class InscripcionABeca
    {
        DBHelper oDatos;
        List<SqlCommand> lista = new List<SqlCommand>();
        string nroRecibo;

        public InscripcionABeca()
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

        public DataTable buscarBecas()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT B.idBeca, B.nombre FROM Becas B";
            SqlCommand comando = new SqlCommand(sql);
            tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }

        public DataTable buscarIdBeca(string nombre)
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("select b.idBeca, b.nombre from becas b where b.nombre = @nombre");
            comando.Parameters.AddWithValue("@nombre", nombre);
            tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }

        public void EncabezadoInscripcionBeca()
        {
            SqlCommand comando = new SqlCommand("insert into recibo (fechaRecibo, montoPagado, descripcion) values (GETDATE(), 0, 'Comprobante Beca')");
            lista.Add(comando);
            comando = new SqlCommand("select IDENT_CURRENT('recibo')+1"); //VERDADERA magia que trae el identity para no romper todo
            DataTable tabla = new DataTable();
            tabla = oDatos.ConsultaSQL(comando);
            nroRecibo = tabla.Rows[0][0].ToString(); //nro de recibo que va a tener el insert despues de ejecutar
        }

        public void DetalleInscripcionBeca(int idBeca, int idSocio, string fechaInicio, string fechaFin)
        {
            SqlCommand comando = new SqlCommand("insert into becasxsocios values (@idBeca, @idSocio, @fechaInicio, @fechaFin, @nroRecibo)");
            comando.Parameters.AddWithValue("@idBeca", idBeca);
            comando.Parameters.AddWithValue("@idSocio", idSocio);
            comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            comando.Parameters.AddWithValue("@fechaFin", fechaFin);
            comando.Parameters.AddWithValue("@nroRecibo", nroRecibo);
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
