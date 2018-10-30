using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ProyectoBOCHAS
{
    public partial class frmCobroCuotaSocial : Form
    {
        Validadores validadores = new Validadores();
        CuotaSocial transaccion = new CuotaSocial();

        public frmCobroCuotaSocial()
        {
            InitializeComponent();
        }

        private void frmCobroCuotaSocial_Load(object sender, EventArgs e)
        {
            cargarComboMeses();
        }

        private void cargarComboMeses()
        {
            String[] Meses = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            cmbMes.Items.AddRange(Meses);
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
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

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (validarCamposForm())
            {
                dgvDetalle.Rows.Add(txtCliente.Text, txtDomicilio.Text, txtNroSocio.Text, txtNombreSocio.Text, cmbMes.Text);
                txtTotal.Text = Convert.ToString(calcularTotal());
            }
                
        }

        private bool validarCamposForm()
        {
            if (txtCliente.Text == string.Empty || txtDomicilio.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el nombre y/o domicilio de la persona que efectua el pago.", "Datos faltantes", MessageBoxButtons.OK);
                txtCliente.Focus();
                return false;
            }
            else
            {
                if (txtNombreSocio.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el numero de socio para poder obtener el nombre de socio", "Falta ingreso de socio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombreSocio.Focus();
                    return false;
                }
                else
                    return true;
            }
        }

        private int calcularTotal()
        {
            int total = 0;
            for (int i = 0; i <= dgvDetalle.Rows.Count; i++)
                total = 150 * (i);
            return total;

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtCliente.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
            txtNroSocio.Text = string.Empty;
            txtNombreSocio.Text = string.Empty;
            txtTotal.Text = string.Empty;
            dgvDetalle.Rows.Clear();
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count > 0)
            {
               int nroSocio = Convert.ToInt32(txtNroSocio.Text);
               int totalRecibo = Convert.ToInt32(txtTotal.Text);
               transaccion.EncabezadoCuotaSocial(nroSocio,txtCliente.Text, txtDomicilio.Text,totalRecibo);

               for (int i = 0; i < dgvDetalle.Rows.Count; i++)
               {
                   int idSocio = Convert.ToInt32(dgvDetalle.Rows[i].Cells["idSocio"].Value.ToString());
                   string mes = Convert.ToString(dgvDetalle.Rows[i].Cells["mesQueCorresponde"].Value.ToString());
                   transaccion.DetalleCuotaSocial(idSocio, mes);
               }

                bool bandera = transaccion.realizarTransaccion();
                if (bandera)
                {
                    MessageBox.Show("La inscripción se realizo", "Inscripción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string nroRecibo = transaccion.numRecibo();
                    DataTable tabla = validadores.GetDataTableFromDGV(dgvDetalle);
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
                MessageBox.Show("No cargo ningun pago", "Validación de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }        
    }
 }

