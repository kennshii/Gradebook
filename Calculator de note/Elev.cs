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
                    string selectReal = $"SELECT e.idElev, e.numeElev,e.profil, n.romana, n.matematica, n.straina, n.istoria, n.fizica, n.biologia, n.chimia, n.informatica, n.geografia, n.notaMedie FROM elev e, noteReal n WHERE e.idElev = n.idElev AND numeElev = '{numeElev}'";

                    SqlDataAdapter adapter = new SqlDataAdapter(selectReal, connection);

                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);

                    dataGridView.DataSource = dtbl;

                //SqlCommand cmd = new SqlCommand($"insert into elev(numeElev, clasa, profil) values('{numeStud}', {clasa}, '{profil.ToUpper()}')", connection);
                //connection.Open();
                //cmd.ExecuteNonQuery();
                //connection.Close();
                }
            } else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    string selectReal = $"SELECT e.idElev, e.numeElev,e.profil, n.romana, n.matematica, n.straina, n.istoria, n.informatica, n.biologia, n.straina2, n.civica, n.geografia, n.notaMedie FROM elev e, noteUman n WHERE e.idElev = n.idElev AND numeElev = '{numeElev}'";

                    SqlDataAdapter adapter = new SqlDataAdapter(selectReal, connection);

                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);

                    dataGridView.DataSource = dtbl;

                    //SqlCommand cmd = new SqlCommand($"insert into elev(numeElev, clasa, profil) values('{numeStud}', {clasa}, '{profil.ToUpper()}')", connection);
                    //connection.Open();
                    //cmd.ExecuteNonQuery();
                    //connection.Close();
                }

            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            chooseForm start = new chooseForm();
            this.Hide();
            start.ShowDialog();
            this.Close();
        }
    }
}
