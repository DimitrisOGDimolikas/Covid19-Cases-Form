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
    public partial class SearchCase : Form
    {
        String connectionString = "Data Source=CovidCases.db;Version=3;";
        SQLiteConnection conn;
        String id, fullname, queryResult;
        StringBuilder builder;
        public SearchCase()
        {
            InitializeComponent();
        }

        private void SearchCase_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
        }
        // The user will only be able to search a case based on its ID
        // so the other textbox is disabled
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox2.Enabled = false;
            }
            else
            {
                textBox2.Enabled = true;
            }
        }
        // The user will only be able to search a case based on its name
        // so the other textbox is disabled
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                textBox1.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
            }
        }
        //Τσεκάρει με ποίο απο τα δύο πεδία να κάνει αναζήτηση 
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                id = textBox1.Text;
                queryResult = searchCase("ID", id);
                // Ελέγχος ύπαρξης αποτελέσματος απο το query
                if (queryResult.Length > 0)
                {
                    MessageBox.Show(queryResult);
                }
                else
                {
                    MessageBox.Show("Δεν υπάρχει κρούσμα με τα δοσμένα κριτήρια");
                }

            }
            else if (textBox2.Text.Length > 0)
            {
                fullname = textBox2.Text;
                queryResult = searchCase("Name", fullname);
                // Ελέγχος ύπαρξης αποτελέσματος απο το query
                if (queryResult.Length > 0)
                {
                    MessageBox.Show(queryResult);
                }
                else
                {
                    MessageBox.Show("Δεν υπάρχει κρούσμα με τα δοσμένα κριτήρια");
                }
            }
            else
            {
                MessageBox.Show("Πρέπει να συμπληρώσετε τουλάχιστον 1 πεδίο.");
            }
        }

        private String searchCase(String col, String value)
        {
            conn.Open();
            String query1 = "SELECT * FROM Cases WHERE " + col + " = '" + value + "';";
            SQLiteCommand cmd = new SQLiteCommand(query1, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            builder = new StringBuilder();
            // Με βάση τα αποτελέσματα του search query χτίζεται ο stringbuilder 
            // με το αποτέλεσμα εμφάνισης στον χρήστη.
            while (reader.Read())
            {
                builder.Append("Το κρούσμα που αναζητείτε, έχει τα εξείς στοιχεία:")
                    .Append(Environment.NewLine)
                    .Append("Όνοματεπώνυμο: ")
                    .Append(reader.GetString(1))
                    .Append(Environment.NewLine)
                    .Append("Email: ")
                    .Append(reader.GetString(2))
                    .Append(Environment.NewLine)
                    .Append("Τηλέφωνο: ")
                    .Append(reader.GetString(3))
                    .Append(Environment.NewLine)
                    .Append("Φύλο: ")
                    .Append(reader.GetString(4))
                    .Append(Environment.NewLine)
                    .Append("Ηλικία: ")
                    .Append(reader.GetInt32(5).ToString());
                    
                // checks if the column 'Nosimata'(which is not a required column) has a value
                // if it has it is appended to the StringBuilder
                if (reader.GetValue(6).ToString().Length > 0) 
                    builder.Append(Environment.NewLine).Append("Υποκείμενο νόσημα: ").Append(reader.GetValue(6));

                builder.Append(Environment.NewLine)
                    .Append("Διεύθυνση: ")
                    .Append(reader.GetString(7))
                    .Append(Environment.NewLine)
                    .Append("Ημερομηνία-ώρα καταγραφής του κρούσματος: ")
                    .Append(reader.GetString(8));
            }
            conn.Close();
            String s;
            //ΑΝ υπάρχει αποτέλεσμα, γυρνάει στον χρήστη ο stringbuilder με το αποτέλεσμα που φτιάχτηκε
            if (builder.Length > 0)
            {
                s = builder.ToString();
                return s;
            }
            else //Αλλιώς γυρνάει empty string..
            {
                s = "";
                return s;
            }

        }
    }
}
