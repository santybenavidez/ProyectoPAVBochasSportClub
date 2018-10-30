using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBOCHAS
{
    public partial class frmInscripcionADisciplina : Form
    {
        Validadores validadores = new Validadores();
        transaccionInscripcionADisciplina transaccion = new transaccionInscripcionADisciplina();

        private bool bandera = false;
        private bool bandera2 = false;

        public frmInscripcionADisciplina()
        {
            InitializeComponent();
        }

        private void frmInscripcionADisciplina_Load(object sender, EventArgs e)
        {
            cmbCategoria.Enabled = false;
            llenarComboDisciplinas();
        }

        private void button1_Click(object sender, EventArgs e) //boton buscador de socios
        {
           if (validadores.ValidarTxt(txtNroSocio))
           {
               DataTable tabla = new DataTable();
               tabla = transaccion.buscarSocios(txtNroSocio.Text);
               if (tabla.Rows.Count > 0)
                   txtNombreSocio.Text = tabla.Rows[0][1].ToString() + " " + tabla.Rows[0][2].ToString();
               else
                   MessageBox.Show("No existe ningun socio con este numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
           }
        }

        private void cmbDisciplinas_SelectedIndexChanged(object sender, EventArgs e) //controla la carga de la categoria dependiendo de la disciplina
        {
            if (bandera)
            {
                cmbCategoria.Enabled = true;
                cargarComboCategorias();
            }
        }

        private void llenarComboDisciplinas() //carga el combo disciplinas, la bandera es porque se activaba el metodo de cambio antes de que ponga bien los valores y daba excepcion de sql
        {
            DataTable tabla = new DataTable(); 
            tabla = transaccion.buscarDisciplinas();
            cmbDisciplinas.DataSource = tabla;
            cmbDisciplinas.ValueMember = tabla.Columns[0].ColumnName.ToString();
            bandera = true;
            cmbDisciplinas.DisplayMember = tabla.Columns[1].ColumnName.ToString();
        }

        private void cargarComboCategorias() //carga las categorias de la disciplina seleccionada
        {
            DataTable tabla = new DataTable();
            tabla = transaccion.buscarCategoriasXDisciplinas(cmbDisciplinas.Text);
            cmbCategoria.DataSource = tabla;
            cmbCategoria.ValueMember = tabla.Columns[0].ColumnName.ToString();
            bandera2 = true;
            cmbCategoria.DisplayMember = tabla.Columns[1].ColumnName.ToString();
        }

        private void llenarPrecioInscripcion() //completa el precio de la inscripcion a una categoria
        {
            DataTable tabla = new DataTable();
            tabla = transaccion.buscarPrecioInscripcion(cmbCategoria.Text, cmbDisciplinas.Text); //espero no tengamos dos categorias en la misma disciplina con el mismo nombre
            txtPrecioInscripcion.Text = tabla.Rows[0][2].ToString();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombreSocio.Text = string.Empty;
            txtNroSocio.Text = string.Empty;
            dgvInscripcionSocioADisciplina.Rows.Clear();
            dgvInscripcionSocioADisciplina.Refresh();
            txtCliente.Text = string.Empty;
            txtDomicilio.Text = string.Empty; 
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtNombreSocio.Text == string.Empty)
                MessageBox.Show("Debe ingresar un numero de socio valido", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                dgvInscripcionSocioADisciplina.Rows.Add(txtNroSocio.Text, txtNombreSocio.Text, cmbDisciplinas.Text, cmbCategoria.Text, txtPrecioInscripcion.Text);
                txtTotal.Text = Convert.ToString(calculartotal());
            }
        }

        private double calculartotal() //calcula el total que creo termina yendo al recibo
        {
            double total = 0;
            for (int i = 0; i < dgvInscripcionSocioADisciplina.Rows.Count; i++)
            {
                 total += Convert.ToDouble(dgvInscripcionSocioADisciplina.Rows[i].Cells[4].Value.ToString());
            }
            return total;
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e) //llena el txt de precios cuando cambia la categoria seleccionada
        {
            if (bandera2)
            {
                llenarPrecioInscripcion();
            }
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            if (dgvInscripcionSocioADisciplina.Rows.Count > 0)
            {
                transaccion.encabezadoInscripcionADisciplina(txtTotal.Text, "Inscripcion", txtCliente.Text, txtDomicilio.Text);
                for (int i = 0; i < dgvInscripcionSocioADisciplina.Rows.Count; i++)
                {
                    DataTable tabla1 = new DataTable();
                    DataTable tabla2 = new DataTable();
                    tabla1 = transaccion.buscarIdDisciplina(dgvInscripcionSocioADisciplina.Rows[i].Cells["disciplina"].Value.ToString());
                    int idSocio = Convert.ToInt32(dgvInscripcionSocioADisciplina.Rows[i].Cells["idSocio"].Value.ToString());
                    int idDisciplina = Convert.ToInt32(tabla1.Rows[0][0]);
                    tabla2 = transaccion.buscarIdCategoria(dgvInscripcionSocioADisciplina.Rows[i].Cells["categoria"].Value.ToString(), idDisciplina);
                    int idCategoria = Convert.ToInt32(tabla2.Rows[0][0]);
                    transaccion.detalleInscripcionADisciplina(idSocio, idDisciplina, idCategoria);
                }
                bool bandera = transaccion.realizarTransaccion();
                if (bandera)
                {
                    MessageBox.Show("La inscripción se realizo", "Inscripción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string nroRecibo = transaccion.nroRecibo();
                    DataTable tabla = validadores.GetDataTableFromDGV(dgvInscripcionSocioADisciplina);
                    frmRecibo frmRecibo = new frmRecibo(txtCliente.Text, txtDomicilio.Text, nroRecibo, tabla);
                    btnLimpiarCampos_Click(sender, e);
                    frmRecibo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Algo salio mal...", "Inscripción fallo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnLimpiarCampos_Click(sender, e);
                }
            }
            else
                MessageBox.Show("No cargo ninguna inscripción", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
