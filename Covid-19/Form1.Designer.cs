
namespace Covid_19
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.επιλογέςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.προβολήΚρουσμάτωνToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.διαγραφήΚρούσματοςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.τροποποίησηΚρούσματοςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.αναζήτησηΚρούσματοςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.στατιστικάToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Καταγραφή Κρουσμάτων Covid-19";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ονοματεπώνυμο*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Τηλέφωνο επικοινωνίας*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Φύλο*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(392, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ηλικία*";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(340, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Υποκείμενα νοσήματα (αν υπάρχουν)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(392, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Διεύθυνση κατοικίας*";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 22);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 194);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(196, 22);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 270);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(196, 22);
            this.textBox4.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(397, 117);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(122, 22);
            this.numericUpDown1.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Άνδρας",
            "Γυναίκα",
            "Άλλο"});
            this.comboBox1.Location = new System.Drawing.Point(12, 340);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(397, 270);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(196, 22);
            this.textBox7.TabIndex = 21;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(397, 194);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(196, 22);
            this.textBox8.TabIndex = 22;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.επιλογέςToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 30);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // επιλογέςToolStripMenuItem
            // 
            this.επιλογέςToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.προβολήΚρουσμάτωνToolStripMenuItem,
            this.διαγραφήΚρούσματοςToolStripMenuItem,
            this.τροποποίησηΚρούσματοςToolStripMenuItem,
            this.αναζήτησηΚρούσματοςToolStripMenuItem,
            this.στατιστικάToolStripMenuItem});
            this.επιλογέςToolStripMenuItem.Name = "επιλογέςToolStripMenuItem";
            this.επιλογέςToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.επιλογέςToolStripMenuItem.Text = "Επιλογές";
            // 
            // προβολήΚρουσμάτωνToolStripMenuItem
            // 
            this.προβολήΚρουσμάτωνToolStripMenuItem.Name = "προβολήΚρουσμάτωνToolStripMenuItem";
            this.προβολήΚρουσμάτωνToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.προβολήΚρουσμάτωνToolStripMenuItem.Text = "Προβολή Κρουσμάτων";
            this.προβολήΚρουσμάτωνToolStripMenuItem.Click += new System.EventHandler(this.προβολήΚρουσμάτωνToolStripMenuItem_Click);
            // 
            // διαγραφήΚρούσματοςToolStripMenuItem
            // 
            this.διαγραφήΚρούσματοςToolStripMenuItem.Name = "διαγραφήΚρούσματοςToolStripMenuItem";
            this.διαγραφήΚρούσματοςToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.διαγραφήΚρούσματοςToolStripMenuItem.Text = "Διαγραφή κρούσματος";
            this.διαγραφήΚρούσματοςToolStripMenuItem.Click += new System.EventHandler(this.διαγραφήΚρούσματοςToolStripMenuItem_Click);
            // 
            // τροποποίησηΚρούσματοςToolStripMenuItem
            // 
            this.τροποποίησηΚρούσματοςToolStripMenuItem.Name = "τροποποίησηΚρούσματοςToolStripMenuItem";
            this.τροποποίησηΚρούσματοςToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.τροποποίησηΚρούσματοςToolStripMenuItem.Text = "Τροποποίηση κρούσματος";
            this.τροποποίησηΚρούσματοςToolStripMenuItem.Click += new System.EventHandler(this.τροποποίησηΚρούσματοςToolStripMenuItem_Click);
            // 
            // αναζήτησηΚρούσματοςToolStripMenuItem
            // 
            this.αναζήτησηΚρούσματοςToolStripMenuItem.Name = "αναζήτησηΚρούσματοςToolStripMenuItem";
            this.αναζήτησηΚρούσματοςToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.αναζήτησηΚρούσματοςToolStripMenuItem.Text = "Αναζήτηση κρούσματος ";
            this.αναζήτησηΚρούσματοςToolStripMenuItem.Click += new System.EventHandler(this.αναζήτησηΚρούσματοςToolStripMenuItem_Click);
            // 
            // στατιστικάToolStripMenuItem
            // 
            this.στατιστικάToolStripMenuItem.Name = "στατιστικάToolStripMenuItem";
            this.στατιστικάToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.στατιστικάToolStripMenuItem.Text = "Στατιστικά";
            this.στατιστικάToolStripMenuItem.Click += new System.EventHandler(this.στατιστικάToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 38);
            this.button1.TabIndex = 24;
            this.button1.Text = "Καταγραφή Κρούσματος";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem επιλογέςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem προβολήΚρουσμάτωνToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem διαγραφήΚρούσματοςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem τροποποίησηΚρούσματοςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem αναζήτησηΚρούσματοςToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem στατιστικάToolStripMenuItem;
    }
}

