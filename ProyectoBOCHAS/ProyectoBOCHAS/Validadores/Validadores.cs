using System.Windows.Forms;
using System.Data;

namespace ProyectoBOCHAS
{
    class Validadores
    {
        public Validadores()
        {

        }

        public bool ValidarTxt(TextBox textBox1)
        {
            int i;
            if (textBox1.Text != string.Empty)
            {

                if (!int.TryParse(textBox1.Text, out i)) //valida que sean solo caracteres numericos en los textbox de numeros
                {
                    MessageBox.Show("Solo se permiten caracteres numericos", "Error de tipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    return false;
                }
                else
                    if (int.Parse(textBox1.Text.ToString()) <= 0)
                {
                    MessageBox.Show("No puede ingresar valores negativos", "Valores erroneos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    return false;
                }
                else
                    return true;
            }
            return false;
        }

        public DataTable GetDataTableFromDGV(DataGridView dgv) //STACKOVERFLOW
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    // You could potentially name the column based on the DGV column name (beware of dupes)
                    // or assign a type based on the data type of the data bound to this DGV column.
                    dt.Columns.Add(column.Name);
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;
        }
    }
}
