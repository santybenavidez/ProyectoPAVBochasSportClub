using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ProyectoBOCHAS
{
    public partial class frmVentasXTipoProducto : Form
    {
        string fechaDesde = "";
        string fechaHasta = "";

        public frmVentasXTipoProducto()
        {
            InitializeComponent();
        }

        private void frmVentasXTipoProducto_Load(object sender, EventArgs e)
        {
            
        }

        private DataSet GetDataSet() //TODO ESTO ES STACKOVERFLOW https://stackoverflow.com/questions/13332611/a-data-source-instance-has-not-been-supplied-for-the-data-sourceproduct-detail
        { //CASI TRES HORAS RENEGANDO PORQUE NO ANDABA, COMENTA LO DE STACKOVERFLOW Y DICE QUE EL NO ESTA INSTANCIADO EL DATASET
            System.Data.SqlClient.SqlConnection sqlConn = new System.Data.SqlClient.SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=BDBochas;User ID=sa;password=1234");
            //"Data Source=maquis;Initial Catalog=73280Bochas;User ID=avisuales1;password=avisuales1"
            //@"Data Source=USUARIO-3WU9RFG\SQLEXPRESS;Initial Catalog=BDBochas;Integrated Security=True"
            sqlConn.Open();
            string sql = @"SELECT TipoProducto.nombre, COUNT(*) AS Ventas
        FROM Recibo INNER JOIN
        VentaProductos ON Recibo.nroRecibo = VentaProductos.nroRecibo INNER JOIN
        Productos ON VentaProductos.idProductos = Productos.idProductos AND VentaProductos.idTipoProducto = Productos.idTipoProducto INNER JOIN
        TipoProducto ON Productos.idTipoProducto = TipoProducto.idTipoProducto
        WHERE Recibo.fechaRecibo BETWEEN '" + fechaDesde + "' AND '" + fechaHasta + "'";
            sql += "GROUP BY TipoProducto.nombre ORDER BY Ventas";

            System.Data.SqlClient.SqlDataAdapter ad = new System.Data.SqlClient.SqlDataAdapter(sql, sqlConn);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            sqlConn.Close();
            return ds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fechaDesde = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            fechaHasta = dateTimePicker2.Value.ToString("MM/dd/yyyy");

            //EMPIEZA COPY PASTE DE STACKOVERFLOW
            DataSet ds = GetDataSet();
            ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            //TERMINA COPY PASTE DE STACKOVERFLOW

            this.reportViewer1.RefreshReport();
        }
    }
}
