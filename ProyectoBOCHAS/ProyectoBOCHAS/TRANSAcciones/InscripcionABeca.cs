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

        public DataTable buscarDisciplinas()
        {
            DataTable tabla = new DataTable();
            tabla = oDatos.ConsultarTabla("Disciplinas");
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

    }
}
