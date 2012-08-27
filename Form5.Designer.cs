namespace Movie_Maniacs
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ReviewTextBox = new System.Windows.Forms.RichTextBox();
            this.NoDBox = new System.Windows.Forms.CheckBox();
            this.TodayButton = new System.Windows.Forms.CheckBox();
            this.DateYear = new System.Windows.Forms.TextBox();
            this.DateMonth = new System.Windows.Forms.ComboBox();
            this.DateDay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IMDBBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MarkBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.YearBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBDBox = new System.Windows.Forms.CheckBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 28);
            this.button1.TabIndex = 33;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Review";
            // 
            // ReviewTextBox
            // 
            this.ReviewTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReviewTextBox.Location = new System.Drawing.Point(0, 33);
            this.ReviewTextBox.Name = "ReviewTextBox";
            this.ReviewTextBox.Size = new System.Drawing.Size(367, 137);
            this.ReviewTextBox.TabIndex = 31;
            this.ReviewTextBox.Text = "";
            // 
            // NoDBox
            // 
            this.NoDBox.AutoSize = true;
            this.NoDBox.Location = new System.Drawing.Point(143, 222);
            this.NoDBox.Name = "NoDBox";
            this.NoDBox.Size = new System.Drawing.Size(66, 17);
            this.NoDBox.TabIndex = 30;
            this.NoDBox.Text = "No Date";
            this.NoDBox.UseVisualStyleBackColor = true;
            this.NoDBox.Click += new System.EventHandler(this.NoDBox_CheckedChanged);
            // 
            // TodayButton
            // 
            this.TodayButton.AutoSize = true;
            this.TodayButton.Location = new System.Drawing.Point(219, 222);
            this.TodayButton.Name = "TodayButton";
            this.TodayButton.Size = new System.Drawing.Size(56, 17);
            this.TodayButton.TabIndex = 29;
            this.TodayButton.Text = "Today";
            this.TodayButton.UseVisualStyleBackColor = true;
            this.TodayButton.Click += new System.EventHandler(this.NoDBox_CheckedChanged);
            // 
            // DateYear
            // 
            this.DateYear.Location = new System.Drawing.Point(262, 176);
            this.DateYear.Name = "DateYear";
            this.DateYear.Size = new System.Drawing.Size(51, 20);
            this.DateYear.TabIndex = 28;
            this.DateYear.Text = "Year";
            // 
            // DateMonth
            // 
            this.DateMonth.FormattingEnabled = true;
            this.DateMonth.IntegralHeight = false;
            this.DateMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.DateMonth.Location = new System.Drawing.Point(143, 176);
            this.DateMonth.Name = "DateMonth";
            this.DateMonth.Size = new System.Drawing.Size(63, 21);
            this.DateMonth.TabIndex = 27;
            this.DateMonth.Text = "Month";
            // 
            // DateDay
            // 
            this.DateDay.FormatString = "C3";
            this.DateDay.FormattingEnabled = true;
            this.DateDay.IntegralHeight = false;
            this.DateDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DateDay.Location = new System.Drawing.Point(212, 176);
            this.DateDay.Name = "DateDay";
            this.DateDay.Size = new System.Drawing.Size(44, 21);
            this.DateDay.TabIndex = 26;
            this.DateDay.Text = "Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Date you saw it";
            // 
            // IMDBBox
            // 
            this.IMDBBox.Location = new System.Drawing.Point(143, 141);
            this.IMDBBox.Name = "IMDBBox";
            this.IMDBBox.Size = new System.Drawing.Size(132, 20);
            this.IMDBBox.TabIndex = 24;
            this.IMDBBox.Text = "Unknown";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "URL to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Your mark";
            // 
            // MarkBox
            // 
            this.MarkBox.FormatString = "N2";
            this.MarkBox.FormattingEnabled = true;
            this.MarkBox.IntegralHeight = false;
            this.MarkBox.Location = new System.Drawing.Point(143, 100);
            this.MarkBox.Name = "MarkBox";
            this.MarkBox.Size = new System.Drawing.Size(86, 21);
            this.MarkBox.TabIndex = 21;
            this.MarkBox.Text = "Unknown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Year";
            // 
            // YearBox
            // 
            this.YearBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.YearBox.FormatString = "N0";
            this.YearBox.FormattingEnabled = true;
            this.YearBox.IntegralHeight = false;
            this.YearBox.Items.AddRange(new object[] {
            "Unknown"});
            this.YearBox.Location = new System.Drawing.Point(143, 63);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(86, 21);
            this.YearBox.Sorted = true;
            this.YearBox.TabIndex = 19;
            this.YearBox.Text = "Unknown";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name of the movie";
            // 
            // AddBox
            // 
            this.AddBox.Location = new System.Drawing.Point(143, 32);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(170, 20);
            this.AddBox.TabIndex = 17;
            this.AddBox.Text = "Unknown";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBDBox);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 457);
            this.panel1.TabIndex = 34;
            // 
            // TBDBox
            // 
            this.TBDBox.AutoSize = true;
            this.TBDBox.Location = new System.Drawing.Point(281, 222);
            this.TBDBox.Name = "TBDBox";
            this.TBDBox.Size = new System.Drawing.Size(48, 17);
            this.TBDBox.TabIndex = 30;
            this.TBDBox.Text = "TBD";
            this.TBDBox.UseVisualStyleBackColor = true;
            this.TBDBox.Visible = false;
            this.TBDBox.Click += new System.EventHandler(this.NoDBox_CheckedChanged);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(340, 178);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(15, 20);
            this.datePicker.TabIndex = 36;
            this.datePicker.Value = new System.DateTime(2012, 7, 27, 0, 0, 0, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.ReviewTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 287);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 170);
            this.panel4.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 34;
            this.button2.Text = "Search";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbutton.Location = new System.Drawing.Point(93, 0);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(74, 28);
            this.Cancelbutton.TabIndex = 35;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 34);
            this.panel2.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Cancelbutton);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(188, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 34);
            this.panel3.TabIndex = 0;
            // 
            // Form5
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelbutton;
            this.ClientSize = new System.Drawing.Size(367, 491);
            this.Controls.Add(this.NoDBox);
            this.Controls.Add(this.TodayButton);
            this.Controls.Add(this.DateYear);
            this.Controls.Add(this.DateMonth);
            this.Controls.Add(this.DateDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IMDBBox);
            this.Controls.Add(this.MarkBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add a movie";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox ReviewTextBox;
        private System.Windows.Forms.CheckBox NoDBox;
        private System.Windows.Forms.CheckBox TodayButton;
        private System.Windows.Forms.TextBox DateYear;
        private System.Windows.Forms.ComboBox DateMonth;
        private System.Windows.Forms.ComboBox DateDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IMDBBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MarkBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox YearBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox AddBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.CheckBox TBDBox;
    }
}