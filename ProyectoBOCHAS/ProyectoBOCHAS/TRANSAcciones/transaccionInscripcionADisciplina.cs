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
            SqlCommand comando = new SqlCommand("INSERT INTO Recibo VALUES (GETDATE(), @monto, @descripcion)");
            comando.Parameters.AddWithValue("@monto", monto);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            lista.Add(comando);

        }

        public void detalleInscripcionADisciplina(DataGridView grilla)
        {
           for (int i=0; i<grilla.Rows.Count; i++)
           {
                SqlCommand comando = new SqlCommand("INSERT INTO CategoriasXSocios VALUES (@idSocio, @idCategoria, 'S', @idDisciplina)");
               DataTable tabla1 = new DataTable();
               DataTable tabla2 = new DataTable();
               tabla1 = buscarIdDisciplina(grilla.Rows[i].Cells["disciplina"].Value.ToString());
               tabla2 = buscarIdCategoria(grilla.Rows[i].Cells["categoria"].Value.ToString());
               int idSocio = Convert.ToInt32(grilla.Rows[i].Cells["idSocio"].Value.ToString());
               int idDisciplina = Convert.ToInt32(tabla1.Rows[0][0]);
               int idCategoria = Convert.ToInt32(tabla2.Rows[0][0]); 
                comando.Parameters.AddWithValue("@idSocio", idSocio);
                comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                comando.Parameters.AddWithValue("@idDisciplina", idDisciplina);
                lista.Add(comando);   
               
           }
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
            SqlCommand comando = new SqlCommand("SELECT C.idCategoria FROM Disciplinas C WHERE C.nombre = @nombreCategoria");
            comando.Parameters.AddWithValue("@nombreCategoria", nombreCategoria);
            tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }

        public void realizarTransaccion()
        {
            //pantalla.prepararTransaccion();
            oDatos.TransaccionSQL(lista);
            lista = new List<SqlCommand>();
        }
    } 
    
}
