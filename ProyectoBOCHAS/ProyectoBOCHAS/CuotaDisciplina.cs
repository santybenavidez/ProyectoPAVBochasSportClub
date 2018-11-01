using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoBOCHAS
{
    class CuotaDisciplina
    {
        DBHelper oDatos;
        List<SqlCommand> lista = new List<SqlCommand>();
        string numero;

        public CuotaDisciplina()
        {
            oDatos = new DBHelper();
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

        public DataTable buscarSocios(string id)
        {
            DataTable tabla = new DataTable();
            string sql = "select * from socios s where s.idSocio = @id";
            SqlCommand consulta = new SqlCommand(sql);
            consulta.Parameters.AddWithValue("@id", id);
            tabla = oDatos.ConsultaSQL(consulta);
            return tabla;
        }

        public DataTable buscarPrecioCuota(string nombreCategoria, string nombreDisciplina)
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("SELECT C.idCategoria, C.nombre, C.precioCuota from categorias c join disciplinas d ON(D.idDisciplina = C.idDisciplina) WHERE D.nombre = @nombreDisciplina and c.nombre = @nombreCategoria");
            comando.Parameters.AddWithValue("@nombreDisciplina", nombreDisciplina);
            comando.Parameters.AddWithValue("@nombreCategoria", nombreCategoria);
            tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }

        public bool validarCuota(int idSocio, int idCategoria, int idDisciplina, string mes) // reviso que no este cargada una cuota para ese socio, ese mes, en esa categoria
        {
            bool bandera = false;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("select * from CuotaDisciplina where idSocio = @idSocio and idCategoria = @idCategoria and idDisciplina = @idDisciplina and mes = @mes");
            comando.Parameters.AddWithValue("@idSocio", idSocio);
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);
            comando.Parameters.AddWithValue("@idDisciplina", idDisciplina);
            comando.Parameters.AddWithValue("@mes", mes);
            tabla = oDatos.ConsultaSQL(comando);
            if (tabla.Rows.Count > 0)
                bandera = true;
            return bandera;
        }

        public bool validarValidez(int idSocio, int idCategoria, int idDisciplina) //reviso que este cargado en esa categoria el socio
        {
            bool bandera = true;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("select * from categoriasxsocios where idSocio = @idSocio and idDisciplina = @idDisciplina and idCategoria = @idCategoria");
            comando.Parameters.AddWithValue("@idSocio", idSocio);
            comando.Parameters.AddWithValue("@idDisciplina", idDisciplina);
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);
            tabla = oDatos.ConsultaSQL(comando);
            if (tabla.Rows.Count > 0)
            {
                bandera = false;
            }
            return bandera;
        }

        public string nroRecibo()
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("select ident_current('recibo')");
            tabla = oDatos.ConsultaSQL(comando);
            numero = tabla.Rows[0][0].ToString();
            return numero;
        }

        public void nroRecibo2() //porque todo me chupa un huevo ya
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("select ident_current('recibo')");
            tabla = oDatos.ConsultaSQL(comando);
            numero = tabla.Rows[0][0].ToString();
        }

        public DataTable buscarIdDisciplina(string nombreDisciplina)
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("SELECT D.idDisciplina FROM Disciplinas D WHERE D.nombre = @nombreDisciplina");
            comando.Parameters.AddWithValue("@nombreDisciplina", nombreDisciplina);
            tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }

        public DataTable buscarIdCategoria(string nombreCategoria, int idDisciplina)
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("SELECT C.idCategoria FROM categorias C WHERE C.nombre = @nombreCategoria and c.idDisciplina = @idDisciplina");
            comando.Parameters.AddWithValue("@nombreCategoria", nombreCategoria);
            comando.Parameters.AddWithValue("@idDisciplina", idDisciplina);
            tabla = oDatos.ConsultaSQL(comando);
            return tabla;
        }

        public void encabezado(string monto, string descripcion, string nombreCliente, string domicilioCliente)
        {
            SqlCommand comando = new SqlCommand("INSERT INTO Recibo (fechaRecibo, montoPagado, descripcion, nombreCliente, domicilioCliente) VALUES (GETDATE(), @monto, @descripcion, @nombreCliente, @domiciliocliente)");
            comando.Parameters.AddWithValue("@monto", monto);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@nombreCliente", nombreCliente);
            comando.Parameters.AddWithValue("@domicilioCliente", domicilioCliente);
            lista.Add(comando);
        }

        public void detalle(int idSocio, int idDisciplina, int idCategoria, string mes)
        {
            nroRecibo2();
            SqlCommand comando = new SqlCommand("insert into cuotaDisciplina (nroRecibo, idSocio, idCategoria, idDisciplina, mes) values (@nroRecibo, @idSocio, @idCategoria, @idDisciplina, @mes)");
            comando.Parameters.AddWithValue("@nroRecibo", numero);
            comando.Parameters.AddWithValue("idSocio", idSocio);
            comando.Parameters.AddWithValue("@idDisciplina", idDisciplina);
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);
            comando.Parameters.AddWithValue("@mes", mes);
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
