using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Movie_Maniacs
{
    public partial class MovieForm : Form
    {
        private MovieClass Movie = new MovieClass();

        public MovieForm(MovieClass movie)
        {
            InitializeComponent();

            Movie = movie;
        }

        private void Load_Poster()
        { 
            try
            {
                if (File.Exists("images\\" + Movie.Index.ToString() + ".jpg"))
                    MoviePoster.ImageLocation = "images\\" + Movie.Index.ToString() + ".jpg";
                else
                    MoviePoster.ImageLocation = "film.png";
            }
            catch
            {
                MoviePoster.ImageLocation = "film.png";
            }
        }

        private void Load_Informations()
        {
            try
            {
                MovieName.Text = Movie.Get_IMDB_Name();
                Title.Text = Movie.Movie_Name;
                Year.Text = Movie.Get_Year();
                Genre.Text = Movie.Get_Genre(0);
                for (int i = 1; i < Movie.Get_Genre().Count; i++)
                    Genre.Text += ", " + Movie.Get_Genre(i);
                Director.Text = Movie.Director;
                if (Movie.Get_Date_Day() != 0)
                    ViewTime.Text = Movie.Get_Date_Month() + "/" + Movie.Get_Date_Day() + "/" + Movie.Get_Date_Year();
                else
                    ViewTime.Text = "Unknown";
                Actors.Text = Movie.Get_Star(0).Substring(0,Movie.Get_Star(0).IndexOf("/"));
                for (int i = 0; i < Movie.Get_Stars().Count; i++)
                {
                    int startIndex = Movie.Get_Star(i).IndexOf("/");

                    Actors.Text += ", " + Movie.Get_Star(i).Substring(0,startIndex);
                }
                Description.Text = WorkerClass.String_Whitout_New_Lines(Movie.Storyline);
                Runtime.Text = Movie.Runtime;
                Language.Text = Movie.Get_Language(0);
                for (int i = 1; i < Movie.Get_Language().Count; i++)
                    Language.Text += ", " + Movie.Get_Language(i);
            }
            catch
            {
                this.Dispose();
                MessageBox.Show("Unavailable to load the informations!", "Unavailable ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
            Load_Poster();
            Load_Informations();

            Title.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(Movie.Movie_Name,Movie.Index, Movie.ActorDetailsNumber, Movie.Get_Stars(), Movie.Get_StarsLink());

            form.Text = Movie.Movie_Name + "'s stars";

            form.ShowDialog();
        }
    }
}
