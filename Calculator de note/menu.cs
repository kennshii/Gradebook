using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_de_note
{
    public partial class StartForm : Form
    {
        public String numeStud;
        public String clasa;

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

                try
                {
                    fs = new FileStream("student.txt", FileMode.Create);
                    byte[] input = Encoding.Default.GetBytes("Nume: " + numeStud + "\n" + "Clasa: " + clasa + "\n"
                        + "Profil: " + profil + "\n\n");
                    fs.Write(input, 0, input.Length);

                }
                finally
                {
                    fs.Close();
                }

                if (realButton.Checked)
                {
                    ProfilRealForm mForm = new ProfilRealForm();
                    this.Hide();
                    mForm.ShowDialog();
                    this.Close();
                }

                if (umanButton.Checked)
                {
                    ProfilUmanForm uForm = new ProfilUmanForm();
                    this.Hide();
                    uForm.ShowDialog();
                    this.Close();
                }
            }



        }


        private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c start http://www.google.com");
        }
    }
}
