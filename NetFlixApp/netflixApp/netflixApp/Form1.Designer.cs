namespace netflixApp
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
            this.cmdDB = new System.Windows.Forms.Button();
            this.cmdAddMovie = new System.Windows.Forms.Button();
            this.addMovieTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cmdARName = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cmdARMN = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cmdERMN = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdDB
            // 
            this.cmdDB.Location = new System.Drawing.Point(23, 17);
            this.cmdDB.Name = "cmdDB";
            this.cmdDB.Size = new System.Drawing.Size(214, 31);
            this.cmdDB.TabIndex = 0;
            this.cmdDB.Text = "Test and Refresh Database";
            this.cmdDB.UseVisualStyleBackColor = true;
            this.cmdDB.Click += new System.EventHandler(this.cmdDB_Click);
            // 
            // cmdAddMovie
            // 
            this.cmdAddMovie.Location = new System.Drawing.Point(23, 59);
            this.cmdAddMovie.Name = "cmdAddMovie";
            this.cmdAddMovie.Size = new System.Drawing.Size(214, 23);
            this.cmdAddMovie.TabIndex = 2;
            this.cmdAddMovie.Text = "Add Movie by Name";
            this.cmdAddMovie.UseVisualStyleBackColor = true;
            this.cmdAddMovie.Click += new System.EventHandler(this.cmdAddMovie_Click);
            // 
            // addMovieTextBox
            // 
            this.addMovieTextBox.Location = new System.Drawing.Point(329, 56);
            this.addMovieTextBox.Name = "addMovieTextBox";
            this.addMovieTextBox.Size = new System.Drawing.Size(174, 20);
            this.addMovieTextBox.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 264);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search for MovieName by MovieID.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Search for MovieID by MovieName.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(332, 295);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(346, 321);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(98, 20);
            this.textBox4.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 29);
            this.button3.TabIndex = 10;
            this.button3.Text = "Delete Movie by MovieID.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdARName
            // 
            this.cmdARName.Location = new System.Drawing.Point(23, 88);
            this.cmdARName.Name = "cmdARName";
            this.cmdARName.Size = new System.Drawing.Size(214, 23);
            this.cmdARName.TabIndex = 11;
            this.cmdARName.Text = "AddReviewByName";
            this.cmdARName.UseVisualStyleBackColor = true;
            this.cmdARName.Click += new System.EventHandler(this.cmdARName_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(284, 85);
            this.textBox3.MaxLength = 7;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(39, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(399, 85);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(45, 20);
            this.textBox5.TabIndex = 13;
            // 
            // cmdARMN
            // 
            this.cmdARMN.Location = new System.Drawing.Point(23, 117);
            this.cmdARMN.Name = "cmdARMN";
            this.cmdARMN.Size = new System.Drawing.Size(214, 23);
            this.cmdARMN.TabIndex = 14;
            this.cmdARMN.Text = "Average Rating by Movie Name";
            this.cmdARMN.UseVisualStyleBackColor = true;
            this.cmdARMN.Click += new System.EventHandler(this.cmdARMN_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(329, 117);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(192, 20);
            this.textBox6.TabIndex = 15;
            // 
            // cmdERMN
            // 
            this.cmdERMN.Location = new System.Drawing.Point(23, 146);
            this.cmdERMN.Name = "cmdERMN";
            this.cmdERMN.Size = new System.Drawing.Size(214, 23);
            this.cmdERMN.TabIndex = 16;
            this.cmdERMN.Text = "Each Rating by Movie Name";
            this.cmdERMN.UseVisualStyleBackColor = true;
            this.cmdERMN.Click += new System.EventHandler(this.cmdERMN_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(329, 146);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(192, 20);
            this.textBox7.TabIndex = 17;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(564, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(301, 324);
            this.listBox1.TabIndex = 18;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Top-N Movies by Average Rating";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(323, 177);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(45, 20);
            this.textBox8.TabIndex = 20;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 204);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(214, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Top-N Prolific Users";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(323, 207);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(45, 20);
            this.textBox9.TabIndex = 22;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(23, 235);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(214, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "Top-N Reviewed Movies";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(323, 235);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(45, 20);
            this.textBox10.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "MovieName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "UserID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "MovieName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Rating";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(494, 85);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown1.TabIndex = 29;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "MovieName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "MovieName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Enter N -->";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Enter N -->";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Enter N -->";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Enter MovieID-->";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "MovieName";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(253, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Enter MovieID-->";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(673, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "OUTPUT WINDOW";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(23, 357);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(214, 28);
            this.button7.TabIndex = 39;
            this.button7.Text = "Get Reviews by Movie ID";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(346, 365);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(98, 20);
            this.textBox11.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(253, 368);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Enter MovieID-->";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(386, 23);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(172, 20);
            this.textBox12.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(253, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Enter Database Name -->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(905, 404);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.cmdERMN);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.cmdARMN);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cmdARName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addMovieTextBox);
            this.Controls.Add(this.cmdAddMovie);
            this.Controls.Add(this.cmdDB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdDB;
        private System.Windows.Forms.Button cmdAddMovie;
        private System.Windows.Forms.TextBox addMovieTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cmdARName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button cmdARMN;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button cmdERMN;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label15;
    }
}

