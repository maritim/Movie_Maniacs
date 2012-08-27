using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Movie_Maniacs
{
    public partial class JumpForm : Form
    {
        public JumpForm()
        {
            InitializeComponent();
        }

        List<string> movies;
        private string result;

        private void JumpForm_Load(object sender, EventArgs e)
        {
            movies = DataBaseManipulation.MovieDetails("Name");

            foreach(string movie in movies)
                ResultList.Items.Add(movie);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] SearchQuerry = SearchBox.Text.Split(new char[] { ' ' });

                ResultList.Items.Clear();

                foreach(string movie in movies)
                {
                    bool isOkay = true;

                    foreach (string s in SearchQuerry)
                        if (movie.ToUpper().IndexOf(s.ToUpper()) < 0)
                            isOkay = false;

                    if (isOkay == true)
                        ResultList.Items.Add(movie);
                }

                ResultList.Items[0].Selected = true;
            }
            catch
            {
                return;
            }
        }

        public string Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
            }
        }

        private void ResultList_ItemActivate(object sender, EventArgs e)
        {
            result = ResultList.SelectedItems[0].Text;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
