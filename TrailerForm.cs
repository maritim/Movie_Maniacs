using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Movie_Maniacs;
using System.Threading;

namespace Movie_Maniacs
{
    public partial class TrailerForm : Form
    {
        MovieClass Movie = new MovieClass();
        List<KeyValuePair<string, string>> Movies;

        public TrailerForm(MovieClass movie)
        {
            InitializeComponent();

            Movie = movie;

            this.Text = Movie.Movie_Name + "'s Trailer";
        }

        private void TakeTrailerMovieList(MovieClass Movie)
        {
            try
            {
                if (Movie.Get_IMDB_Name() != null)
                    Movies = WorkerClass.Movie_Trailer_Link(Movie.Get_IMDB_Name());
                else
                    Movies = WorkerClass.Movie_Trailer_Link(Movie.Movie_Name);
            }
            catch
            {
                return;
            }
        }

        private void TakeYouTubeVideosTumbnails()
        {
            try
            {
                foreach (KeyValuePair<string, string> movie in Movies)
                    YouTubeVideosImages.Images.Add(WorkerClass.MovieTumbnailOnYouTube("http://www.youtube.com/watch?v=" + movie.Key));
            }
            catch
            {
                return;
            }
        }

        private void SetMovieTrailer(MovieClass Movie)
        {
            try
            {
                if (Movie.MovieTrailer == null || Movie.MovieTrailer == "")
                {
                    axShockwaveFlash1.Movie = "http://www.youtube.com/v/" + Movies[0].Key;
                    MovieListTrailers.Items[0].Selected = true;
                }
                else
                {
                    bool Exist = false;

                    axShockwaveFlash1.Movie = "http://www.youtube.com/v/" + Movie.MovieTrailer;

                    for (int i = 0; i < Movies.Count; i++)
                        if (Movies[i].Key == Movie.MovieTrailer)
                        {
                            MovieListTrailers.Items[i].Selected = true;
                            Exist = true;
                        }

                    if (!Exist)
                        AddMovieTrailer(Movie.MovieTrailer);
                }
            }
            catch
            {
                return;
            }
        }

        private void TrailerForm_Load(object sender, EventArgs e)
        {
            try
            {
                TakeTrailerMovieList(Movie);

                Thread thread = new Thread(new ThreadStart(TakeYouTubeVideosTumbnails));
                thread.Start();
                
                AddMoviesToList();

                SetMovieTrailer(Movie);
            }
            catch (Exception x)
            {
                this.Close();
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TrailerForm_Resize(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Maximized)
            //    splitContainer1.Panel1Collapsed = true;
            //else
            //    splitContainer1.Panel1Collapsed = false;
        }

        private void MovieListTrailers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                axShockwaveFlash1.Movie = "http://www.youtube.com/v/" + Movies[MovieListTrailers.SelectedIndices[0]].Key;
            }
            catch
            { 
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Movies.Remove(Movies[MovieListTrailers.SelectedIndices[0]]);
                MovieListTrailers.SelectedItems[0].Remove();
            }
            catch
            {
                MessageBox.Show("Please select a movie before trying this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Fullscreen();
            }
            catch
            {
 
            }
        }

        private void Fullscreen()
        {
            axShockwaveFlash1.Height = Screen.PrimaryScreen.Bounds.Height;
            axShockwaveFlash1.Width = Screen.PrimaryScreen.Bounds.Width;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            //this.Size = new Size(Screen.PrimaryScreen.Bounds.Width+100, Screen.PrimaryScreen.Bounds.Height+100);
            this.TopMost = true;
        }

        private void CloseFullscreen()
        {
            axShockwaveFlash1.Height = splitContainer1.Panel2.Height;
            axShockwaveFlash1.Width = splitContainer1.Panel2.Width;
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            //this.Size = new Size(679, 395);
            this.TopMost = false;
        }

        private void TrailerForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    if (WindowState == FormWindowState.Maximized)
                        CloseFullscreen();
                    else
                        this.Close();
                }
            }
            catch
            {
 
            }
        }

        private void setOfficialTrailerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movie.MovieTrailer = Movies[MovieListTrailers.SelectedIndices[0]].Key;

            Movie.Update_Informations();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    AddMovieTrailer(SearchBox.Text);
            }
            catch
            {
                MessageBox.Show("Please type a valid YouTube link!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void AddMoviesToList()
        {
            int i = -1;

            MovieListTrailers.Items.Clear();

            foreach (KeyValuePair<string, string> movies in Movies)
            {
                ListViewItem item = new ListViewItem("", ++i);

                item.SubItems.Add(movies.Value);

                MovieListTrailers.Items.Add(item);
            }
        }

        private void AddMovieTrailer(string link)
        {
            try
            {
                string link2 = link;
                if (link2.IndexOf("http://www.youtube.com/watch?v=") < 0)
                    link2 = "http://www.youtube.com/watch?v=" + link2;
                string name = WorkerClass.MovieNameOnYouTube(link2);
                YouTubeVideosImages.Images.Add(WorkerClass.MovieTumbnailOnYouTube(link2));

                ListViewItem item = new ListViewItem("", YouTubeVideosImages.Images.Count - 1);
                item.SubItems.Add(name);
                item.Selected = true;
                Movies.Add(new KeyValuePair<string, string>(WorkerClass.ValidYouTubeLink(link), name));
                MovieListTrailers.Items.Add(item);
            }
            catch
            {
                return;
            }
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            SearchBox.Text = "";
        }
    }
}
