using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Movie_Maniacs
{
    public partial class RecommandationsForm : Form
    {
        private List<ListViewMovie> Movies = new List<ListViewMovie>();
        public string link;
        private string Movie_Name;
        public bool updated;

        public RecommandationsForm()
        {
            InitializeComponent();
        }

        private void AddControls()
        {
            for (int i = 0; i < 10; i++)
            {
                PictureBox pbox = new PictureBox();
                pbox.Size = new Size(75, 104);
                pbox.Location = new Point(78 * i, 8);
                pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                pbox.Image = WorkerClass.WebImage(Movies[i].PosterLink);
                pbox.BorderStyle = BorderStyle.FixedSingle;
                pbox.Cursor = Cursors.Hand;
                pbox.Tag = i.ToString();
                pbox.Click += new EventHandler(pbox_Click);

                splitContainer1.Panel1.Controls.Add(pbox);
            }
        }

        void pbox_Click(object sender, EventArgs e)
        {
            Update_Movie_Details(Movies[int.Parse(((PictureBox)sender).Tag.ToString())]);
        }

        private void Take_Reccommandations_Movies()
        {
            try
            {
                string sourceCode = WorkerClass.GetSourceCode("http://www.imdb.com/movies-in-theaters/");

                int startIndex = sourceCode.IndexOf("Box");
                int endIndex = 0;

                for (int i = 1; i <= 10; i++)
                {
                    ListViewMovie movie = new ListViewMovie(true);

                    startIndex = sourceCode.IndexOf("class=\"poster shadowed", startIndex);


                    //Take Movie Name
                    startIndex = sourceCode.IndexOf("title=\"", startIndex) + "title=\"".Length;
                    endIndex = sourceCode.IndexOf("\"", startIndex);
                    movie.Movie_Name = sourceCode.Substring(startIndex, endIndex - startIndex);

                    //Take Poster Link
                    startIndex = sourceCode.IndexOf("src", startIndex) + 5;
                    endIndex = sourceCode.IndexOf("\"", startIndex);
                    movie.PosterLink = sourceCode.Substring(startIndex, endIndex - startIndex);

                    //Take Link
                    startIndex = sourceCode.IndexOf("href", startIndex) + 6;
                    endIndex = sourceCode.IndexOf("\"", startIndex);
                    movie.Set_IMDB_Adress("http://www.imdb.com" + sourceCode.Substring(startIndex, endIndex - startIndex));

                    //Take the movie Mark
                    startIndex = sourceCode.IndexOf("class=\"value\">", startIndex) + 14;
                    endIndex = sourceCode.IndexOf("<", startIndex);
                    movie.Mark = sourceCode.Substring(startIndex, endIndex - startIndex);

                    //Take Description
                    startIndex = sourceCode.IndexOf("itemprop=\"description\">", startIndex) + 23;
                    endIndex = sourceCode.IndexOf("<", startIndex);
                    movie.Storyline = sourceCode.Substring(startIndex, endIndex - startIndex);

                    //Take Movie Informations (Dynamically)
                    //movie.Update_Movie();

                    Movies.Add(movie);
                }
            }
            catch
            {
                MessageBox.Show("An error occured while trying to take Reccommandations!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public void Update_PictureBox()
        {
            MoviePoster.Image = null;
            MoviePoster.Image = WorkerClass.WebImage(WorkerClass.MoviePoster(link));
        }

        private void Update_Movie_Details(ListViewMovie Movie)
        {
            link = Movie.Get_IMDB_Adress();
            Movie_Name = Movie.Movie_Name;

            toolTip1.SetToolTip(button1,"Add \"" + Movie.Movie_Name + "\" to your movie list.");

            Thread thread = new Thread(new ThreadStart(Update_PictureBox));
            thread.Start();

            Title.Text = Movie.Movie_Name;

            Description.Text = Movie.Storyline;

            TopPicture.Size = new Size((int)(25.2 * double.Parse(Movie.Mark)), 20);
            MarkBox.Text = "Mark : " + Movie.Mark;

            axShockwaveFlash1.Movie = "http://www.youtube.com/v/"+ WorkerClass.Movie_Trailer_Link(Movie.Movie_Name)[0].Key;
        }

        private void RecommandationsForm_Load(object sender, EventArgs e)
        {
            Take_Reccommandations_Movies();
            AddControls();
            Update_Movie_Details(Movies[0]);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(link);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.youtube.com/results?search_query=" + Movie_Name.Replace(" ", "+"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovieClass movie = new MovieClass();
            movie.Movie_Name = Title.Text;
            movie.Set_IMDB_Adress(link);

            Form4 form = new Form4(movie);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.Cancel)
                return;

            DataBaseManipulation.InsertMovie(movie);
            movie.Update_Movie();

            updated = true;
        }
    }
}
