using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace Movie_Maniacs
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Complete_Year_Box()
        {
            for (int i = 1900; i <= DateTime.Now.Year; i++)
                YearBox.Items.Add(i.ToString());
        }

        private void Complete_Mark_Box()
        {
            for (double i = 1; i <= 10; i += 0.01)
                MarkBox.Items.Add(i);
        }

        private void Complete_Date_Picker_Box()
        {
            datePicker.Value = DateTime.Now; 
        }

        private void Enable_All()
        {
            DateDay.Enabled = true;
            DateMonth.Enabled = true;
            DateYear.Enabled = true;
            datePicker.Enabled = true;
            NoDBox.Enabled = true;
            TodayButton.Enabled = true;
            TBDBox.Enabled = true;
        }

        private void Disable_All()
        {
            DateDay.Enabled = false;
            DateMonth.Enabled = false;
            DateYear.Enabled = false;
            datePicker.Enabled = false;
            NoDBox.Enabled = false;
            TodayButton.Enabled = false;
            TBDBox.Enabled = false;
        }

        private void NoDBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NoDBox.Checked == true || TodayButton.Checked == true || TBDBox.Checked == true)
                Disable_All();
            else if (NoDBox.Checked == false && TodayButton.Checked == false && TBDBox.Checked == false)
                Enable_All();

            if (TodayButton.Checked == true)
                TodayButton.Enabled = true;

            if (NoDBox.Checked == true)
                NoDBox.Enabled = true;

            if (TBDBox.Checked == true)
                TBDBox.Enabled = true;
        }

        private void Create_Movie_File()
        {
            try
            {
                MovieClass Movie = new MovieClass();

                Movie.Movie_Name = AddBox.Text;
                Movie.Set_Year(YearBox.Text);
                Movie.Set_Mark(MarkBox.Text);
                if (IMDBBox.Text.IndexOf("http") == -1)
                    IMDBBox.Text = "http://" + IMDBBox.Text;
                Movie.Set_IMDB_Adress(IMDBBox.Text);
                if (TBDBox.Checked == true)
                    Movie.Set_Date("-1", "-1", "-1");
                else if ((NoDBox.Checked == true || DateMonth.Text == "Month" || DateDay.Text == "Day" || DateYear.Text == "Year") && TodayButton.Checked == false)
                    Movie.Set_Date("0", "0", "0");
                else if (TodayButton.Checked == true)
                    Movie.Set_Date(DateTime.Now.Day.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());
                else
                    Movie.Set_Date(DateDay.Text, DateMonth.Text, DateYear.Text);
                
                Movie.Update_Informations();
            }
            catch
            { 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddBox.Text == "")
                {
                    MessageBox.Show("Please enter an available name for movie!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (DataBaseManipulation.ExistMovie(AddBox.Text))
                    if (MessageBox.Show("This movie already exist!\nDo you want to overwrite?", "The movie already exist!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;

                Create_Movie_File();

                MessageBox.Show("\"" + AddBox.Text + "\" was successfully added!", "Adding successfully!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            catch
            { 
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Complete_Year_Box();
            Complete_Mark_Box();
            Complete_Date_Picker_Box();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Process.Start("http://www.imdb.com/find?q="+AddBox.Text.Replace(" ","+")+"&s=all");
            SearchForm form = new SearchForm(AddBox.Text);

            form.ShowDialog();

            if(form.Link != "" && form.Link != null)
                IMDBBox.Text = "http://www.imdb.com"+form.Link;
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            DateDay.Text = datePicker.Value.Day.ToString();
            DateMonth.Text = datePicker.Value.Month.ToString();
            DateYear.Text = datePicker.Value.Year.ToString();
        }
    }
}
