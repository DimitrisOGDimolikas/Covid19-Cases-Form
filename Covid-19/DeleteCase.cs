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
    public partial class DeleteCase : Form
    {
        String connectionString = "Data Source=CovidCases.db;Version=3;";
        SQLiteConnection conn;
        String id, fullname;
        StringBuilder sb;
        public DeleteCase()
        {
            InitializeComponent();
        }

        // The user will only be able to delete a case based on its ID
        // so the other textbox is disabled
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                textBox2.Enabled = false;
            }
            else
            {
                textBox2.Enabled = true;
            }
        }
        // The user will only be able to delete a case based on its name
        // so the other textbox is disabled
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text.Length > 0)
            {
                textBox1.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
            }
        }

        /*
         * When the button is clicked, it checks what type of column needs to be deleted
         * and calls the deleteFromDB with the appropriate parameters..
         */
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text.Length > 0)
            {
                id = textBox1.Text;
                if (deleteFromDB("ID", id) == 1)
                {
                    sb = new StringBuilder();
                    sb.Append("Το κρούσμα με ID '").Append(id).Append("' διαγράφτηκε επιτυχώς!");
                    MessageBox.Show(sb.ToString());
                }
                else
                {
                    MessageBox.Show("Δεν υπάρχει κρούσμα με τα δοσμένα κριτήρια");
                }
                
            }else if (textBox2.Text.Length > 0)
            {
                fullname = textBox2.Text;
                if(deleteFromDB("Name", fullname) == 1)
                {
                    sb = new StringBuilder();
                    sb.Append("Το κρούσμα με ονοματεπώνυμο '").Append(fullname).Append("' διαγράφτηκε επιτυχώς!");
                    MessageBox.Show(sb.ToString());
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

        private void DeleteCase_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
        }

        /*
         Executes a query to delete a row from the Database "Cases" (if exists..)
        */
        private int deleteFromDB(String column, String value)
        {
            conn.Open();
            String deleteQuery = "DELETE FROM Cases WHERE " + column + " = '" + value + "';";
            SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conn);
            // Η μεταβλητή row χρησιμεύει στον κώδικα του κουμπιού για να δούμε αν επέστρεψε αποτέλεσμα το query..
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            return row;
        }
    }
}
