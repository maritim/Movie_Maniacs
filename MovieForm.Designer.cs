namespace Movie_Maniacs
{
    partial class MovieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieForm));
            this.MoviePoster = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Director = new System.Windows.Forms.TextBox();
            this.asdsad = new System.Windows.Forms.Label();
            this.ViewTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MovieName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Actors = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Runtime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Language = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviePoster
            // 
            this.MoviePoster.Location = new System.Drawing.Point(47, 100);
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.Size = new System.Drawing.Size(214, 317);
            this.MoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePoster.TabIndex = 0;
            this.MoviePoster.TabStop = false;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.Control;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(237, 39);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(409, 20);
            this.Title.TabIndex = 1;
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Year
            // 
            this.Year.BackColor = System.Drawing.SystemColors.Control;
            this.Year.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Year.Location = new System.Drawing.Point(375, 130);
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Size = new System.Drawing.Size(100, 13);
            this.Year.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Genre";
            // 
            // Genre
            // 
            this.Genre.BackColor = System.Drawing.SystemColors.Control;
            this.Genre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Genre.Location = new System.Drawing.Point(376, 158);
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Size = new System.Drawing.Size(275, 13);
            this.Genre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Director";
            // 
            // Director
            // 
            this.Director.BackColor = System.Drawing.SystemColors.Control;
            this.Director.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Director.Location = new System.Drawing.Point(376, 186);
            this.Director.Name = "Director";
            this.Director.ReadOnly = true;
            this.Director.Size = new System.Drawing.Size(275, 13);
            this.Director.TabIndex = 6;
            // 
            // asdsad
            // 
            this.asdsad.AutoSize = true;
            this.asdsad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asdsad.Location = new System.Drawing.Point(292, 291);
            this.asdsad.Name = "asdsad";
            this.asdsad.Size = new System.Drawing.Size(78, 13);
            this.asdsad.TabIndex = 5;
            this.asdsad.Text = "Viewing time";
            // 
            // ViewTime
            // 
            this.ViewTime.BackColor = System.Drawing.SystemColors.Control;
            this.ViewTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewTime.Location = new System.Drawing.Point(376, 291);
            this.ViewTime.Name = "ViewTime";
            this.ViewTime.ReadOnly = true;
            this.ViewTime.Size = new System.Drawing.Size(275, 13);
            this.ViewTime.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name";
            // 
            // MovieName
            // 
            this.MovieName.BackColor = System.Drawing.SystemColors.Control;
            this.MovieName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MovieName.Location = new System.Drawing.Point(376, 100);
            this.MovieName.Name = "MovieName";
            this.MovieName.ReadOnly = true;
            this.MovieName.Size = new System.Drawing.Size(275, 13);
            this.MovieName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Actors";
            // 
            // Actors
            // 
            this.Actors.BackColor = System.Drawing.SystemColors.Control;
            this.Actors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Actors.Location = new System.Drawing.Point(376, 214);
            this.Actors.Multiline = true;
            this.Actors.Name = "Actors";
            this.Actors.ReadOnly = true;
            this.Actors.Size = new System.Drawing.Size(275, 71);
            this.Actors.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(298, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Description";
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.SystemColors.Control;
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description.Location = new System.Drawing.Point(376, 373);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Size = new System.Drawing.Size(275, 71);
            this.Description.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(316, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Runtime";
            // 
            // Runtime
            // 
            this.Runtime.BackColor = System.Drawing.SystemColors.Control;
            this.Runtime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Runtime.Location = new System.Drawing.Point(376, 318);
            this.Runtime.Name = "Runtime";
            this.Runtime.ReadOnly = true;
            this.Runtime.Size = new System.Drawing.Size(275, 13);
            this.Runtime.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Language";
            // 
            // Language
            // 
            this.Language.BackColor = System.Drawing.SystemColors.Control;
            this.Language.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Language.Location = new System.Drawing.Point(376, 343);
            this.Language.Name = "Language";
            this.Language.ReadOnly = true;
            this.Language.Size = new System.Drawing.Size(275, 13);
            this.Language.TabIndex = 6;
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(682, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.Runtime);
            this.Controls.Add(this.ViewTime);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Actors);
            this.Controls.Add(this.Director);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.asdsad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MovieName);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.MoviePoster);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.MovieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Director;
        private System.Windows.Forms.Label asdsad;
        private System.Windows.Forms.TextBox ViewTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MovieName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Actors;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Runtime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Language;
        private System.Windows.Forms.PictureBox MoviePoster;
    }
}