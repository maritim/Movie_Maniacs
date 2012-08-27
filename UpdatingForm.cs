using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;

namespace Movie_Maniacs
{
    public partial class UpdatingForm : Form
    {
        private CheckedListBox MovieList;

        public UpdatingForm(CheckedListBox movielist)
        {
            InitializeComponent();

            MovieList = movielist;
        }

        private int NumberOfUpdatedItems()
        {
            int NumberOfUpdates = 0;

            for (int i = 0; i < MovieList.Items.Count; i++)
                if (MovieList.GetItemChecked(i) == true)
                    ++NumberOfUpdates;

            return NumberOfUpdates;
        }

        private void UpdatingForm_Load(object sender, EventArgs e)
        {

            MovieClass Movie = new MovieClass();

            double count = 0;
            int NumberOfUpdates = NumberOfUpdatedItems();

            for (int i = 0; i < MovieList.Items.Count; i++)
            {
                if (MovieList.GetItemChecked(i) == true)
                {
                    Movie = new MovieClass(MovieList.Items[i].ToString());

                    MovieName.Text = "Updating: " + Movie.Movie_Name;

                    count += 100.0 / NumberOfUpdates;
                    progressBar1.Value = (int)(count + .5) <= 100 ? (int)(count + .5) : 100;

                    Thread newThread = new Thread(new ThreadStart(Movie.Update_Movie));

                    try
                    {
                        newThread.Start();
                        newThread.Join();
                    }
                    catch { }
                }
            }

            this.Close();
        }
    }
}
