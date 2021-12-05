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
    public partial class Statistics : Form
    {
        List<Krousma> krousmataList = new List<Krousma>();
        String connectionString = "Data Source=CovidCases.db;Version=3;";
        SQLiteConnection conn;
        int sum = 0, n = 0;
        float mo;

        public Statistics()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            Stats s1 = new Stats(0,0,0,0,0,0,0,0,0,0,0,0,0,0);
            conn = new SQLiteConnection(connectionString);
            conn.Open();
            String query1 = "Select * from Cases";
            SQLiteCommand cmd = new SQLiteCommand(query1, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                /*
                 * Checks weather the column "Nosimata" has a value.
                 * Then an object of the class Krousma is created, based
                 * on the data of the table Krousma and it is added to the
                 * krousmataList.
                 * 
                */
                if (reader.GetValue(6).ToString().Length > 0)
                    krousmataList.Add(new Krousma(reader.GetString(1), reader.GetString(2), reader.GetString(3)
                    , reader.GetString(4), reader.GetInt32(5), reader.GetString(7)
                    , reader.GetString(8), reader.GetString(6)));
                else
                    krousmataList.Add(new Krousma(reader.GetString(1), reader.GetString(2), reader.GetString(3)
                    , reader.GetString(4), reader.GetInt32(5), reader.GetString(7)
                    , reader.GetString(8)));
            }
            //Βρίσκει:
            foreach (Krousma k in krousmataList)
            {
                sum += k.Age;
                n++;

                //->Πόσα κρούσματα υπάρχουν ανα ηλικιακή ομάδα
                if (k.Age <= 10)
                {
                    s1.OneToTen++;
                } else if (k.Age <= 20)
                {
                    s1.ElevenToTwenty++;
                } else if (k.Age <= 30)
                {
                    s1.TwentyoneToThirty++;
                }else if (k.Age <= 40)
                {
                    s1.ThiryoneToFourty++;
                }else if (k.Age <= 50)
                {
                    s1.FourtyoneToFifty++;
                }else if (k.Age <= 60)
                {
                    s1.FiftyoneToSixty++;
                }else if (k.Age <= 70)
                {
                    s1.SixtyoneToSeventy++;
                }else if(k.Age <= 80)
                {
                    s1.SeventyoneToEighty++;
                }else if(k.Age <= 90)
                {
                    s1.EightyoneToNinety++;
                }
                else
                {
                    s1.NinetyoneToOnehundred++;
                }

                //->Πόσα κρούσματα υπάρχουν ανά φύλλο
                if(k.Gender == "Άνδρας")
                {
                    s1.Males++;
                }else if(k.Gender == "Γυναίκα")
                {
                    s1.Females++;
                }
                else if(k.Gender == "Άλλο")
                {
                    s1.Others++;
                }

                //Πόσοι πάσχουν απο υποκείμενο νόσημα
                if(k.Nosima.Length > 0) {
                    s1.Nosimata++;
                }

            }
            //Διάμεση ηλικία των κρουσμάτων
            mo = sum / n;

            //Μεγαλύτερος αριθμός κρουσμάτων ανάμεσα στις ηλικιακές ομάδες
            int[] megisti = { s1.OneToTen, s1.ElevenToTwenty, s1.TwentyoneToThirty, s1.ThiryoneToFourty 
                , s1.FourtyoneToFifty, s1.FiftyoneToSixty, s1.SixtyoneToSeventy, s1.SeventyoneToEighty
                , s1.EightyoneToNinety, s1.NinetyoneToOnehundred};
            int megisto = megisti.Max();
            

            conn.Close();
            //Διαμόρφωση του U.I.
            label1.Text = s1.OneToTen.ToString();
            label2.Text = s1.ElevenToTwenty.ToString();
            label3.Text = s1.TwentyoneToThirty.ToString();
            label4.Text = s1.ThiryoneToFourty.ToString();
            label5.Text = s1.FourtyoneToFifty.ToString();
            label6.Text = s1.FiftyoneToSixty.ToString();
            label7.Text = s1.SixtyoneToSeventy.ToString();
            label8.Text = s1.SeventyoneToEighty.ToString();
            label9.Text = s1.EightyoneToNinety.ToString();
            label10.Text = s1.NinetyoneToOnehundred.ToString();
            label23.Text = megisto.ToString();
            label28.Text = s1.Males.ToString();
            label29.Text = s1.Females.ToString();
            label30.Text = s1.Others.ToString();
            label32.Text = mo.ToString();
        }
    }
}
