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
    public partial class ProvoliKrousmaton : Form
    {
        String connectionString = "Data Source=CovidCases.db;Version=3;";
        SQLiteConnection conn;

        public ProvoliKrousmaton()
        {
            InitializeComponent();
        }

        //Retrieves all Covid-19 Cases from the Table
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query1 = "Select * from Cases";
            SQLiteCommand cmd = new SQLiteCommand(query1, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            StringBuilder builder = new StringBuilder();
            while (reader.Read())
            {
                builder.Append(reader.GetString(1))
                    .Append(",")
                    .Append(reader.GetString(2))
                    .Append(",")
                    .Append(reader.GetString(3))
                    .Append(",")
                    .Append(reader.GetString(4))
                    .Append(",")
                    .Append(reader.GetInt32(5).ToString());
                    
                // checks if the column 'Nosimata'(which is not a required column) has a value
                // if it has it is appended to the StringBuilder
                if (reader.GetValue(6).ToString().Length > 0) 
                    builder.Append(",").Append(reader.GetValue(6));
                

                builder.Append(",")
                    .Append(reader.GetString(7))
                    .Append(",")
                    .Append(reader.GetString(8))
                    .Append(Environment.NewLine);
            }
            textBox1.Text = builder.ToString();

            conn.Close();
        }

        private void ProvoliKrousmaton_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
        }
    }
}
