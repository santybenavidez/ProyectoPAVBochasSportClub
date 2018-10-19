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
    public partial class frmRecibo : Form
    {
        Recibo recibo = new Recibo();
        public frmRecibo(string nombreCliente, string domicilio, string nroRecibo, DataTable tabla)
        {
            InitializeComponent();
            txtNombreCliente.Text = nombreCliente;
            txtDomicilio.Text = domicilio;
            dgvDetalle.DataSource = tabla;
            DataTable tabl4 = recibo.ConsultarRecibo(nroRecibo);
            txtNroRecibo.Text = tabl4.Rows[0][0].ToString();
            txtFecha.Text = tabl4.Rows[0][1].ToString();
            txtTotal.Text = tabl4.Rows[0][2].ToString();
        }
    }
}
