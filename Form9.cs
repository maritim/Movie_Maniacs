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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            try
            {
                LanguageBox.Text = "Language: Romanian";
                axAcroPDF1.src = "http://maritimsoftware.xhost.ro/PDFs/Movie_Maniacs_Documentatie.pdf";
            }
            catch
            {
                MessageBox.Show("An error occured while trying to access Movie Maniacs Official Site!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void romanianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LanguageBox.Text = "Language: Romanian";
                axAcroPDF1.src = "http://maritimsoftware.xhost.ro/PDFs/Movie_Maniacs_Documentatie.pdf";
            }
            catch
            {
                MessageBox.Show("An error occured while trying to access Movie Maniacs Official Site!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LanguageBox.Text = "Language: English";
                axAcroPDF1.src = "http://maritimsoftware.xhost.ro/PDFs/Movie_Maniacs_Documentatie.pdf";
            }
            catch
            {
                MessageBox.Show("An error occured while trying to access Movie Maniacs Official Site!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
