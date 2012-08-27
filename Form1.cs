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
using System.Threading;

namespace Movie_Maniacs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MovieClass Movie = new MovieClass();
        private ColumnSorter TheColumnSorter = new ColumnSorter();
        private bool isHide = false;
        FormWindowState State;

        private void Update_MovieList()
        {
            MovieClass movie = new MovieClass();

            for (; MovieList.Items.Count > 0; MovieList.Items[0].Remove()) ;

            List<string> MovieNameList = DataBaseManipulation.MovieDetails("Name");

            foreach(string MovieName in MovieNameList)
            {
                movie = new MovieClass(MovieName);
                if (movie.Movie_Name != null)
                {
                    ListViewItem item = new ListViewItem(movie.Movie_Name);
                    item.SubItems.Add(movie.Get_Genre(0));
                    item.SubItems.Add(movie.Get_Mark());
                    item.SubItems.Add(movie.Get_Year());
                    item.SubItems.Add(movie.Director);
                    if (movie.Runtime != null)
                        item.SubItems.Add(movie.Runtime.Replace(" min", ""));
                    else
                        item.SubItems.Add("Unknown");
                    if (movie.Get_Date_Year() == -1)
                        item.SubItems.Add("Not yet viewed");
                    else if (movie.Get_Date_Year() == 0)
                        item.SubItems.Add("Unknown");
                    else
                        item.SubItems.Add(movie.Get_Date_Month().ToString() + "/" + movie.Get_Date_Day().ToString() + "/"
                            + movie.Get_Date_Year().ToString());
                    item.SubItems.Add(movie.Get_Country(0));
                    item.SubItems.Add(movie.Get_Language(0));
                    //item.SubItems.Add(Name);
                    MovieList.Items.Add(item);
                }
            }
        }

        private void Update_MovieList(int index)
        {
            try
            {
                MovieClass movie = new MovieClass(MovieList.Items[index].Text);

                MovieList.Items[index].Text = movie.Movie_Name;
                MovieList.Items[index].SubItems[1].Text = movie.Get_Genre(0);
                MovieList.Items[index].SubItems[2].Text = movie.Get_Mark();
                MovieList.Items[index].SubItems[3].Text = movie.Get_Year();
                MovieList.Items[index].SubItems[4].Text = movie.Director;
                if (movie.Runtime != null)
                    MovieList.Items[index].SubItems[5].Text = movie.Runtime.Replace(" min", "");
                else
                    MovieList.Items[index].SubItems[5].Text = "Unknown";
                if (movie.Get_Date_Year() == 0)
                    MovieList.Items[index].SubItems[6].Text = "Unknown";
                else
                    MovieList.Items[index].SubItems[6].Text = movie.Get_Date_Month().ToString() + "/" + movie.Get_Date_Day().ToString() + "/"
                        + movie.Get_Date_Year().ToString();
                MovieList.Items[index].SubItems[7].Text = movie.Get_Country(0);
                MovieList.Items[index].SubItems[8].Text = movie.Get_Language(0);
            }
            catch
            {
                return;
            }
        }

        private void Add_MovieToList(string movieName)
        {
            try
            {
                MovieClass movie = new MovieClass(movieName);

                ListViewItem item = new ListViewItem(movie.Movie_Name);
                item.SubItems.Add(movie.Get_Genre(1));
                item.SubItems.Add(movie.Get_Mark());
                item.SubItems.Add(movie.Get_Year());
                item.SubItems.Add(movie.Director);
                if (movie.Runtime != null)
                    item.SubItems.Add(movie.Runtime.Replace(" min", ""));
                else
                    item.SubItems.Add("Unknown");
                if (movie.Get_Date_Year() == -1)
                    item.SubItems.Add("Not viewed yet");
                else if (movie.Get_Date_Year() == 0)
                    item.SubItems.Add("Unknown");
                else
                    item.SubItems.Add(movie.Get_Date_Month().ToString() + "/" + movie.Get_Date_Day().ToString() + "/"
                        + movie.Get_Date_Year().ToString());
                item.SubItems.Add(movie.Get_Country(0));
                item.SubItems.Add(movie.Get_Language(0));
                //item.SubItems.Add(Name);
                MovieList.Items.Add(item);
            }
            catch
            {
                Error_Message();
            }
        }

        private void Set_Shortcut_Keys()
        {
            deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
        }

        private void Initialize_Default_Settings()
        {
            MovieList.ListViewItemSorter = TheColumnSorter;

            toolTip1.SetToolTip(DirectorWebLink, "");

            Movie.Set_IMDB_Adress("http://www.imdb.com"); 

            Thread thread = new Thread(new ThreadStart(Movie.Update_Movie));

            thread.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Update_MovieList();
                Set_Shortcut_Keys();
                Initialize_Default_Settings();

                UpdateList();
                Update_Movie_Details(Movie);

                //CheckUpdates.CheckforUpdates();
            }
            catch
            { 
            }
        }

        private void Update_Stars_Movie_Details()
        {
            List<string> Star = new List<string>();

            Star = Movie.Get_Stars();

            //StarList.Items.Clear();
            //StarsImageList.Images.Clear();

            for (; StarList.Items.Count > 0; )
            {
                StarList.Items.Remove(StarList.Items[0]);
                StarsImageList.Images.RemoveAt(0);
            }

            try
            {
                for (int i = 0; i <= Movie.ActorDetailsNumber; i++)
                {
                    int Index = Star[i].IndexOf("/");

                    StarsImageList.Images.Add(Image.FromFile("images\\" + Movie.Index.ToString() + " Stars\\" + Star[i].Substring(0, Index) + ".jpg"));

                    ListViewItem item = new ListViewItem("", i);

                    item.SubItems.Add(Star[i].Substring(0, Index));
                    item.SubItems.Add(Star[i].Substring(Index + 1, Star[i].Length - Index - 1));

                    StarList.Items.Add(item);
                }
            }
            catch
            {
                return;
            }
        }

        private void Update_Movie_Details(MovieClass Movie)
        {
            try
            {
                Size tempSize = new Size(252, 20);

                Update_Stars_Movie_Details();

                MoviePoster.ImageLocation = "images\\" + Movie.Index.ToString() + ".jpg";
                MovieName.Text = Movie.Movie_Name;

                try
                {
                    tempSize.Width = (int)(252 * float.Parse(Movie.Get_Mark()) / 10);
                    TopPicture.Size = tempSize;
                    TopPicture.Visible = true;
                    pictureBox2.Visible = true;
                }
                catch
                {
                    TopPicture.Visible = false;
                    pictureBox2.Visible = false;
                }

                try
                {
                    tempSize.Width = (int)(252 * float.Parse(Movie.Get_IMDB_Mark()) / 10);
                    TopPictureMark.Size = tempSize;
                    TopPictureMark.Visible = true;
                    pictureBox1.Visible = true;
                }
                catch
                {
                    TopPictureMark.Visible = false;
                    pictureBox1.Visible = false;
                }

                MarkName.Text = Movie.Get_Mark();
                if (Movie.Get_IMDB_Name() != null)
                    IMDBName.Text = "( " + Movie.Get_IMDB_Name() + " )";
                else
                    IMDBName.Text = "( " + Movie.Movie_Name + " ) - no Update";
                MovieNam.Text = Movie.Movie_Name;
                if (Movie.Get_IMDB_Mark() == null)
                    IMDBMarkDate.Text = "Unknown";
                else
                    IMDBMarkDate.Text = Movie.Get_IMDB_Mark();
                if ((Movie.Get_Date_Day() != 0 || Movie.Get_Date_Month() != 0 || Movie.Get_Date_Year() != 0) && Movie.Get_Date_Year() != -1)
                    DateDate.Text = Movie.Get_Date_Month().ToString() + "/" + Movie.Get_Date_Day().ToString() + "/" + Movie.Get_Date_Year().ToString();
                else if (Movie.Get_Date_Year() == -1)
                    DateDate.Text = "Not viewed yet";
                else
                    DateDate.Text = "Unknown";
                ReviewRichTextBox.Text = Movie.Get_Review().Replace(@"\n", Environment.NewLine);
                DirectorDate.Text = Movie.Director;
                DescriptionTextBox.Text = Movie.Storyline;

                try
                {
                    tempSize = new Size(61, 20);
                    YearDate.Size = tempSize;
                    YearDate.Text = int.Parse(Movie.Get_Year()).ToString();
                }
                catch
                {
                    tempSize = new Size(100, 20);
                    YearDate.Size = tempSize;
                    YearDate.Text = Movie.Get_Year();
                }

                List<string> Aux = new List<string>();

                ComboGenreDate.Items.Clear();
                ComboGenreDate.Text = Movie.Get_Genre(0);
                Aux = Movie.Get_Genre();
                foreach(string genre in Aux)
                    ComboGenreDate.Items.Add(genre);

                RuntimeDate.Text = Movie.Runtime;
                MPAAtext.Text = Movie.MPAA_Rating;

                CountryDate.Items.Clear();
                CountryDate.Text = Movie.Get_Country(0);
                Aux = Movie.Get_Country();
                foreach(string country in Aux)
                    CountryDate.Items.Add(country);

                LanguageDate.Items.Clear();
                LanguageDate.Text = Movie.Get_Language(0);
                Aux = Movie.Get_Language();
                foreach(string language in Aux)
                    LanguageDate.Items.Add(language);

                toolTip1.SetToolTip(DirectorWebLink, "Visit " + Movie.Director + "'s page");

                Tags.Items.Clear();
                if (Movie.Get_Tags().Count > 0)
                {
                    Tags.Text = Movie.Get_Tag(0);
                    foreach (string tag in Movie.Get_Tags())
                        Tags.Items.Add(tag);
                }
                else
                    Tags.Text = "Unknown";

                PrizesBox.Text = Movie.Prize;
                toolTip2.SetToolTip(OscarButton, "Visit " + Movie.Movie_Name + "'s Gallery of Trophies");
            }
            catch
            { 
            }
        }

        private void MovieList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MovieList.SelectedIndices.Count > 0)
            {
                Movie = new MovieClass(MovieList.SelectedItems[0].Text);

                Update_Movie_Details(Movie);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //UpdatingName.Text = Movie.Movie_Name+" is updating";
            //UpdateBar.Value = 0;

            try
            {
                if (WorkerClass.GetSourceCode(Movie.Get_IMDB_Adress()) == null)
                {
                    if(MessageBox.Show("Selected URL couldn't be accessed! Please check you interner connection or your URL again!", "Could not acces the selected URL",MessageBoxButtons.AbortRetryIgnore) == DialogResult.Retry)
                        button2_Click(sender, e) ;
                }
                else
                {
                    Movie.Update_Movie();
                    reloadToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("The movie was successfully updated!", "Successfully updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch
            {
                if (MessageBox.Show("An error occured while trying to update \"" + Movie.Movie_Name + "\" ! Please verify again the movie's IMDb adress or the connection to internet!", "Error"
                    , MessageBoxButtons.AbortRetryIgnore) == DialogResult.Retry)
                    button2_Click(sender, e);
            }

            //UpdatingName.Text = "It is not updating";
            //UpdateBar.Value = 0;
        }

        private void MoviePoster_Click(object sender, EventArgs e)
        {
            PosterForm newPoster = new PosterForm(Movie.Movie_Name,Movie.Index);

            newPoster.ShowDialog();

            Update_Movie_Details(Movie);
        }

        private void StarsButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 form = new Form3(Movie.Movie_Name,Movie.Index,Movie.ActorDetailsNumber, Movie.Get_Stars(), Movie.Get_StarsLink());
                form.Text = Movie.Movie_Name + "'s Stars";

                form.Show();
            }
            catch
            {
                Error_Message();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(Movie);
            form.Text = "Edit " + Movie.Movie_Name;

            form.Show();

            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Update_MovieList();
        }

        private void UpdateList()
        {
            try
            {
                int index = 0;
                string DefaultName = DataBaseManipulation.DefaultMovie().Movie_Name;

                Update_MovieList();

                for (index = 0; index < MovieList.Items.Count && MovieList.Items[index].Text != DefaultName; index++) ;

                if (index >= MovieList.Items.Count)
                {
                    Movie = new MovieClass(MovieList.Items[0].Text);
                    MovieList.Items[0].Selected = true;
                    Update_Movie_Details(Movie);
                }
                else
                {
                    Movie = new MovieClass(DefaultName);
                    MovieList.Items[index].Selected = true;
                    Update_Movie_Details(Movie);
                }
            }
            catch
            { }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form4 form = new Form4(Movie);
                form.Text = "Edit " + Movie.Movie_Name;

                if (form.ShowDialog() != DialogResult.Cancel)
                {
                    MovieList.SelectedItems[0].Text = form.AddBox.Text;
                    reloadToolStripMenuItem_Click(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Please select a movie to be edited!", "Select a movie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MovieForm form = new MovieForm(Movie);
                
                form.Text = Movie.Movie_Name;

                form.ShowDialog();
            }
            catch
            {
                return;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete \"" + Movie.Movie_Name + "\" movie?", "Delete movie", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    string DeletedMovie = MovieList.SelectedItems[0].Text;
                    MovieClass movie = new MovieClass(DeletedMovie);

                    if (Directory.Exists("images\\" + movie.Index.ToString() + " Stars"))
                        Directory.Delete("images\\" + movie.Index.ToString() + " Stars", true);
                    if (File.Exists("images\\" + movie.Index.ToString() + ".jpg"))
                        File.Delete("images\\" + movie.Index.ToString() + ".jpg");

                    DataBaseManipulation.DeleteMovieFromDB(DeletedMovie);

                    MovieList.SelectedItems[0].Remove();

                    if (MovieList.Items.Count > 0)
                    {
                        if (DataBaseManipulation.DefaultMovie().Movie_Name != null)
                            Update_Movie_Details(DataBaseManipulation.DefaultMovie());
                        else
                            Movie = new MovieClass(MovieList.Items[0].Text);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form5 form = new Form5();

                if(form.ShowDialog() != DialogResult.Cancel)
                    Add_MovieToList(form.AddBox.Text);
            }
            catch
            {
                return;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MovieList.SelectedItems[0] != null)
                    Process.Start(Movie.Get_IMDB_Adress());
                else
                    MessageBox.Show("Please select a movie to visit the web page!", "Select a movie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An error occured while trying to visit the web page!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Set_Default_Movie(string Movie_Name)
        {
            try
            {
                DataBaseManipulation.Update_General("[DefaultMovie] = 0");
                DataBaseManipulation.Update_General("[DefaultMovie] = 1 WHERE Name = '" + Movie_Name + "'");
            }
            catch
            {
                return;
            }
        }

        private void setDefaultMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Set_Default_Movie(MovieList.SelectedItems[0].Text);
            }
            catch
            {
                return;
            }
        }

        private void Error_Message()
        {
            MessageBox.Show("Unavailable to execute this process!", "Unavailable processing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                AboutBox1 form = new AboutBox1();

                form.ShowDialog();
            }
            catch
            {
                Error_Message();
            }
        }

        private void visitPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://www.imdb.com" + Movie.Get_StarsLink()[StarList.SelectedIndices[0]]);
            }
            catch
            {
                Error_Message();
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            try
            {
                Form6 form = new Form6(Movie, true);
                form.Text = Movie.Movie_Name + "'s review edit";

                form.ShowDialog();
                Movie = new MovieClass(Movie.Movie_Name);

                ReviewRichTextBox.Text = Movie.Get_Review().Replace(@"\n", Environment.NewLine).Replace(@"\r", Environment.NewLine);
            }
            catch
            {
                Error_Message();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            try
            {
                Form6 form = new Form6(Movie, false);
                form.Text = Movie.Movie_Name + "'s review";

                form.Show();
            }
            catch
            {
                Error_Message();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ReviewRichTextBox.Copy();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            ReviewRichTextBox.SelectAll();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DescriptionTextBox.Copy();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DescriptionTextBox.SelectAll();
        }

        private void MultiUpdate_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();

            form.ShowDialog();

            if(form.Result == DialogResult.OK)
                Update_MovieList();
        }

        private void MovieList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            TheColumnSorter.Column = e.Column;
            MovieList.Sort();
            TheColumnSorter.Last = e.Column;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                HideWindow();
            else
                State = this.WindowState;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (isHide == true)
                UnhideWindow();
            else
                HideWindow();
        }

        public void HideWindow()
        {
            this.Hide();

            notifyIcon1.BalloonTipTitle = "Movie Maniacs";
            notifyIcon1.BalloonTipText = "Your personal movie collection!";
            notifyIcon1.ShowBalloonTip(2000);
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            hideWindowToolStripMenuItem.Visible = false;

            isHide = true;
        }

        public void UnhideWindow()
        {
            this.Show();
            WindowState = State;
            hideWindowToolStripMenuItem.Visible = true;

            isHide = false;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(isHide)
                UnhideWindow();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string ClearingMovie = MovieList.SelectedItems[0].Text.ToString();
                MovieClass movie = new MovieClass(ClearingMovie);

                if (Directory.Exists("images\\" + movie.Index.ToString() + " Stars") == true)
                    Directory.Delete("images\\" + movie.Index.ToString() + " Stars", true);
                if (File.Exists("images\\" + movie.Index.ToString() + ".jpg") == true)
                    File.Delete("images\\" + movie.Index.ToString() + ".jpg");

                Movie = new MovieClass(ClearingMovie);
                MovieClass MovieAux = new MovieClass();
                MovieAux.Movie_Name = Movie.Movie_Name;
                MovieAux.Set_Date(Movie.Get_Date_Day().ToString(), Movie.Get_Date_Month().ToString(), Movie.Get_Date_Year().ToString());
                MovieAux.Set_IMDB_Adress(Movie.Get_IMDB_Adress());
                MovieAux.Set_Mark(Movie.Get_Mark());
                MovieAux.Set_Review(Movie.Get_Review());
                if (DataBaseManipulation.DefaultMovie().Movie_Name == MovieAux.Movie_Name)
                    MovieAux.Default = true;
                DataBaseManipulation.UpdateMovie(MovieAux);

                Update_Movie_Details(MovieAux);

                reloadToolStripMenuItem_Click(sender, e);

                MessageBox.Show("\"" + ClearingMovie + "\" was successfully cleaned!", "Successfully cleaned", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                Error_Message();
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movie = new MovieClass(MovieList.SelectedItems[0].Text);

            Update_MovieList(MovieList.SelectedIndices[0]);

            Update_Movie_Details(Movie);
        }

        private void hideWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideWindow();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            JumpForm form = new JumpForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                Movie = new MovieClass(form.Result);

                Update_Movie_Details(Movie);
                for (int i = 0; i < MovieList.Items.Count; i++)
                    if (form.Result.ToUpper() == MovieList.Items[i].Text.ToUpper())
                        MovieList.Items[i].Selected = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.J) 
                toolStripButton8_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.imdb.com/" + Movie.DirectorLink);
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportForm form = new ExportForm(1);

            form.ShowDialog();
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExportForm form = new ExportForm(2);

            form.ShowDialog();

            form.Dispose();
        }

        private void NotifyIconMessage(string Title, string MessageTip, int delay)
        {
            notifyIcon1.BalloonTipTitle = Title;
            notifyIcon1.BalloonTipText = MessageTip;
            notifyIcon1.ShowBalloonTip(delay);
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
        }

        private void TrailerButton_Click(object sender, EventArgs e)
        {
            try
            {
                TrailerForm form = new TrailerForm(new MovieClass(MovieList.SelectedItems[0].Text));

                NotifyIconMessage("Movie Maniacs Trailers", "Some videos can't be viewed in this application, due to YouTube restrictions!", 500);

                form.ShowDialog();

                form.Dispose();
            }
            catch
            {
                Error_Message();
            }
        }

        private int MovieIndex(string name)
        {
            for (int i = 0; i < MovieList.Items.Count;i++ )
                if (MovieList.Items[i].Text == name)
                    return i;

            return -1;
        }

        private void iMDBListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListIMDBform form = new ListIMDBform();

            form.ShowDialog();
             
            if(form.Updated == true)
                Update_MovieList();

            form.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
             newToolStripButton.Visible = toolStripMenuItem3.Checked;
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openToolStripButton.Visible = editToolStripMenuItem2.Checked;
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            deleteToolStripButton.Visible = deleteToolStripMenuItem1.Checked;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            try
            {
                Form9 form = new Form9();
                form.Show();
            }
            catch
            {
                return;
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            RecommandationsForm form = new RecommandationsForm();

            form.ShowDialog();

            if (form.updated)
                Update_MovieList();

            form.Dispose();
        }

        private void OscarPicture_Click(object sender, EventArgs e)
        {
            if (Movie.Get_IMDB_Name().Length > 1)
                Process.Start(Movie.Get_IMDB_Adress()+"awards");

            else Error_Message();
        }

        private void privacyPolicyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrivacyPolicy form = new PrivacyPolicy();
            form.ShowDialog();
        }


    }
}
