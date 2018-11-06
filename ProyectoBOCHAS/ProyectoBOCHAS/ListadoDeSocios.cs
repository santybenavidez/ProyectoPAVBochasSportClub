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
    public partial class ListadoDeSocios : Form
    {
        public ListadoDeSocios()
        {
            InitializeComponent();
        }

        private void ListadoDeSocios_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ListadoSocios.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.ListadoSocios.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
