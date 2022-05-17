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
    public partial class StartForm : Form
    {
        string connectionString = "Server=.;Database=carnetNote;Trusted_Connection=True;";
        static String numeStud;
        static String clasa;

        public StartForm()
        {
            InitializeComponent();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            numeStud = numeStudent.Text;
            clasa = clasaInput.Text;

            // Controlul de completare a tuturor casetelor
            if (numeStud == "" || clasa == "")
            {
                MessageBox.Show("Completati toate casetele");
            }
            else if (realButton.Checked == false && umanButton.Checked == false)
            {
                MessageBox.Show("Alegeti profilul va rog");
            }
            else if (licenseCheck.Checked == false)
            {
                MessageBox.Show("Acceptati termenii de licenta si politica de confidentialitate!");
            } else
            {
                
                //Crearea file pentru student
                FileStream fs = null;
                
                String profil;
                if(realButton.Checked)
                {
                    profil = "Real";
                } else
                {
                    profil = "Uman";
                }

                // inserarea in file
                try
                {
                    fs = new FileStream("..\\student.txt", FileMode.Truncate);
                    byte[] input = Encoding.Default.GetBytes("L/T Alexandru Donici \n" + "Fisa personala:\n\n" + "Nume: " + numeStud + "\n" + "Clasa: " + clasa + "\n"
                        + "Profil: " + profil + "\n\n");
                    fs.Write(input, 0, input.Length);

                }
                finally
                {
                    fs.Close();
                }
                  
                if (realButton.Checked)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand($"insert into elev(numeElev, clasa, profil) values('{numeStud}', {clasa}, '{profil.ToUpper()}')", connection);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    ProfilRealForm mForm = new ProfilRealForm();
                    this.Hide();
                    mForm.ShowDialog();
                    this.Close();
                }

                if (umanButton.Checked)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand($"insert into elev(numeElev, clasa, profil) values('{numeStud}', {clasa}, '{profil.ToUpper()}')", connection);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    ProfilUmanForm uForm = new ProfilUmanForm();
                    this.Hide();
                    uForm.ShowDialog();
                    this.Close();
                }

     
            }

        }

        private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c start https://github.com/kennshii");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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
