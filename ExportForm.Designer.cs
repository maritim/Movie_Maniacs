namespace Movie_Maniacs
{
    partial class ExportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportForm));
            this.NameBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.YearBox = new System.Windows.Forms.CheckBox();
            this.MarkBox = new System.Windows.Forms.CheckBox();
            this.DateBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.AutoSize = true;
            this.NameBox.Checked = true;
            this.NameBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NameBox.Enabled = false;
            this.NameBox.Location = new System.Drawing.Point(6, 19);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(54, 17);
            this.NameBox.TabIndex = 0;
            this.NameBox.Text = "Name";
            this.NameBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.YearBox);
            this.groupBox1.Controls.Add(this.MarkBox);
            this.groupBox1.Controls.Add(this.DateBox);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export options";
            // 
            // YearBox
            // 
            this.YearBox.AutoSize = true;
            this.YearBox.Checked = true;
            this.YearBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.YearBox.Location = new System.Drawing.Point(6, 42);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(48, 17);
            this.YearBox.TabIndex = 0;
            this.YearBox.Text = "Year";
            this.YearBox.UseVisualStyleBackColor = true;
            // 
            // MarkBox
            // 
            this.MarkBox.AutoSize = true;
            this.MarkBox.Checked = true;
            this.MarkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MarkBox.Location = new System.Drawing.Point(6, 65);
            this.MarkBox.Name = "MarkBox";
            this.MarkBox.Size = new System.Drawing.Size(50, 17);
            this.MarkBox.TabIndex = 0;
            this.MarkBox.Text = "Mark";
            this.MarkBox.UseVisualStyleBackColor = true;
            // 
            // DateBox
            // 
            this.DateBox.AutoSize = true;
            this.DateBox.Location = new System.Drawing.Point(6, 88);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(49, 17);
            this.DateBox.TabIndex = 0;
            this.DateBox.Text = "Date";
            this.DateBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select export options";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 185);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox NameBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox YearBox;
        private System.Windows.Forms.CheckBox MarkBox;
        private System.Windows.Forms.CheckBox DateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}