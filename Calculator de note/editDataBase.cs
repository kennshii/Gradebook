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

    public partial class editDataBase : Form
    {
        string connectionString = "Server=.;Database=carnetNote;Trusted_Connection=True;";
        public editDataBase()
        {
            InitializeComponent();
        }

        // Butonul afiseaza toti elevii
        private void buttonSearchAll_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectAll = $"SELECT * from selectAll";

                SqlDataAdapter adapter = new SqlDataAdapter(selectAll, connection);

                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);

                dataGridView.DataSource = dtbl;
                
            }

        }

        // Butonul sterge
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string strId = tbId.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand removeElev = new SqlCommand($"DELETE FROM noteReal WHERE idElev = {strId}; DELETE FROM noteUman WHERE idElev = {strId}; DELETE FROM elev WHERE idElev = {strId}",connection);
                
                connection.Open();
                removeElev.ExecuteNonQuery();
                connection.Close();

            }
            MessageBox.Show($"Elevul cu id-ul {strId} a fost sters cu succes");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            StartForm start = new StartForm();
            this.Hide();
            start.ShowDialog();
            this.Close();
        }
    }
}
