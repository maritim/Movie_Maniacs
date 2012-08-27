using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Movie_Maniacs
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        public DialogResult Result = DialogResult.Cancel;
        List<string> Movies;

        private void Form7_Load(object sender, EventArgs e)
        {
            Movies = DataBaseManipulation.MovieDetails("Name");

            foreach(string Movie in Movies)
                MovieList.Items.Add(Movie);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                Update_All();

                MessageBox.Show("All movies were successfully updated!", "Successfully updated",MessageBoxButtons.OK,MessageBoxIcon.Information);

                Result = DialogResult.OK;
            }
            catch
            {
                return;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_All()
        {
            UpdatingForm form = new UpdatingForm(MovieList);

            form.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAllButton.Checked)
                for (int i = 0; i < MovieList.Items.Count; i++)
                    MovieList.SetItemChecked(i, true);
            else
                for (int i = 0; i < MovieList.Items.Count; i++)
                    MovieList.SetItemChecked(i, false);
        }
    }
}
