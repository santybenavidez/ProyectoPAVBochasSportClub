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
        public frmRecibo(string nombreCliente, string domicilio, string nroRecibo)
        {
            InitializeComponent();
            txtNombreCliente.Text = nombreCliente;
            txtDomicilio.Text = domicilio;
            txtNroRecibo.Text = nroRecibo;
        }
    }
}
