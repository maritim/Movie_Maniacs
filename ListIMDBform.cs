using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Movie_Maniacs
{
    public partial class ListIMDBform : Form
    {
        public ListIMDBform()
        {
            InitializeComponent();
        }

        private List<ListViewMovie> Movies = new List<ListViewMovie>();
        private bool added;

        private void ListIMDBform_Load(object sender, EventArgs e)
        {
            AddBox.Focus();

            added = false;
        }

        private void Take_IMDB_List(string link)
        {
            if (link.IndexOf("http://") < 0)
                link = "http://" + link;

            string sourceCode = WorkerClass.GetSourceCode(link);
            string imageCode = null;

            int startIndex = sourceCode.IndexOf("data-size=\"")+11;
            int endIndex = sourceCode.IndexOf("\"", startIndex);
            int startImgIndex,startVerIndex,startVerIndex2;
            int Poz = 0;

            int datasize = int.Parse(sourceCode.Substring(startIndex, endIndex - startIndex));
            int NrOfPages = datasize/100 + ((datasize%100 > 0) ? 1 : 0);

            for (int i = 0; i < NrOfPages; i++)
            {
                sourceCode = WorkerClass.GetSourceCode(link + "?start=" + (i * 100 + 1).ToString());

                startIndex = sourceCode.IndexOf("list_item");

                for (; startIndex > 0; )
                {
                    ListViewMovie movie = new ListViewMovie();

                    movie.Pozition = ++Poz;

                    //Load Image Link
                    startIndex = sourceCode.IndexOf("<img", startIndex);
                    endIndex = sourceCode.IndexOf(">", startIndex);

                    imageCode = sourceCode.Substring(startIndex, endIndex - startIndex);

                    startImgIndex = imageCode.IndexOf("http://ia.media-imdb.com");
                    if (startImgIndex < 0) startImgIndex = imageCode.IndexOf("src=\"")+5;
                    endIndex = imageCode.IndexOf("\"", startImgIndex);

                    movie.PosterLink = imageCode.Substring(startImgIndex, endIndex - startImgIndex);

                    //Load Movie Link to IMDB
                    startIndex = sourceCode.IndexOf("href=\"/title/", startIndex) + 6;
                    endIndex = sourceCode.IndexOf("\"", startIndex);

                    movie.Set_IMDB_Adress("http://www.imdb.com" + sourceCode.Substring(startIndex, endIndex - startIndex));

                    //Load Name of the movie
                    startIndex = sourceCode.IndexOf(">", startIndex) + 1;
                    endIndex = sourceCode.IndexOf("<", startIndex);

                    movie.MovieName = WorkerClass.StringWithoutHtmlFormat(sourceCode.Substring(startIndex, endIndex - startIndex));

                    //Load Year of the movie
                    startIndex = sourceCode.IndexOf("class=\"year_type\">", startIndex);
                    startIndex = sourceCode.IndexOf("(", startIndex) + 1;
                    endIndex = sourceCode.IndexOf(")", startIndex);

                    movie.Set_Year(sourceCode.Substring(startIndex, endIndex - startIndex));

                    //Load Mark from IMDB
                    startIndex = sourceCode.IndexOf("class=\"value\">", startIndex) + 14;
                    endIndex = sourceCode.IndexOf("<", startIndex);

                    movie.Mark = sourceCode.Substring(startIndex, endIndex - startIndex);

                    //Load IMDB Description
                    startVerIndex = sourceCode.IndexOf("item_description", startIndex);
                    startVerIndex2 = sourceCode.IndexOf("secondary", startIndex);
                    if (startVerIndex < startVerIndex2)
                    {
                        startIndex = sourceCode.IndexOf("item_description\">", startIndex) + 18;
                        endIndex = sourceCode.IndexOf("<", startIndex);

                        movie.Storyline = WorkerClass.StringWithoutHtmlFormat(sourceCode.Substring(startIndex, endIndex - startIndex));
                    }
                    else
                        movie.Storyline = "";

                    startIndex = sourceCode.IndexOf("list_item", startIndex);

                    Movies.Add(movie);
                }
            }
 
        }

        private void Put_Movie_OnTheList(List<ListViewMovie> Movies)
        {
            ListOfMovies.Items.Clear();

            foreach (ListViewMovie movie in Movies)
            {
                ListViewItem item = new ListViewItem(movie.Pozition.ToString());
                item.SubItems.Add(movie.MovieName);

                ListOfMovies.Items.Add(item);
            }
        }

        private void Load_IMDB_List(string link)
        {
            try
            {
                Movies.Clear();

                Take_IMDB_List(link);

                Put_Movie_OnTheList(Movies);

                ListOfMovies.Items[0].Selected = true;

                Addbutton.Visible = true;
            }
            catch
            {
                MessageBox.Show("An error occured while trying to import the list. Please verify again your ethernet connection or your IMDb address!"
                    , "Error while trying to import", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Load_IMDB_List(AddBox.Text);
        }

        private void UpdateMovieInformations(ListViewMovie movie)
        {
            try
            {
                PosterImage.Image = WorkerClass.WebImage(movie.PosterLink);
                TopPicture.Size = new Size((int)(float.Parse(movie.Mark)/10*252),20);
                BottomPicture.Visible = TopPicture.Visible = true;
                NameBox.Text = movie.Pozition.ToString() + ". " + movie.MovieName + " (" + movie.Get_Year() + ")";
                DescriptionBox.Text = movie.Storyline;
                MarkBox.Text = movie.Mark + "/10";
            }
            catch
            {
            }
        }

        private void ListOfMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = ListOfMovies.SelectedIndices[0];

                UpdateMovieInformations(Movies[index]);
            }
            catch
            {
            }
        }

        private void ListIMDBform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void visitIMDbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Movies[ListOfMovies.SelectedIndices[0]].Get_IMDB_Adress());
            }
            catch
            {

            }
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MovieClass Movie = new MovieClass();
                Movie = Movies[ListOfMovies.SelectedIndices[0]];
                Movie.Update_Movie();
                Movie.Movie_Name = Movies[ListOfMovies.SelectedIndices[0]].MovieName;

                Thread.Sleep(1000);

                MovieForm form = new MovieForm(Movie);
                form.ShowDialog();

                form.Dispose();
                WorkerClass.DeleteFolder(Movie.Movie_Name);

            }
            catch
            {
 
            }
        }

        private void AddBox_TextChanged(object sender, EventArgs e)
        {
            AddBox.Text = "";
        }

        public bool Updated
        {
            get
            {
                return added;
            }
            set
            {
                added = value;
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            MovieClass Movie = new MovieClass();
            Movie = Movies[ListOfMovies.SelectedIndices[0]];
            Movie.Movie_Name = WorkerClass.AvailableFolderName(Movies[ListOfMovies.SelectedIndices[0]].MovieName);

            Movie.Update_Movie();

            WorkerClass.WriteFile("Movies.txt", Movie.Movie_Name, true);

            Form4 form = new Form4(Movie);

            if (form.ShowDialog() == DialogResult.Cancel)
                WorkerClass.DeleteFolder(Movie.Movie_Name);
            else
                added = true;
        }
    }
}
