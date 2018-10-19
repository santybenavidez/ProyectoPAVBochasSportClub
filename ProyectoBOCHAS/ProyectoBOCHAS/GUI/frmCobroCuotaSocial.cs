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
    }
}
