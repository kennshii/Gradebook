using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_de_note
{
    public partial class Elev : Form
    {
        string connectionString = "Server=.;Database=carnetNote;Trusted_Connection=True;";

        public Elev()
        {
            InitializeComponent();
        }

        // Search button
        private void button1_Click(object sender, EventArgs e)
        {
            string profil = "REAL";
            string numeElev = textNume.Text;

            if(rbReal.Checked)
                profil = "REAL";
            if (rbUman.Checked)
                profil = "UMAN";

            if (textNume.Text != "" && profil == "REAL")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    string selectReal = $"SELECT e.numeElev,e.profil, n.romana, n.matematica, n.straina, n.istoria, n.fizica, n.biologia, n.chimia, n.informatica, n.geografia, n.notaMedie FROM elev e, noteReal n WHERE e.idElev = n.idElev AND numeElev = '{numeElev}'";

                    SqlDataAdapter adapter = new SqlDataAdapter(selectReal, connection);

                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);

                    dataGridView.DataSource = dtbl;

                }
            } else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    string selectReal = $"SELECT e.numeElev,e.profil, n.romana, n.matematica, n.straina, n.istoria, n.informatica, n.biologia, n.straina2, n.civica, n.geografia, n.notaMedie FROM elev e, noteUman n WHERE e.idElev = n.idElev AND numeElev = '{numeElev}'";

                    SqlDataAdapter adapter = new SqlDataAdapter(selectReal, connection);

                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);

                    dataGridView.DataSource = dtbl;

                }
            }
        }

        // back button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            chooseForm start = new chooseForm();
            this.Hide();
            start.ShowDialog();
            this.Close();
        }


        // password button
        private void buttonExport_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewTextBoxColumn column in dataGridView.Columns)
            {
                dt.Columns.Add(column.Name, column.ValueType);
            }
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataRow dr = dt.NewRow();
                foreach (DataGridViewTextBoxColumn column in dataGridView.Columns)
                {
                    if (row.Cells[column.Name].Value != null)
                    {
                        dr[column.Name] = row.Cells[column.Name].Value.ToString();
                    }
                }
                dt.Rows.Add(dr);
            }
            string filePath = "..\\Result.txt";
            DataTableToTextFile(dt, filePath);
            MessageBox.Show("Datele au fost exportate in folderul cu aplicatia");
        }

        // Data table to text
        private void DataTableToTextFile(DataTable dt, string outputFilePath)
        {
            int[] maxLengths = new int[dt.Columns.Count];
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");


            for (int i = 0; i < dt.Columns.Count; i++)
            {
                maxLengths[i] = dt.Columns[i].ColumnName.Length;
                foreach (DataRow row in dt.Rows)
                {
                    if (!row.IsNull(i))
                    {
                        int length = row[i].ToString().Length;
                        if (length > maxLengths[i])
                        {
                            maxLengths[i] = length;
                        }
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(outputFilePath, false))
            {
                sw.WriteLine("L/T Alexandru Donici \nFisa personala: \n");

                sw.WriteLine();

                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        if (!row.IsNull(i))
                        {
                            if (dt.Columns[i].ColumnName.Equals("notaMedie"))
                                sw.WriteLine();
                                
                            sw.Write(dt.Columns[i].ColumnName + ": ");
                            sw.Write(row[i].ToString()/*.PadRight(maxLengths[i] + 2)*/);
                            sw.WriteLine();
                        }
                        else
                        {
                            sw.WriteLine();
                        }
                    }
                    sw.WriteLine();

                }
                sw.WriteLine($"Data: {theDate}".PadRight(50) + "Semnatura: __________________");
                sw.WriteLine();
                sw.Close();
            }
        }

    }
}
