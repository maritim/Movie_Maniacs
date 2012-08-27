namespace Movie_Maniacs
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoDBox
            // 
            this.NoDBox.AutoSize = true;
            this.NoDBox.Location = new System.Drawing.Point(115, 218);
            this.NoDBox.Name = "NoDBox";
            this.NoDBox.Size = new System.Drawing.Size(66, 17);
            this.NoDBox.TabIndex = 25;
            this.NoDBox.Text = "No Date";
            this.NoDBox.UseVisualStyleBackColor = true;
            this.NoDBox.CheckedChanged += new System.EventHandler(this.NoDBox_CheckedChanged);
            // 
            // TodayButton
            // 
            this.TodayButton.AutoSize = true;
            this.TodayButton.Location = new System.Drawing.Point(189, 218);
            this.TodayButton.Name = "TodayButton";
            this.TodayButton.Size = new System.Drawing.Size(56, 17);
            this.TodayButton.TabIndex = 24;
            this.TodayButton.Text = "Today";
            this.TodayButton.UseVisualStyleBackColor = true;
            this.TodayButton.CheckedChanged += new System.EventHandler(this.NoDBox_CheckedChanged);
            // 
            // DateYear
            // 
            this.DateYear.Location = new System.Drawing.Point(234, 178);
            this.DateYear.Name = "DateYear";
            this.DateYear.Size = new System.Drawing.Size(51, 20);
            this.DateYear.TabIndex = 23;
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
            this.DateMonth.Location = new System.Drawing.Point(165, 177);
            this.DateMonth.Name = "DateMonth";
            this.DateMonth.Size = new System.Drawing.Size(63, 21);
            this.DateMonth.TabIndex = 22;
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
            this.DateDay.Location = new System.Drawing.Point(115, 177);
            this.DateDay.Name = "DateDay";
            this.DateDay.Size = new System.Drawing.Size(44, 21);
            this.DateDay.TabIndex = 21;
            this.DateDay.Text = "Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Date you saw";
            // 
            // IMDBBox
            // 
            this.IMDBBox.Location = new System.Drawing.Point(115, 109);
            this.IMDBBox.Name = "IMDBBox";
            this.IMDBBox.Size = new System.Drawing.Size(189, 20);
            this.IMDBBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "URL to IMDB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Your mark";
            // 
            // MarkBox
            // 
            this.MarkBox.FormatString = "N2";
            this.MarkBox.FormattingEnabled = true;
            this.MarkBox.IntegralHeight = false;
            this.MarkBox.Location = new System.Drawing.Point(115, 66);
            this.MarkBox.Name = "MarkBox";
            this.MarkBox.Size = new System.Drawing.Size(86, 21);
            this.MarkBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name of the movie";
            // 
            // AddBox
            // 
            this.AddBox.Location = new System.Drawing.Point(115, 24);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(189, 20);
            this.AddBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(113, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 27;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(32, 16);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 26);
            this.EditButton.TabIndex = 26;
            this.EditButton.Text = "OK";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 54);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EditButton);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(116, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 54);
            this.panel2.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(289, 178);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(15, 20);
            this.datePicker.TabIndex = 37;
            this.datePicker.Value = new System.DateTime(2012, 7, 27, 0, 0, 0, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // Form4
            // 
            this.AcceptButton = this.EditButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(316, 337);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.MarkBox);
            this.Controls.Add(this.NoDBox);
            this.Controls.Add(this.DateMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateDay);
            this.Controls.Add(this.TodayButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IMDBBox);
            this.Controls.Add(this.DateYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Window";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox AddBox;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}