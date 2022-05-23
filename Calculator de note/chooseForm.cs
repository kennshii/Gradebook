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
    public partial class chooseForm : Form
    {
        public chooseForm()
        {
            InitializeComponent();
        }

        // buton profesor
        private void buttonProfesor_Click(object sender, EventArgs e)
        {
            passPanel.Visible = true;
        }

        // log profesor
        private void button1_Click(object sender, EventArgs e)
        {
            // check password
            if (password.Text == "admin") {
                StartForm mForm = new StartForm();
                this.Hide();
                mForm.ShowDialog();
                this.Close();
        } else
            {
                MessageBox.Show("Parola incorecta. Daca ati uitat parola adresativa administratorului de sistem");
            }

        }

        // log elev
        private void buttonElev_Click(object sender, EventArgs e)
        {
            Elev elevForm = new Elev();
            this.Hide();
            elevForm.ShowDialog();
            this.Close();
        }

        private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c start https://github.com/kennshii");
        }
    }
}
