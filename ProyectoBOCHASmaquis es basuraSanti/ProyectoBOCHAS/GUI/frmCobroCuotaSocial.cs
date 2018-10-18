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
        
        public frmCobroCuotaSocial()
        {
            InitializeComponent();
        }

        private void frmCobroCuotaSocial_Load(object sender, EventArgs e)
        {

            cargarComboMeses();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cargarComboMeses()
        {

            String[] Meses = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            comboBox1.Items.AddRange(Meses);
            
            

            
        }

    }
}
