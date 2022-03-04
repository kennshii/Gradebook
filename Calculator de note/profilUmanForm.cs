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
    public partial class ProfilUmanForm : Form
    {
        public ProfilUmanForm()
        {
            InitializeComponent();
        }

        private void profilUmanForm_Load(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double romana, matem, lstraina, istoria, informatica, geografia, biologia, lstraina2, civica, litUniversala ;

            // Try catch pentru eroarea user input
            try
            {
                // Citirea datelor din casete
                romana = double.Parse(lromGrade.Text);
                matem = double.Parse(mathGrade.Text);
                lstraina = double.Parse(langGrade.Text);
                istoria = double.Parse(historyGrade.Text);
                informatica = double.Parse(informaticaNota.Text);
                geografia = double.Parse(geografiaNota.Text);
                biologia = double.Parse(biologiaGrade.Text);
                lstraina2 = double.Parse(lang2Grade.Text);
                civica = double.Parse(civicaGrade.Text);
                litUniversala = double.Parse(litUniversalaGrade.Text);

                // array pentru valoarea medie si rezultat
                List<double> grades = new List<double> { romana, matem, lstraina, istoria, informatica, geografia, biologia, lstraina2, civica, litUniversala };
                // array pentru controlul notelor
                List<double> checkedG = new List<double>();

                // check if grades > 10
                int i = 0;
                while (i < grades.Count)
                {
                    if (grades[i] > 0 && grades[i] <= 10)
                    {
                        checkedG.Add(grades[i]);
                    }
                    i++;
                }

                if (grades.Count() == checkedG.Count())
                {
                    String grade = grades.Average().ToString();
                    gradeText.Text = grade.Substring(0, 3);
                }
                else
                {
                    MessageBox.Show("Introduceti valori valide(de la 1 la 10)!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Controlati datele inserate!\nIntroduceti doar cifre!");
            }
        }

        // butonul clear
        private void clearButton_Click(object sender, EventArgs e)
        {
            // check for text
            if (lromGrade.Text != "" || mathGrade.Text != "" || langGrade.Text != "" || historyGrade.Text != ""
                || informaticaNota.Text != "" || geografiaNota.Text != "" || biologiaGrade.Text != "" || lang2Grade.Text != ""
                || civicaGrade.Text != "" || litUniversalaGrade.Text != "")
            {
                lromGrade.Text = "";
                mathGrade.Text = "";
                langGrade.Text = "";
                historyGrade.Text = "";
                informaticaNota.Text = "";
                geografiaNota.Text = "";
                biologiaGrade.Text = "";
                lang2Grade.Text = "";
                civicaGrade.Text = "";
                litUniversalaGrade.Text = "";
            }
            else
            {
                MessageBox.Show("Toate casetele sunt libere!");
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            // crearea unui filestream
            FileStream fs = null;
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            try
            {
                //inserarea datelor
                fs = new FileStream("student.txt", FileMode.Append);
                byte[] input = Encoding.Default.GetBytes(
                    "Limba romana: " + lromGrade.Text + "\n" +
                    "Matematica: " + mathGrade.Text + "\n" +
                    "Limba straina: " + langGrade.Text + "\n" +
                    "Istoria: " + historyGrade.Text + "\n" +
                    "Informatica: " + informaticaNota.Text + "\n" +
                    "Geografia: " + geografiaNota.Text + "\n" +
                    "Biologia: " + biologiaGrade.Text + "\n" +
                    "Limba straina(2): " + lang2Grade.Text + "\n" +
                    "Educatia civica: " + biologiaGrade.Text + "\n\n" +
                    "Nota medie: " + gradeText.Text + "\n\n" + 
                    "Data exportarii: " +  theDate + "\n");
                fs.Write(input, 0, input.Length);
                MessageBox.Show("Ati exportat datele cu succces!");
               

            }
            finally
            {
                fs.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            StartForm start = new StartForm();
            this.Hide();
            start.ShowDialog();
            this.Close();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }
    }
}
