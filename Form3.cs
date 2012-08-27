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
    public partial class Form3 : Form
    {
        private string MovieName;
        private List<string> Star = new List<string>();
        private List<string> StarLink = new List<string>();
        private int ActorNumber;
        private int MovieIndex;

        public Form3(string Name,int index,int ActorNum,List<string> Stars,List<string> StarsLink)
        {
            InitializeComponent();

            MovieName = Name;
            ActorNumber = ActorNum;

            Star = Stars;
            StarLink = StarsLink;
            MovieIndex = index;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Star.Count; i++)
                {
                    int Index = Star[i].IndexOf("/");

                    StarsImageList.Images.Add(Image.FromFile("images\\" + MovieIndex.ToString() + " Stars\\"+Star[i].Substring(0,Index)+".jpg"));

                    ListViewItem item = new ListViewItem("",i);

                    item.SubItems.Add(Star[i].Substring(0, Index));
                    item.SubItems.Add(Star[i].Substring(Index + 1, Star[i].Length-Index-1));

                    StarList.Items.Add(item);
                }
            }
            catch
            {
                return;
            }
        }

        private void visitPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.imdb.com"+StarLink[StarList.SelectedIndices[0]]);
        }
    }
}
