using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        private void llenarComboBecas()
        {
            DataTable tabla = new DataTable();
            tabla = transaccion.buscarBecas();
            cmbBecas.DataSource = tabla;
            cmbBecas.DisplayMember = tabla.Columns[1].ColumnName.ToString();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (dtpFechaFin.Value > dtpFechaIni.Value)
            {
                DataTable tabla = new DataTable();
                tabla = transaccion.buscarIdBeca(cmbBecas.Text);
                string idBeca = tabla.Rows[0][0].ToString();
                dgvInscripcionBecas.Rows.Add(txtNroSocio.Text, txtNombreSocio.Text, idBeca, cmbBecas.Text, dtpFechaIni.Text, dtpFechaFin.Text);
            }
            else
            {
                MessageBox.Show("Fecha de fin de beca menor o igual a fecha de inicio de beca.\nPor favor reingrese fecha fin beca", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaFin.Focus();
            }    
        }

        private void frmInscripcionBeca_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombreSocio.Text = string.Empty;
            txtNroSocio.Text = string.Empty;
            dgvInscripcionBecas.Rows.Clear();
            dgvInscripcionBecas.Refresh();
            txtCliente.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            if (dgvInscripcionBecas.Rows.Count > 0)
            {
                if (txtCliente.Text == string.Empty || txtDomicilio.Text == string.Empty)
                    MessageBox.Show("Debe cargar la informacio del cliente", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string nroRecibo = transaccion.EncabezadoInscripcionBeca(txtCliente.Text, txtDomicilio.Text);
                    for (int i = 0; i < dgvInscripcionBecas.Rows.Count; i++)
                    {
                        int idBeca = Convert.ToInt32(dgvInscripcionBecas.Rows[i].Cells[2].Value.ToString());
                        int idSocio = Convert.ToInt32(dgvInscripcionBecas.Rows[i].Cells[0].Value.ToString());
                        string fechaInicio = dgvInscripcionBecas.Rows[i].Cells[4].Value.ToString();
                        string[] formats = { "d/M/yyyy" };
                        fechaInicio = DateTime.ParseExact(fechaInicio, formats, new System.Globalization.CultureInfo("en-US"), DateTimeStyles.None).ToString("MM/dd/yyyy");
                        string fechaFin = dgvInscripcionBecas.Rows[i].Cells[5].Value.ToString();
                        fechaFin = DateTime.ParseExact(fechaFin, formats, new System.Globalization.CultureInfo("en-US"), DateTimeStyles.None).ToString("MM/dd/yyyy");
                        transaccion.DetalleInscripcionBeca(idBeca, idSocio, fechaInicio, fechaFin);
                    }
                    bool bandera = transaccion.realizarTransaccion();
                    if (bandera)
                    {
                        MessageBox.Show("El/Los socio/s fue asociado a la beca", "Asociación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataTable tabla = validadores.GetDataTableFromDGV(dgvInscripcionBecas);
                        frmRecibo frmRecibo = new frmRecibo(txtCliente.Text, txtDomicilio.Text, nroRecibo, tabla);
                        frmRecibo.ShowDialog();
                        btnLimpiarCampos_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Algo salio mal", "Asociación fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnLimpiarCampos_Click(sender, e);
                    }
                }
            }
            else
                MessageBox.Show("No cargo ninguna beca con su beneficiario", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
