using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace ProyectoBOCHAS
{
    class transaccionInscripcionADisciplina
    {
        DBHelper oDatos;
        List<SqlCommand> lista = new List<SqlCommand>();

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

        public void encabezadoInscripcionADisciplina(string monto, string descripcion)
        {
            SqlCommand comando = new SqlCommand("INSERT INTO Recibo (fechaRecibo, montoPagado, descripcion) VALUES (GETDATE(), @monto, @descripcion)");
            comando.Parameters.AddWithValue("@monto", monto);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            lista.Add(comando);
        }

        public void detalleInscripcionADisciplina(int idSocio, int idDisciplina, int idCategoria)
        {
            SqlCommand comando = new SqlCommand("INSERT INTO CategoriasXSocios VALUES (@idSocio, @idDisciplina, 'S', @idCategoria)");
            comando.Parameters.AddWithValue("@idSocio", idSocio);
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);
            comando.Parameters.AddWithValue("@idDisciplina", idDisciplina);
            lista.Add(comando);
        }

        public DataTable buscarIdDisciplina(string nombreDisciplina)
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("SELECT D.idDisciplina FROM Disciplinas D WHERE D.nombre = @nombreDisciplina");
            comando.Parameters.AddWithValue("@nombreDisciplina", nombreDisciplina);
            tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }

        public DataTable buscarIdCategoria(string nombreCategoria)
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("SELECT C.idCategoria FROM categorias C WHERE C.nombre = @nombreCategoria");
            comando.Parameters.AddWithValue("@nombreCategoria", nombreCategoria);
            tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }

        public bool realizarTransaccion()
        {
            bool bandera = oDatos.TransaccionSQL(lista);
            lista = new List<SqlCommand>();
            return bandera;
        }

        public string nroRecibo()
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("select ident_current('recibo')");
            tabla = oDatos.ConsultaSQL(comando);
            string numero = tabla.Rows[0][0].ToString();
            return numero;
        }
    } 
    
}
