using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Movie_Maniacs
{
    public partial class PrivacyPolicy : Form
    {
        public PrivacyPolicy()
        {
            InitializeComponent();
        }

        private void PrivacyPolicy_Load(object sender, EventArgs e)
        {
            textBox1.SelectionAlignment = HorizontalAlignment.Center;
            textBox1.Text = "Information courtesy of"+Environment.NewLine+"The Internet Movie Database"+Environment.NewLine+"(http://www.imdb.com)."+Environment.NewLine+"Used with permission.";
            richTextBox1.Rtf = @"{\rtf1\ansi You are free to distribute, copy and share this software on internet as long as it is used for \b non commercial \b0 purposes.}";
            richTextBox2.Rtf = @"{\rtf1\ansi Copyright (C) 2012 \b maritim \b0 Creations}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
