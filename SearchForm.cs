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
    public partial class SearchForm : Form
    {
        private string SearchName;
        public Thread thread;

        public SearchForm(string name)
        {
            InitializeComponent();

            if (name != "Unknown")
                SearchName = name;
        }

        private string Movielink;
        private string[] Movies = new string[1000];

        public string Link
        {
            get
            {
                return Movielink;
            }

            set
            {
                Movielink = value;
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            SearchBox.Focus();
            SearchBox.Text = SearchName;
        }

        void SearchMovies()
        {
            for (; MovieList.Items.Count > 0; MovieList.Items.Remove(MovieList.Items[0])) ;

            string sourceCode = WorkerClass.GetSourceCode("http://www.imdb.com/find?q=" + SearchBox.Text.Replace(" ", "+") + "&s=all");

            int startIndex = sourceCode.IndexOf("<td valign=\"top\">");
            int endIndex;
            int link;
            try
            {
                if (startIndex < 0)
                {
                    Results.Text = "1 movie found";

                    string title;

                    startIndex = sourceCode.IndexOf("<meta name=\"title\" content=\"") + 28;
                    endIndex = sourceCode.IndexOf("\" />", startIndex);
                    title = WorkerClass.StringWithoutHtmlFormat(sourceCode.Substring(startIndex, endIndex - startIndex));

                    Movies[0] = WorkerClass.GetResponseUri("http://www.imdb.com/find?q=" + SearchBox.Text.Replace(" ", "+") + "&s=all");
                    if (Movies[0].IndexOf("?") > 0)
                        Movies[0] = Movies[0].Substring(0, Movies[0].IndexOf("?") + 1);
                    Movies[0] = Movies[0].Substring(19, Movies[0].Length - 20);

                    MovieList.Items.Add(title);

                    return;
                }

                for (int i = 0; startIndex >= 0; i++)
                {
                    //startIndex = sourceCode.IndexOf("</a> (", startIndex) - 100;

                    do
                    {
                        link = sourceCode.IndexOf("/title", startIndex);
                        startIndex = sourceCode.IndexOf("';\">", startIndex) + 4;
                    }
                    while (sourceCode[startIndex] == '<');

                    Movies[i] = sourceCode.Substring(link, sourceCode.IndexOf("\" onclick=\"", link) - link);
                    endIndex = sourceCode.IndexOf(")", startIndex) + 1;
                    MovieList.Items.Add(WorkerClass.StringWithoutHtmlFormat(sourceCode.Substring(startIndex, endIndex - startIndex).Replace("</a>", "")));
                    startIndex = sourceCode.IndexOf(")        ", startIndex);

                    Results.Text = i + 1 + " movies found";
                }
            }
            catch
            {
                return;
            }
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //thread = new Thread(SearchMovies);
            //thread.Start();
            SearchMovies();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

        private void MovieList_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < MovieList.Items.Count; i++)
                MovieList.SetItemChecked(i, false);

            MovieList.SetItemChecked(MovieList.SelectedIndices[0], true);

            Movielink = Movies[MovieList.SelectedIndex];
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Movielink = "";

            this.Close();
        }
    }
}
