using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Movie_Maniacs
{
    public partial class Form4 : Form
    {
        private MovieClass Movie = new MovieClass();

        public Form4(MovieClass MovieCl)
        {
            InitializeComponent();
            Movie = MovieCl;
        }

        
        void Complete_Mark_ComboBox()
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
        }

        private void Disable_All()
        {
            DateDay.Enabled = false;
            DateMonth.Enabled = false;
            DateYear.Enabled = false;
            datePicker.Enabled = false;
            NoDBox.Enabled = false;
            TodayButton.Enabled = false;
        }

        private void NoDBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NoDBox.Checked == true || TodayButton.Checked == true)
                Disable_All();
            else if (NoDBox.Checked == false && TodayButton.Checked == false)
                Enable_All();

            if (TodayButton.Checked == true)
                TodayButton.Enabled = true;

            if (NoDBox.Checked == true)
                NoDBox.Enabled = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Complete_Mark_ComboBox();
            Complete_Date_Picker_Box();
            DateDay.Text = "Day"; DateMonth.Text = "Month"; DateYear.Text = "Year";

            AddBox.Text = Movie.Movie_Name;
            IMDBBox.Text = Movie.Get_IMDB_Adress();
            MarkBox.Text = Movie.Get_Mark();

            if (Movie.Get_Date_Day() == 0)
            {
                Disable_All();
                NoDBox.Checked = true;
            }
            else
            {
                DateMonth.Text = Movie.Get_Date_Month().ToString();
                DateDay.Text = Movie.Get_Date_Day().ToString();
                DateYear.Text = Movie.Get_Date_Year().ToString(); 
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (DataBaseManipulation.ExistMovie(AddBox.Text) && AddBox.Text.ToUpper() != Movie.Movie_Name.ToUpper())
            {
                MessageBox.Show(AddBox.Text + " movie already exist!","The movie already exist! You have to type another name!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                return;
            }

            string LastName = Movie.Movie_Name;
            Movie.Movie_Name = AddBox.Text;
            Movie.Set_IMDB_Adress(IMDBBox.Text);
            Movie.Set_Mark(MarkBox.Text);
            if (NoDBox.Checked == true)
                Movie.Set_Date("0", "0", "0");
            else if (TodayButton.Checked == true)
                Movie.Set_Date(DateTime.Today.Day.ToString(), DateTime.Today.Month.ToString(), DateTime.Today.Year.ToString());
            else
                Movie.Set_Date(DateDay.Text, DateMonth.Text, DateYear.Text);

            OleDbDataReader reader = DataBaseManipulation.MovieDBReader(LastName);
            reader.Read();

            try
            {
                DataBaseManipulation.UpdateMovie(Movie, int.Parse(reader["Index"].ToString()));
            }
            catch
            {
            }

            MessageBox.Show("\""+Movie.Movie_Name + "\" was successfully updated!","Successfully updated!");

            this.Close();

            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            this.DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm(Movie.Movie_Name);

            form.ShowDialog();

            if (form.Link != "")
                IMDBBox.Text = "http://www.imdb.com" + form.Link;
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            DateDay.Text = datePicker.Value.Day.ToString();
            DateMonth.Text = datePicker.Value.Month.ToString();
            DateYear.Text = datePicker.Value.Year.ToString();
        }
    }
}
