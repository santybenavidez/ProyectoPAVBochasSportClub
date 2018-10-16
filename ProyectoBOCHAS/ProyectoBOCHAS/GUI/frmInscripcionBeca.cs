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
    public partial class frmInscripcionBeca : Form
    {
        Validadores validadores = new Validadores();
        InscripcionABeca transaccion = new InscripcionABeca();
        public frmInscripcionBeca()
        {
            InitializeComponent();
            llenarComboBecas();
        }

        private void button1_Click(object sender, EventArgs e)
        
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

        private void cmbBecas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void llenarComboBecas()
        {
            DataTable tabla = new DataTable();
            tabla = transaccion.buscarBecas();
            cmbBecas.DataSource = tabla;
            cmbBecas.ValueMember = tabla.Columns[0].ColumnName.ToString();
            cmbBecas.DisplayMember = tabla.Columns[1].ColumnName.ToString();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (dtpFechaFin.Value > dtpFechaIni.Value)
                dgvInscripcionBecas.Rows.Add(txtNroSocio, txtNombreSocio, cmbBecas.ValueMember, cmbBecas.DisplayMember, dtpFechaIni.Text, dtpFechaFin.Text);
            else
            {
                MessageBox.Show("Fecha de fin de beca menor o igual a fecha de inicio de beca.\nPor favor reingrese fecha fin beca", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaFin.Focus();
            }
                
        }

    }
}
