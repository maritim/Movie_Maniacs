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
    public partial class PosterForm : Form
    {
        private string Movie_Name;
        private int Index;

        public PosterForm(string MovieName,int index)
        {
            InitializeComponent();

            Movie_Name = MovieName;
            Index = index;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(File.Exists("images\\" + Index.ToString() + ".jpg"))
                MoviePosterBig.ImageLocation = "images\\" + Index.ToString() + ".jpg";
            else
                MoviePosterBig.ImageLocation = "film.png";
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "JPEG (*.jpg) | *.jpg"; 
            file.Title = "Load poster from file";

            file.ShowDialog();

            try
            {
                Image image = Image.FromFile(file.FileName);

                File.Delete("images\\" + Index + ".jpg");

                image.Save("images\\" + Index + ".jpg");

                MoviePosterBig.Image = image;

                MessageBox.Show("\"" + Movie_Name + "\" 's poster was successfully updated!", "Succesfully updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                if(file.FileName != "")
                    MessageBox.Show("Unavailable to load \"" + file.FileName + "\"!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveImageToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "JPEG Image|*.jpg";
            sfd.Title = "Save poster to file";
            sfd.FileName = WorkerClass.AvailableFolderName(Movie_Name) + ".jpg";

            try
            {
                if (sfd.ShowDialog() != DialogResult.Cancel)
                {
                    Image Poster = MoviePosterBig.Image;
                    if (File.Exists(sfd.FileName) == true)
                        File.Delete(sfd.FileName);

                    Poster.Save(sfd.FileName);
                }
            }
            catch
            {
                return;
            }
        }
    }
}
