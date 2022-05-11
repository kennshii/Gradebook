using System.Data.SqlClient;
using System.Text;

namespace Calculator_de_note
{
    public partial class ProfilRealForm : Form
    {
        public ProfilRealForm()
        {
            InitializeComponent();
        }
        string connectionString = "Server=.;Database=carnetNote;Trusted_Connection=True;";

        private void calculate_Click(object sender, EventArgs e)
        {
            double romana, matem, lstraina, istoria, fizica, informatica, geografia, chimia, biologia;

            // Try catch pentru eroarea user input
            try
            {
                // Citirea datelor din casete
                romana = double.Parse(lromGrade.Text);
                matem = double.Parse(mathGrade.Text);
                lstraina = double.Parse(langGrade.Text);
                istoria = double.Parse(historyGrade.Text);
                fizica = double.Parse(fizicaGrade.Text);
                informatica = double.Parse(informaticaNota.Text);
                geografia = double.Parse(geografiaNota.Text);
                chimia = double.Parse(chimiaGrade.Text);
                biologia = double.Parse(biologiaGrade.Text);

                    // array pentru valoarea medie si rezultat
                    List<double> grades = new List<double> { romana, matem, lstraina, istoria, fizica, informatica, geografia, chimia, biologia };
                    // array pentru controlul notelor
                    List<double> checkedG = new List<double>();
               
                // check grades
                int i = 0;
                while(i < grades.Count)
                {
                    if(grades[i] > 0 && grades[i] <= 10)
                    {
                        checkedG.Add(grades[i]);
                    }
                    i++;
                }

                if (grades.Count() == checkedG.Count())
                {
                    String grade = grades.Average().ToString();
                    gradeText.Text = grade.Substring(0, 4);
                } else
                {
                    MessageBox.Show("Introduceti valori valide(de la 1 la 10)!");
                }

            } catch(Exception ex)
            {
                MessageBox.Show("Controlati datele inserate!\nIntroduceti doar cifre!");
            }

        }

        //butonul clear
        private void clearButton_Click(object sender, EventArgs e)
        {
            if(lromGrade.Text != "" || mathGrade.Text != "" || langGrade.Text != "" || historyGrade.Text != "" ||
                fizicaGrade.Text != "" || informaticaNota.Text != "" || geografiaNota.Text != "" || chimiaGrade.Text != ""
                || biologiaGrade.Text != "")
            {
                lromGrade.Text = "";
                mathGrade.Text = "";
                langGrade.Text = "";
                historyGrade.Text = "";
                fizicaGrade.Text = "";
                informaticaNota.Text = "";
                geografiaNota.Text = "";
                chimiaGrade.Text = "";
                biologiaGrade.Text = "";
            } else
            {
                MessageBox.Show("Toate casetele sunt libere!");
            }
        }

        // butonul export
        public void exportButton_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            try
            {
                fs = new FileStream("student.txt", FileMode.Append);
                byte[] input = Encoding.Default.GetBytes(
                    "Limba romana: " + lromGrade.Text + "\n" +
                    "Matematica: " + mathGrade.Text + "\n" +
                    "Limba straina: " + langGrade.Text + "\n" +
                    "Istoria: " + historyGrade.Text + "\n" +
                    "Fizica: " + fizicaGrade.Text + "\n" +
                    "Informatica: " + informaticaNota.Text + "\n" +
                    "Geografia: " + geografiaNota.Text + "\n" +
                    "Chimia: " + chimiaGrade.Text + "\n" +
                    "Biologia: " + biologiaGrade.Text + "\n\n" +
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

        //  imagine buton
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            StartForm start = new StartForm();
            this.Hide();
            start.ShowDialog();
            this.Close();
        }

        // Schimbarea cursorului pe pictureBox
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double romana, matem, lstraina, istoria, fizica, informatica, geografia, chimia, biologia;

            romana = double.Parse(lromGrade.Text);
            matem = double.Parse(mathGrade.Text);
            lstraina = double.Parse(langGrade.Text);
            istoria = double.Parse(historyGrade.Text);
            fizica = double.Parse(fizicaGrade.Text);
            informatica = double.Parse(informaticaNota.Text);
            geografia = double.Parse(geografiaNota.Text);
            chimia = double.Parse(chimiaGrade.Text);
            biologia = double.Parse(biologiaGrade.Text);
              
            String notaMedie = gradeText.Text;
            double nm = Convert.ToDouble(notaMedie);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand last = new SqlCommand("SELECT TOP 1 idElev FROM elev ORDER BY idElev DESC", connection);
                
                int idElev;
                connection.Open();
                idElev = Convert.ToInt32(last.ExecuteScalar());
                connection.Close();

                SqlCommand cmd = new SqlCommand($"insert into noteReal(idElev, romana, matematica, straina, istoria, fizica, biologia, chimia, informatica, geografia, notaMedie) values({idElev}, {romana}, {matem}, {lstraina}, {istoria}, {fizica}, {informatica}, {geografia}, {chimia}, {biologia}, {nm})", connection);
                
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            MessageBox.Show("Datele au fost exportate cu succes");
        }
    }
}