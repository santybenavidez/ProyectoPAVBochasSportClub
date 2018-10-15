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

        public frmInscripcionADisciplina()
        {
            InitializeComponent();
        }

        private void frmInscripcionADisciplina_Load(object sender, EventArgs e)
        {
            cmbCategoria.Enabled = false;
            llenarComboDisciplinas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (validadores.ValidarTxt(txtNroSocio))
           {
               DataTable tabla = new DataTable();
               tabla = transaccion.buscarSocios(txtNroSocio.Text);
               if (tabla.Rows.Count > 0)
                   txtNombreSocio.Text = tabla.Rows[0][1].ToString();
               else
                   MessageBox.Show("No existe ningun socio con este numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
           }
        }

        private void cmbDisciplinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategoria.Enabled = true;
            cargarComboCategorias();
        }

        private void llenarComboDisciplinas()
        {
            DataTable tabla = new DataTable(); 
            tabla = transaccion.buscarDisciplinas();
            cmbDisciplinas.DataSource = tabla;
            cmbDisciplinas.ValueMember = tabla.Columns[0].ColumnName.ToString();
            cmbDisciplinas.DisplayMember = tabla.Columns[1].ColumnName.ToString();

        }

        private void cargarComboCategorias()
        {
            DataTable tabla = new DataTable();
            tabla = transaccion.buscarCategoriasXDisciplinas(cmbCategoria.Text);
            cmbCategoria.DataSource = tabla;
            cmbCategoria.ValueMember = tabla.Columns[0].ColumnName.ToString();
            cmbCategoria.DisplayMember = tabla.Columns[1].ColumnName.ToString();
        }

        private void llenarPrecioInscripcion()
        {
            DataTable tabla = new DataTable();
            tabla = transaccion.buscarCategoriasXDisciplinas(cmbCategoria.Text);
            txtPrecioInscripcion.Text = tabla.Columns[2].ToString();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombreSocio.Text = string.Empty;
            txtNroSocio.Text = string.Empty;
             
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            dgvInscripcionSocioADisciplina.Rows.Add(txtNroSocio.Text, txtNombreSocio.Text, cmbDisciplinas.Text, cmbCategoria.Text, txtPrecioInscripcion.Text);
            txtTotal.Text = Convert.ToString(calculartotal());
        }

        private double calculartotal()
        {
            double total = 0;
            for (int i = 0; i < dgvInscripcionSocioADisciplina.Rows.Count; i++)
            {
                 total += Convert.ToDouble(dgvInscripcionSocioADisciplina.Rows[i].Cells[4].Value.ToString());
            }
            return total;
        }
    }
}
