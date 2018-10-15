using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ProyectoBOCHAS
{
    class transaccionInscripcionADisciplina
    {
        DBHelper oDatos;
        
        public transaccionInscripcionADisciplina()
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

        public DataTable buscarCategoriasXDisciplinas(string nombreDisciplina)
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("SELECT C.idCategoria, C.nombre, C.precioInscripcion FROM Categorias C JOIN Disciplinas D ON(D.idDisciplina = C.idDisciplina) WHERE D.nombre = @nombreDisciplina");
            comando.Parameters.AddWithValue("@nombreDisciplina", nombreDisciplina);
            tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }

        public DataTable buscarPrecioInscripcion(string nombreCategoria, string nombreDisciplina)
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("SELECT C.idCategoria, C.nombre, C.precioInscripcion from categorias c join disciplinas d ON(D.idDisciplina = C.idDisciplina) WHERE D.nombre = @nombreDisciplina and c.nombre = @nombreCategoria");
            comando.Parameters.AddWithValue("@nombreDisciplina", nombreDisciplina);
            comando.Parameters.AddWithValue("@nombreCategoria", nombreCategoria);
            tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }
    }
}
