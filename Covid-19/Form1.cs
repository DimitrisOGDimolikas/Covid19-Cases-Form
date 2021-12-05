using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_19
{
    public partial class Form1 : Form
    {
        String timeStamp = "";
        String fullname, email, address, phone, gender, nosimata;
        int age;
        StringBuilder sb;
        String connectionString = "Data Source=CovidCases.db;Version=3;";
        SQLiteConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
        }

        private void προβολήΚρουσμάτωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show the "ProvoliKrousmaton" form
            new ProvoliKrousmaton().Show();
        }

        private void διαγραφήΚρούσματοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show the "DeleteCase" form
            new DeleteCase().Show();
        }

        private void τροποποίησηΚρούσματοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show the "UpdateCase" form
            new UpdateCase().Show();
        }

        private void αναζήτησηΚρούσματοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show the "SearchCase" form
            new SearchCase().Show();
        }

        private void στατιστικάToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show the "Statistics" form
            new Statistics().Show();
        }

        //------not used------
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //------not used------
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // If the required fields are not empty the case is recorded, else the user is notified about his mistake.
            if(textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 && textBox8.Text.Length > 0 
                && comboBox1.SelectedIndex != -1 && numericUpDown1.Value > 0)
            {
                //Get all the information from textboxes, combobox etc and append them to variables..
                fullname = textBox2.Text;
                email = textBox3.Text;
                phone = textBox4.Text;
                gender = comboBox1.Text;
                age = Int32.Parse(numericUpDown1.Value.ToString());
                address = textBox8.Text;
                nosimata = textBox7.Text.Length > 0 ? textBox7.Text : null;
                timeStamp = GetTimestamp(DateTime.Now);

                //Add the new covid case to database
                writeToDb(fullname, email, phone, gender, age, nosimata, address, timeStamp);

                //Shows the info of the new covid case to the user
                sb = new StringBuilder();
                sb.Append("Επιτυχής καταχώρηση!").AppendLine().Append(fullname).AppendLine()
                    .Append(email).AppendLine().Append(phone).AppendLine()
                    .Append(age).AppendLine().Append(gender).AppendLine().Append(address)
                    .AppendLine().Append(nosimata).AppendLine().Append(timeStamp);

                MessageBox.Show(sb.ToString());
            }
            else{
                MessageBox.Show("Πρέπει να συμπληρώσετε όλα τα υποχρεωτικά πεδία (*) ");
            }
        }

        // Inserts the new Covid-19 case into the database.
        private void writeToDb(String fullname, String email, String phone, String gender, int age, String nosimata, String address, String timestamp)
        {
            conn.Open();
            String insertQuery = "INSERT INTO Cases(Name, Email, Phone, Gender, Age, Nosimata, Address, Timestamp) VALUES('" + fullname + "','" + email + "','" + phone + "', '"+ gender + "', '"+ age + "', '"+ nosimata + "', '"+ address + "', '"+ timestamp + "');";
            SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //We need this function to get the exact timestamp of the covid-19 case recording.
        private static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyy-MM-dd-HH-mm-ss");
        }
    }
}
