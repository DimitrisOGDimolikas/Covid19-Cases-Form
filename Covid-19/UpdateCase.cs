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
    public partial class UpdateCase : Form
    {
        String connectionString = "Data Source=CovidCases.db;Version=3;";
        SQLiteConnection conn;
        String id, fullname, phone, address, age, email, nosimata, gender;

        private void UpdateCase_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        StringBuilder sb;

        public UpdateCase()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Checks if the user has inserted a valid ID of a case 
            if(numericUpDown2.Value > 0)
            {
                //Τσεκάρει ποιό απο τα παρακάτω πεδία είναι συμπληρωμένο, ώστε να τροποποιηθεί..
                id = numericUpDown2.Value.ToString();
                sb = new StringBuilder();
                if(textBox2.Text.Length > 0)
                {
                    fullname = textBox2.Text;
                    if (updateRowDB("Name", fullname, id) == 1)
                    {
                        sb.Append("Το όνομα άλλαξε επιτυχώς σε '").Append(fullname).Append("'")
                            .Append(Environment.NewLine);
                    }
                }
                if(textBox3.Text.Length > 0)
                {
                    email = textBox3.Text;
                    if (updateRowDB("Email", email, id) == 1)
                    {
                        sb.Append("Το email άλλαξε επιτυχώς σε '").Append(email).Append("'")
                            .Append(Environment.NewLine);
                    }
                }
                if(textBox4.Text.Length > 0)
                {
                    phone = textBox4.Text;
                    if(updateRowDB("Phone", phone, id) == 1)
                    {
                        sb.Append("Το τηλέφωνο άλλαξε επιτυχώς σε '").Append(phone).Append("'")
                            .Append(Environment.NewLine);
                    }
                }
                if(comboBox1.SelectedIndex != -1)
                {
                    gender = comboBox1.Text;
                    if(updateRowDB("Gender", gender, id) == 1)
                    {
                        sb.Append("Το φύλλο άλλαξε επιτυχώς σε '").Append(gender).Append("'")
                            .Append(Environment.NewLine);
                    }
                }
                if(numericUpDown1.Value > 0)
                {
                    age = numericUpDown1.Value.ToString();
                    if(updateRowDB("Age", age, id) == 1)
                    {
                        sb.Append("Η ηλικία άλλαξε επιτυχώς σε '").Append(age).Append("'")
                            .Append(Environment.NewLine);
                    }
                }
                if(textBox7.Text.Length > 0)
                {
                    nosimata = textBox7.Text;
                    if(updateRowDB("Nosimata", nosimata, id) == 1)
                    {
                        sb.Append("Τα υποκείμενα νοσήματα άλλαξαν επιτυχώς σε '").Append(nosimata).Append("'")
                            .Append(Environment.NewLine);
                    }
                }
                if(textBox8.Text.Length > 0)
                {
                    address = textBox8.Text;
                    if(updateRowDB("Address", address, id) == 1)
                    {
                        sb.Append("Η διεύθυνση κατοικίας άλλαξε επιτυχώς σε '").Append(address).Append("'")
                            .Append(Environment.NewLine);
                    }
                }
                MessageBox.Show(sb.ToString());
            }
            else
            {
                MessageBox.Show("Πρέπει να εισάγεται το ID πρώτα");
            }
        }

        public int updateRowDB(String column, String value, String id)
        {
            conn.Open();
            String updateQuery = "UPDATE Cases SET '" + column + "' = '" + value + "' WHERE ID='" + id + "'";
            SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn);
            // Η μεταβλητή row χρησιμεύει στον κώδικα του κουμπιού για να δούμε αν επέστρεψε αποτέλεσμα το query.
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            return row;
        }
    }
}
